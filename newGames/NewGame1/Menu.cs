using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void minhaÁreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Minha_area novo = new Minha_area();
            novo.Show();
            this.Hide();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            minhaArea2 novo = new minhaArea2();
            novo.Show();
            this.Hide();
        }

        private void btnCalculos_Click(object sender, EventArgs e)
        {
            minhaArea3 novo = new minhaArea3();
            novo.Show();
            this.Hide();
        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            minhaArea4 novo = new minhaArea4();
            novo.Show();
            this.Hide();
        }
    }
}
