using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //namespace MySQL

namespace NewGame
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string StrConexao = "server = localhost; database = newgames; User id = root; password = sql123";

            MySqlConnection conexao = new MySqlConnection(StrConexao);

            try
            {
                conexao.Open();

                if (Application.OpenForms.OfType<Menu>().Count() > 0)
                {
                    Form user = Application.OpenForms["Menu"];
                    user.Show();
                    this.Hide();
                }
                else
                {
                    Menu user = new Menu();
                    user.Show();
                    this.Hide();
                }


                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Acesso negado! Erro: " + erro);
            }
        }

        private void btn_entrar_KeyDown(object sender, KeyEventArgs e)
        {
            //se o código for igual ao botão enter ele aciona o evento
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_entrar.PerformClick();
            }
        }

        private void tb_cadastro_Click(object sender, EventArgs e)
        {
            Cadastro novo = new Cadastro();
            novo.Show();
            this.Hide();
        }

        private void tb_cadastro_Click_1(object sender, EventArgs e)
        {
            Cadastro novo = new Cadastro();
            novo.Show();
            this.Hide();
        }
        }
    }

