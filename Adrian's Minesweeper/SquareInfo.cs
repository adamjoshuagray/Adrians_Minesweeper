using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adrians_Minesweeper
{
    public enum SquareState
    {
        Open,
        Closed,
        Flagged
    }
    class SquareInfo
    {
        public SquareCoordinate Coordinate { get; private set; }
        public SquareState State { get; private set; }
        public bool HasMine { get; private set; }
        public void SetMine()
        {
            HasMine = true;
        }
        public void ToggleFlag()
        {
            if (State == SquareState.Flagged)
            {
                State = SquareState.Closed;
            }
            else if (State == SquareState.Closed)
            {
                State = SquareState.Flagged;
            }
            else
            {
                throw new InvalidOperationException("Cannot toggle flag on a open square.");
            }

        }
        public void Open()
        {
            if (State == SquareState.Closed && !HasMine)
            {
                State = SquareState.Open;
            }
            else
            {
                throw new InvalidOperationException("This type of square cannot be opened.");
            }
        }
        public SquareInfo(SquareCoordinate coordinate)
        {
            Coordinate      = coordinate;
            State           = SquareState.Closed;
            HasMine         = false;
        }
    }
}
