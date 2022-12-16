using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        List<PictureBox> MeteoriteList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            loadMeteorite(MeteroritePicBox);
            run();
            Cursor.Hide();
        }

        void loadMeteorite(PictureBox picbox)
        {
            Bitmap meteorite;
            if (rand.Next() % 2 == 0)
            {
                meteorite = new Bitmap("D:\\Lab5\\Image\\meteorite-pngrepo-com.png");
            }
            else
            {
                meteorite = new Bitmap("D:\\Lab5\\Image\\meteorite-space-pngrepo-com.png");
            }
            picbox.Image = meteorite;
        }
        void run()
        {
            MeteroritePicBox.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MeteroritePicBox.Top = MeteroritePicBox.Top + 4;
            if (MeteroritePicBox.Top >= this.Size.Height)
            {
                MeteroritePicBox.Top = 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (PlanePicBox.Left > 0)
                        PlanePicBox.Left -= 2;
                    break;
                case Keys.Right:
                    break;
                case Keys.Up:
                    break;
                case Keys.Down:
                    break;

                default:
                    break;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PlanePicBox.Location = MousePosition;
        }
    }
}
