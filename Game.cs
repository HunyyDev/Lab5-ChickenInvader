using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Game : Form
    {
        Piece _rocket;
        List<Piece> _bullets = new List<Piece>();
        List<Piece> _meteos = new List<Piece>();

        public Game()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _rocket = new Piece(50, 50);
            _rocket.Left = Width / 2 - _rocket.Width / 2;
            _rocket.Top = Height - _rocket.Height * 2;
            _rocket.Image = Properties.Resources.ship;
            Controls.Add(_rocket);
            Cursor.Hide();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _rocket.Left -= 10;
                    break;
                case Keys.Down:
                    _rocket.Top += 10;
                    break;
                case Keys.Right:
                    _rocket.Left += 10;
                    break;
                case Keys.Up:
                    _rocket.Top -= 10;
                    break;
                default:
                    break;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) LauchBullet();
        }

        private void LauchBullet()
        {
            Piece bullet = new Piece(10, 10);
            bullet.Left = _rocket.Left + _rocket.Width / 2 - bullet.Width / 2;
            bullet.Top = _rocket.Top - bullet.Height;
            bullet.Image= Properties.Resources.bullet; 
            _bullets.Add(bullet); 
            Controls.Add(bullet);
        }

        private void bulletsTm_Tick(object sender, EventArgs e)
        {
            for(int i=0; i<_bullets.Count; i++)
            {
                _bullets[i].Top -= 3;
                if (_bullets[i].Top <= 0)
                {
                    Controls.Remove(_bullets[i]);
                    _bullets.RemoveAt(i);

                }
            }
            collision();
        }

        private void collision()
        {
            for(int i=0; i< _meteos.Count; i++)
            {
                for(int j=0; j<_bullets.Count; j++)
                {
                    if (_meteos[i].Bounds.IntersectsWith(_bullets[j].Bounds))
                    {

                        Controls.Remove(_meteos[i]);
                        _meteos.RemoveAt(i);
                        Controls.Remove(_bullets[j]);
                        _bullets.RemoveAt(j);
                        i--;
                        j--;
                    }
                }
            }
        }

        private void meteoriteGenerateTm_Tick(object sender, EventArgs e)
        {
            var rnd = new Random();
            int num = rnd.Next(2);
            for(int i=0; i<num; i++)
            {
                var size = rnd.Next(100);
                Piece meteo = new Piece(size,size);
                meteo.Top = 0;
                meteo.Left = rnd.Next(Width);
                meteo.Image = Properties.Resources.meteorite1;
                Controls.Add(meteo);
                _meteos.Add(meteo);
            }
        }

        private void meteoriteFallTm_Tick(object sender, EventArgs e)
        {
            foreach (var meteo in _meteos)
            {
                meteo.Top += 3;
                if (meteo.Bottom == 0)
                {
                    Controls.Remove(meteo);
                    _meteos.Remove(meteo);
                    meteo.Dispose();
                }
            }
            meteoriteCollision();
        }

        private void meteoriteCollision()
        {
            foreach (var meteo in _meteos)
            {
                if(meteo.Bounds.IntersectsWith(_rocket.Bounds))
                {
                    EndGame();
                }
            }
        }

        private void EndGame()
        {
            bulletsTm.Stop();
            meteoriteFallTm.Stop();
            meteoriteGenerateTm.Stop();
            Controls.Clear();
            MessageBox.Show("END GAME");
        }
    }
}
