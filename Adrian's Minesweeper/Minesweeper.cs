using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adrians_Minesweeper
{
    public partial class Minesweeper : UserControl
    {

        /// <summary>
        /// This is called if the game of minesweeper is won.
        /// </summary>
        public event EventHandler       OnWin;
        /// <summary>
        /// This is called if the game of minesweeper is lost.
        /// </summary>
        public event EventHandler       OnLoose;
        /// <summary>
        /// This is called when the game of minesweeper starts. This happens after the first click.
        /// </summary>
        public event EventHandler       OnStart;
        /// <summary>
        /// This is triggered when the flagged state of a square is changed.
        /// </summary>
        public event EventHandler       OnFlagChange;

        /// <summary>
        /// Indicates whether the flags should be placed automatically when it is "easy" to deduce that they must be placed.
        /// </summary>
        public bool                     AutoFlag { get; set; }
        /// <summary>
        /// Indicates whether squares should be cleared automatically when it is "easy" to deduce when they can be cleared.
        /// </summary>
        public bool                     AutoClear { get; set; }

        /// <summary>
        /// This number of squares wide the board is.
        /// </summary>
        public int                      GridWidth { get; private set; }
        /// <summary>
        /// The number of squares hight the board is.
        /// </summary>
        public int                      GridHeight { get; private set; }
        /// <summary>
        /// The number of mines on the board.
        /// </summary>
        public int                      Mines { get; private set; }
        /// <summary>
        /// The number of flagged squares on the board.
        /// </summary>
        public int                      FlaggedSquares { get; private set; }

        private bool                    _Started = false;
        private bool                    _Lost = false;
        private bool                    _Won = false;

        private const int               _BUTTON_SIZE = 30;
        private const string            _MINE_STR = "*";
        private const string            _FLAG_STR = "F";

        private const string            _FONT_STRING = "Courier New";
        private const int               _FONT_SIZE = 16;

        private Color                   _CLOSED_COLOR = Color.White;
        private Color                   _OPEN_COLOR = Color.Black;
        private Color                   _MINE_COLOR = Color.Red;
        private Color                   _FLAG_COLOR = Color.Yellow;
        private Color[]                 _NUMBER_COLORS = {Color.LightBlue, 
                                                          Color.LightPink, 
                                                          Color.LightGreen, 
                                                          Color.LightPink, 
                                                          Color.PeachPuff, 
                                                          Color.White, 
                                                          Color.LightYellow, 
                                                          Color.LightSalmon};

        private Color[]                 _BACK_COLORS = { Color.DarkBlue,
                                                         Color.DarkRed,
                                                         Color.DarkGreen,
                                                         Color.DarkViolet,
                                                         Color.OrangeRed,
                                                         Color.DarkGray,
                                                         Color.DarkGoldenrod,
                                                         Color.Brown };


        private SquareInfo[,] sArray;
        private Button[,] bArray;

        public Minesweeper(int width, int height, int mines)
        {
            InitializeComponent();
            if (width * height <= mines)
            {
                throw new ArgumentException("There must be more squares than mines.");
            }
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Must have positive dimensions");
            }
            Mines           = mines;
            GridWidth       = width;
            GridHeight      = height;
            FlaggedSquares  = 0;

            sArray = new SquareInfo[GridWidth, GridHeight];
            for (int i = 0; i < GridWidth; i++)
            {
                for (int j = 0; j < GridHeight; j++)
                {
                    sArray[i, j] = new SquareInfo(new SquareCoordinate() { x = i, y = j });
                }
            }
            _LayoutButtons();
            Width = GridWidth * _BUTTON_SIZE;
            Height = GridHeight * _BUTTON_SIZE;
        }

        private void _LayoutButtons()
        {
            bArray = new Button[GridWidth, GridHeight];
            for (int i = 0; i < GridWidth; i++)
            {
                for (int j = 0; j < GridHeight; j++)
                {
                    Button b                = new Button();
                    b.FlatStyle             = FlatStyle.Flat;
                    b.Width                 = _BUTTON_SIZE;
                    b.Height                = _BUTTON_SIZE;
                    b.Left                  = i * _BUTTON_SIZE;
                    b.Top                   = j * _BUTTON_SIZE;
                    b.Font                  = new System.Drawing.Font(_FONT_STRING, _FONT_SIZE, FontStyle.Bold); 
                    b.Parent                = this;
                    b.BackColor             = Color.White;
                    b.Tag                   = new SquareCoordinate() { x = i, y = j };
                    b.Click                 += new EventHandler(_b_Click);
                    b.MouseUp               +=new MouseEventHandler(_b_MouseUp);
                    bArray[i, j]            = b;
                    b.Show();
                }
            }
        }

        void _b_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (_Lost || _Won)
                {
                    return;
                }
                Button b = (Button)sender;
                SquareCoordinate c = (SquareCoordinate)b.Tag;
                _FlagSquare(c, true);
            }
        }

        private void _FlagSquare(SquareCoordinate c, bool toggle)
        {
            Button b = bArray[c.x, c.y];
            SquareInfo si = sArray[c.x, c.y];
            if (!toggle)
            {
                if (si.State == SquareState.Flagged)
                {
                    //Already flagged.
                    return;
                }
            }
            if (si.State != SquareState.Open)
            {
                si.ToggleFlag();
                if (si.State == SquareState.Flagged)
                {
                    b.Text = _FLAG_STR;
                    b.BackColor = _FLAG_COLOR;
                    b.ForeColor = Color.Black;
                }
                else
                {
                    b.Text = "";
                    b.BackColor = Color.White;
                    b.ForeColor = Color.Black;
                }
                FlaggedSquares = _CountFlags();
                if (OnFlagChange != null)
                {
                    OnFlagChange(this, new EventArgs());
                }
            }
        }

        private void _RunAutoFlag()
        {
            bool change = false;
            for (int i = 0; i < GridWidth; i++)
            {
                for (int j = 0; j < GridHeight; j++)
                {
                    int mines = _CountMines(new SquareCoordinate() { x = i, y = j });
                    int flags = _CountState(new SquareCoordinate() { x = i, y = j }, SquareState.Flagged);
                    int closeds = _CountState(new SquareCoordinate() { x = i, y = j }, SquareState.Closed);
                    if (sArray[i,j].State == SquareState.Open && mines == flags + closeds)
                    {
                        change = true;
                        _FlagClosedNeighbours(new SquareCoordinate() { x = i, y = j });
                    }
                }
            }
        }

        private void _RunAutoClear()
        {
            for (int i = 0; i < GridWidth; i++)
            {
                for (int j = 0; j < GridHeight; j++)
                {
                    int mines = _CountMines(new SquareCoordinate() { x = i, y = j });
                    int flags = _CountState(new SquareCoordinate() { x = i, y = j }, SquareState.Flagged);
                    int closeds = _CountState(new SquareCoordinate() { x = i, y = j }, SquareState.Closed);
                    if (sArray[i, j].State == SquareState.Open && mines == flags)
                    {
                        _TriggerClosedNeighbours(new SquareCoordinate() { x = i, y = j });
                    }
                }
            }
        }
        private void _FlagClosedNeighbours(SquareCoordinate c)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (c.x + i < 0 || c.x + i >= GridWidth || c.y + j < 0 || c.y + j >= GridHeight || (i == 0 && j == 0))
                    {
                        continue;
                    }
                    else
                    {
                        _FlagSquare(new SquareCoordinate() { x = c.x + i, y = c.y + j }, false);
                    }
                }
            }
        }

        private void _TriggerClosedNeighbours(SquareCoordinate c)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (c.x + i < 0 || c.x + i >= GridWidth || c.y + j < 0 || c.y + j >= GridHeight || (i == 0 && j == 0))
                    {
                        continue;
                    }
                    else
                    {
                        _TriggerSquare(new SquareCoordinate() { x = c.x + i, y = c.y + j });
                    }
                }
            }
        }
        private bool _CheckWin()
        {
            int closedflags = _CountState(SquareState.Closed) + _CountState(SquareState.Flagged);
            return closedflags == Mines;
        }

        private int _CountFlags()
        {
            return _CountState(SquareState.Flagged);
        }

        void _b_Click(object sender, EventArgs e)
        {
            Button b            = (Button)sender;
            SquareCoordinate c  = (SquareCoordinate)b.Tag;
            if (_Lost || _Won)
            {
                return;
            }
            if (!_Started)
            {
                _Started = true;
                _LayoutMines(c);
                if (OnStart != null)
                {
                    OnStart(this, new EventArgs());
                }
            }
            _TriggerSquare(c);
            bool change = true;
            while (change)
            {
                int oldflags = _CountFlags();
                int oldopens = _CountState(SquareState.Open);
                change = false;
                if (AutoFlag)
                {
                    _RunAutoFlag();
                }
                if (AutoClear)
                {
                    _RunAutoClear();
                }
                int newflags = _CountFlags();
                int newopens = _CountState(SquareState.Open);
                change = (newflags != oldflags || newopens != oldopens);
            }
            if (_CheckWin() && OnWin != null)
            {
                OnWin(this, new EventArgs());
            }
        }

        private void _TriggerSquare(SquareCoordinate c)
        {
            Button b = bArray[c.x, c.y];
            SquareInfo si = sArray[c.x, c.y];
            if (si.State == SquareState.Flagged)
            {
                //Don't allow trigger on a flagged square.
                return;
            }
            if (si.State == SquareState.Open)
            {
                //Don't allow trigger on already opened squares.
                return;
            }
            if (si.HasMine)
            {
                b.BackColor = _MINE_COLOR;
                b.Text = _MINE_STR;
                _Lost = true;
                _RevealMines();
                if (OnLoose != null)
                {
                    OnLoose(this, new EventArgs());
                }
                return;
            }
            b.BackColor = Color.Black;
            int mines = _CountMines(c);
            si.Open();
            if (mines > 0)
            {
                b.ForeColor         = _NUMBER_COLORS[mines - 1];
                b.BackColor         = _BACK_COLORS[mines - 1];
                b.Text = mines.ToString();
            }
            else
            {
                _TriggerNeighbours(c);
            }
        }

        private void _RevealMines()
        {
            for (int i = 0; i < GridWidth; i++)
            {
                for (int j = 0; j < GridHeight; j++)
                {
                    Button b = bArray[i,j];
                    if (sArray[i, j].HasMine)
                    {
                        b.BackColor = _MINE_COLOR;
                        b.ForeColor = Color.Black;
                        b.Text = _MINE_STR;
                    }
                }
            }
        }

        private void _TriggerNeighbours(SquareCoordinate c)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (c.x + i < 0 || c.x + i >= GridWidth || c.y + j < 0 || c.y + j >= GridHeight || (i == 0 && j == 0))
                    {
                        continue;
                    }
                    else
                    {
                        _TriggerSquare(new SquareCoordinate() { x = c.x + i, y = c.y + j});
                    }
                }
            }
        }

        private int _CountMines(SquareCoordinate c)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (c.x + i < 0 || c.x + i >= GridWidth || c.y + j < 0 || c.y + j >= GridHeight || (i == 0 && j == 0))
                    {
                        continue;
                    }
                    else
                    {
                        if (sArray[c.x + i, c.y + j].HasMine)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        private int _CountState(SquareCoordinate c, SquareState state)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (c.x + i < 0 || c.x + i >= GridWidth || c.y + j < 0 || c.y + j >= GridHeight || (i == 0 && j == 0))
                    {
                        continue;
                    }
                    else
                    {
                        if (sArray[c.x + i, c.y + j].State == state)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        private int _CountState(SquareState state)
        {
            int count = 0;
            for (int i = 0; i < GridWidth; i++)
            {
                for (int j = 0; j < GridHeight; j++)
                {
                    if (sArray[i, j].State == state)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private void _LayoutMines(SquareCoordinate exclude)
        {
            int remainingMines      = Mines;
            Random r                = new Random();
            while (remainingMines > 0)
            {
                int x = r.Next(0, GridWidth);
                int y = r.Next(0, GridHeight);
                if (!sArray[x, y].HasMine && (exclude.x != x || exclude.y != y))
                {
                    sArray[x, y].SetMine();
                    remainingMines--;
                }
            }
        }
        
    }
}
