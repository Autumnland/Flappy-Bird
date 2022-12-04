using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {

        int velocidad = 8;
        int gravedad = 5;
        int puntaje = 0;
        int a = 5;
        int b;
        int cont = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void TemporizadorEvento(object sender, EventArgs e)
        {

            Flappy.Top += gravedad;
            TuboB.Left -= velocidad;
            TuboA.Left -= velocidad;
            Puntos.Text = "Puntaje " + puntaje;

            if (TuboB.Right < 0)
            {
                TuboB.Left = 700;
                puntaje++;
            }

            if (TuboA.Right < 0)
            {
                TuboA.Left = 850;
                puntaje++;
            }

            if (Flappy.Bounds.IntersectsWith(TuboB.Bounds) ||
                Flappy.Bounds.IntersectsWith(TuboA.Bounds) ||
                Flappy.Bounds.IntersectsWith(Suelo.Bounds) || Flappy.Top < 0
                )
            {
                EndGame();
            }

            b = a * cont;

            if (puntaje > b)
            {
                cont++;
                velocidad += 1;
            }

        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravedad = -10;
            }

            if (e.KeyCode == Keys.Enter && !Temporizador.Enabled)
            {
                Temporizador.Start();
                velocidad = 8;
                gravedad = 5;
                puntaje = 0;
                cont = 1;
                a = 5;
                b = 0;
                Flappy.Location = new Point(71, 210);
                TuboA.Location = new Point(500, -31);
                TuboB.Location = new Point(405, 401);
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravedad = 10;
            }

        }

        private void EndGame()
        {
            Temporizador.Stop();
            Puntos.Text += " Game over !!! - Enter para reiniciar";

        }
    }
}
