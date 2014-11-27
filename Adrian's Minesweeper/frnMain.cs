using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adrians_Minesweeper
{
    public partial class frmMain : Form
    {
        private Minesweeper _Board;
        private int _TimeCount;

        public frmMain()
        {
            InitializeComponent();
            _TimeCount = 0;
        }
        

        private void tstbStart_Click(object sender, EventArgs e)
        {

            int width = 0;
            int height = 0;
            int mines = 0;
            _TimeCount = 0;

            tstbHeight.BackColor = int.TryParse(tstbHeight.Text, out height) ? SystemColors.Window : Color.Red;
            tstbWidth.BackColor = int.TryParse(tstbWidth.Text, out width) ? SystemColors.Window : Color.Red;
            tstbMines.BackColor = int.TryParse(tstbMines.Text, out mines) ? SystemColors.Window : Color.Red;

            tstbMines.BackColor = mines > 0 && mines < width * height ? SystemColors.Window : Color.Red;
            tstbWidth.BackColor = width > 0 && width <= 75 ? SystemColors.Window : Color.Red;
            tstbHeight.BackColor = height > 0 && height <= 75 ? SystemColors.Window : Color.Red;

            if (!(mines > 0 && mines < width * height && width > 0 && width <= 75 && height > 0 && height <= 75))
            {
                //Invalid input.
                return;
            }

            if (_Board != null)
            {
                _Board.Dispose();
            }

            Minesweeper ms = new Minesweeper(width, height, mines);
            ms.Parent = panMain;
            ms.Dock = DockStyle.Fill;
            ms.OnFlagChange += new EventHandler(ms_OnFlagChange);
            ms.OnWin += new EventHandler(ms_OnWin);
            ms.OnLoose += new EventHandler(ms_OnLoose);
            ms.AutoClear = (tstbAutoFlag.CheckState == CheckState.Checked);
            ms.AutoFlag = (tstbAutoFlag.CheckState == CheckState.Checked);
            ms.OnStart += new EventHandler(ms_OnStart);
            tslFlagged.Text = "F: 0/" + mines.ToString();
            tslTime.Text = "T: 0";
            ms.Show();
            tslWinLoose.Visible = false;
            _Board = ms;
            tmrMain.Enabled = false;
        }

        void ms_OnStart(object sender, EventArgs e)
        {
            tmrMain.Enabled = true;
        }

        void ms_OnLoose(object sender, EventArgs e)
        {
            tslWinLoose.Text = "Lost";
            tslWinLoose.ForeColor = Color.Red;
            tslWinLoose.Visible = true;
            tmrMain.Enabled = false;
        }

        void ms_OnWin(object sender, EventArgs e)
        {
            tslWinLoose.Text = "Win";
            tslWinLoose.ForeColor = Color.Green;
            tslWinLoose.Visible = true;
            tmrMain.Enabled = false;
        }

        void ms_OnFlagChange(object sender, EventArgs e)
        {
            tslFlagged.Text = "F: " + _Board.FlaggedSquares.ToString() + "/" + _Board.Mines.ToString();
        }

        private void tstbAutoClear_CheckStateChanged(object sender, EventArgs e)
        {
            if (_Board != null)
            {
                _Board.AutoClear = (tstbAutoClear.CheckState == CheckState.Checked);
            }
        }

        private void tstbAutoFlag_CheckStateChanged(object sender, EventArgs e)
        {
            if (_Board != null)
            {
                _Board.AutoFlag = (tstbAutoFlag.CheckState == CheckState.Checked);
            }
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            _TimeCount++;
            tslTime.Text = "T: " + _TimeCount.ToString();
        }

    }
}
