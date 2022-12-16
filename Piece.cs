using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    class Piece : PictureBox
    {
        public Piece(int width, int height) {
            Width = width;
            Height = height;
            SizeMode= PictureBoxSizeMode.StretchImage;
            BackColor = System.Drawing.Color.Transparent;
        }
    }
}
