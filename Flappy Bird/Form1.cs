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
        int puntahe = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void TemporizadorEvento(object sender, EventArgs e)
        {

            Flappy.Top += gravedad;

        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravedad = -5;
            }

        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravedad = 5;
            }

        }
    }
}
