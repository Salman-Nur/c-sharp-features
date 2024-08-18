using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_LSP_examples
{
    internal class ChessBoard3D1 : ChessBoard1
    {
        public int[,,] board3D;
        public ChessBoard3D1(int size) : base(size)
        {
            board3D = new int[size, size, size];

        }
        public void AddPiece(int x, int y, int z)
        {
            board3D[x, y, z] = 1;
        }

    }



}
