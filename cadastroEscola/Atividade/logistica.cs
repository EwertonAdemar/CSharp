using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade
{
    public partial class logistica : Form
    {
        public logistica()
        {
            InitializeComponent();
        }

        private void btn_voltar2_Click(object sender, EventArgs e)
        {
            Menu novo = new Menu();
            novo.Show();
            this.Hide();
        }
    }
}
