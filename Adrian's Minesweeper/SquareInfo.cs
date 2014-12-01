using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adrians_Minesweeper
{
    /// <summary>
    /// The state of a square. A closed square is one which has not been clicked on or otherwise
    /// opened yet.
    /// </summary>
    public enum SquareState
    {
        Open,
        Closed,
        Flagged
    }
    /// <summary>
    /// This contains the information on a square such as it's coordinate, its state and whether it has a mine or not.
    /// </summary>
    class SquareInfo
    {
        /// <summary>
        /// The coordinate of the square.
        /// </summary>
        public SquareCoordinate Coordinate { get; private set; }
        /// <summary>
        /// The state of the square.
        /// </summary>
        public SquareState State { get; private set; }
        /// <summary>
        /// Whether the square has a mine on it or not.
        /// </summary>
        public bool HasMine { get; private set; }
        /// <summary>
        /// This will place a mine on a square. Once a mine has been placed on a square it cannot be removed.
        /// </summary>
        public void SetMine()
        {
            HasMine = true;
        }
        /// <summary>
        /// This toggles the flagged state of the square. Square with flags on them should not be able to be clicked on.
        /// This operation will only work if the square is closed.
        /// </summary>
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
        /// <summary>
        /// This will change the state of a square to opened.
        /// Only squares with no mine, and which are not flagged can be opened.
        /// </summary>
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
        /// <summary>
        /// This creates a new square info object.
        /// </summary>
        /// <param name="coordinate">The coordinate of the square this refers to.</param>
        public SquareInfo(SquareCoordinate coordinate)
        {
            Coordinate      = coordinate;
            State           = SquareState.Closed;
            HasMine         = false;
        }
    }
}
