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
    public partial class minhaArea2 : Form
    {
        public minhaArea2()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TheCrew novo = new TheCrew();
            novo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Call novo = new Call();
            novo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rogue novo = new Rogue();
            novo.Show();
            this.Hide();
        }

        private void GTA_Click(object sender, EventArgs e)
        {
            FarCry novo = new FarCry();
            novo.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Menu novo = new Menu();
            novo.Show();
            this.Hide();
        }
    }
}
