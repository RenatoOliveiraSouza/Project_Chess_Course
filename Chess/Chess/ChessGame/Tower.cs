﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;

namespace Chess.ChessGame
{
    class Tower : Piece
    {
        public Tower(BoarD board, Color color) : base (board, color)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}