using Satranc.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ChessBoard chessBoard = new ChessBoard();
        Button[,] buttons = new Button[8, 8];
        Button selectedButton = null;


        private void Form1_Load(object sender, EventArgs e)
        {
            chessBoard.Initialize();
            CreateBoard();
            RefreshBoard();
        }


        void CreateBoard()
        {
            int size = 60;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(size, size);
                    btn.Location = new Point(j * size, i * size);
                    btn.Tag = new Point(i, j);
                    btn.Click += Square_Click;

                    btn.BackColor = (i + j) % 2 == 0
                        ? Color.White
                        : Color.Black;

                    buttons[i, j] = btn;
                    Controls.Add(btn);
                }
            }
        }

        void Square_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            Point p = (Point)clicked.Tag;
            int x = p.X;
            int y = p.Y;

            if (selectedButton == null)
            {
                if (chessBoard.Board[x, y] != null)
                {
                    selectedButton = clicked;
                    clicked.BackColor = Color.Yellow;
                }
            }
            else
            {
                Point from = (Point)selectedButton.Tag;

                chessBoard.Board[x, y] = chessBoard.Board[from.X, from.Y];
                chessBoard.Board[from.X, from.Y] = null;

                selectedButton.BackColor = (from.X + from.Y) % 2 == 0
                    ? Color.White
                    : Color.Black;

                selectedButton = null;
                RefreshBoard();
            }
        }


        void RefreshBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    var piece = chessBoard.Board[i, j];
                    buttons[i, j].Text = piece == null
                        ? ""
                        : piece.Type.ToString()[0].ToString();
                }
            }
        }


    }
}
