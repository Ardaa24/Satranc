using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Satranc.Model.Enums;

namespace Satranc.Model
{
    internal class ChessPiece
    {
        public PieceType Type { get; }
        public PieceColor Color { get; }

        public ChessPiece(PieceType type, PieceColor color)
        {
            Type = type;
            Color = color;
        }
    }

}
