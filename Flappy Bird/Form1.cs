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

            if (TuboB.Right <0)
            {
                TuboB.Left= 700;
                puntaje++;
            }

            if (TuboA.Right < 0)
            {
                TuboA.Left = 850;
                puntaje++;
            }

            if (Flappy.Bounds.IntersectsWith(TuboB.Bounds) ||
                Flappy.Bounds.IntersectsWith(TuboA.Bounds) ||
                Flappy.Bounds.IntersectsWith(Suelo.Bounds)
                )
            {
                EndGame();
            }

        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravedad = -15;
            }

        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravedad = 15;
            }

        }

        private void EndGame()
        {
            Temporizador.Stop();
            Puntos.Text += " Game over !!!";
        }

    }
}
