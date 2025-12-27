using Satranc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Satranc.Model.Enums;

namespace Satranc.Game
{
    internal class ChessBoard
    {
        public ChessPiece[,] Board { get; } = new ChessPiece[8, 8];

        public void Initialize()
        {
            // Piyonlar
            for (int i = 0; i < 8; i++)
            {
                Board[6, i] = new ChessPiece(PieceType.Pawn, PieceColor.White);
                Board[1, i] = new ChessPiece(PieceType.Pawn, PieceColor.Black);
            }

            // Kaleler
            Board[7, 0] = new ChessPiece(PieceType.Rook, PieceColor.White);
            Board[7, 7] = new ChessPiece(PieceType.Rook, PieceColor.White);
            Board[0, 0] = new ChessPiece(PieceType.Rook, PieceColor.Black);
            Board[0, 7] = new ChessPiece(PieceType.Rook, PieceColor.Black);

            // Atlar
            Board[7, 1] = new ChessPiece(PieceType.Knight, PieceColor.White);
            Board[7, 6] = new ChessPiece(PieceType.Knight, PieceColor.White);
            Board[0, 1] = new ChessPiece(PieceType.Knight, PieceColor.Black);
            Board[0, 6] = new ChessPiece(PieceType.Knight, PieceColor.Black);

            // Filler
            Board[7, 2] = new ChessPiece(PieceType.Bishop, PieceColor.White);
            Board[7, 5] = new ChessPiece(PieceType.Bishop, PieceColor.White);
            Board[0, 2] = new ChessPiece(PieceType.Bishop, PieceColor.Black);
            Board[0, 5] = new ChessPiece(PieceType.Bishop, PieceColor.Black);

            // Vezir & Şah
            Board[7, 3] = new ChessPiece(PieceType.Queen, PieceColor.White);
            Board[7, 4] = new ChessPiece(PieceType.King, PieceColor.White);
            Board[0, 3] = new ChessPiece(PieceType.Queen, PieceColor.Black);
            Board[0, 4] = new ChessPiece(PieceType.King, PieceColor.Black);
        }
    }
}
