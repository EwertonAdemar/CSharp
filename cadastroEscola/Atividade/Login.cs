using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Atividade
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();// Clean() = Função limpar
            txtSenha.Clear();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            String acesso = @"Data Source=FERNANDO\SQLEXPRESS;Initial Catalog=bd_cursos;Integrated Security=True";
            String sqlSelect = "SELECT COUNT(idLogin) FROM tb_login WHERE Login = @login AND Senha = @senha";



            SqlConnection conectar = new SqlConnection(acesso);
            try
            {
                SqlCommand comando = new SqlCommand(sqlSelect, conectar);


                comando.Parameters.Add("@login", SqlDbType.VarChar).Value = txtLogin.Text;
                comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenha.Text;

                conectar.Open();

                int contador = (int)comando.ExecuteScalar();
                if (contador > 0)
                {
                    MessageBox.Show("Seja bem vindo usuário " + txtLogin.Text + "!");

                    Menu novo = new Menu();
                    novo.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario e/ou não cadastrado");
                }


                conectar.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Acesso negado " + erro);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
