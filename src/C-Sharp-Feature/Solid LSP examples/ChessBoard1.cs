using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_LSP_examples
{
    internal class ChessBoard1
    {
        public int[,] board;
        public ChessBoard1(int size)
        {
            board = new int[size, size];
        }
        public void AddPiece(int x, int y)
        {
            board[x, y] = 1; 
        }




    }




}
