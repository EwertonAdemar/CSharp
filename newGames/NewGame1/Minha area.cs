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
    public partial class Minha_area : Form
    {
        public Minha_area()
        {
            InitializeComponent();
        }

        private void Minha_area_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GTA_Click(object sender, EventArgs e)
        {
            GTA novo = new GTA();
            novo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TheCrew novo = new TheCrew();
            novo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Unity novo = new Unity();
            novo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Call novo = new Call();
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
