using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Atividade
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void matrículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matricula novo = new Matricula();
            novo.Show();
            this.Hide();
        }

        private void relátorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatório novo = new Relatório();
            novo.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alunos novo = new Alunos();
            novo.Show();
            this.Hide();
        }

        private void informáticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informatica novo = new informatica();
            novo.Show();
            this.Hide();
        }

        private void logísticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logistica novo = new logistica();
            novo.Show();
            this.Hide();
        }

        private void segurançaTrabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            segurança novo = new segurança();
            novo.Show();
            this.Hide();
        }

        private void mecatrônicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mecatronica novo = new mecatronica();
            novo.Show();
            this.Hide();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos novo = new Cursos();
            novo.Show();
            this.Hide();
        }

        private void períodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Períodos novo = new Períodos();
            novo.Show();
            this.Hide();
        }
    }
}
