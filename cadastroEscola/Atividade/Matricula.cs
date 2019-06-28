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
    public partial class Matricula : Form
    {
        public Matricula()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_cadastro_Click(object sender, EventArgs e)
        {
            // O @ no inicio do endereço da string de conexao ondica que o endereço é um parametro de conexao:
            String strConexao = @"Data Source=FERNANDO\SQLEXPRESS;Initial Catalog=bd_cursos;Integrated Security=True";
            // string de instrução ao comando
            string sql = "INSERT INTO tb_aluno(id_aluno, nm_aluno, id_curso, id_periodo) VALUES ( @id_aluno, @nm_aluno, @id_curso, @id_periodo)";


            //instancia o objeto de conexao
            SqlConnection conectar = new SqlConnection(strConexao);


            try
            {
                // objeto que permite a interação com o sql:
                SqlCommand comando = new SqlCommand(sql, conectar);// sql = Chama string da função e conectar = chama a conexão ao banco

                // atribuir os dados aos parametros:
                comando.Parameters.Add(new SqlParameter("@id_aluno", txt_codigo.Text));
                comando.Parameters.Add(new SqlParameter("@nm_aluno", txt_nome.Text));
                comando.Parameters.Add(new SqlParameter("@id_curso", txt_curso.Text));
                comando.Parameters.Add(new SqlParameter("@id_periodo", txt_periodo.Text));



                conectar.Open();//abre a conexão

                //executar o comando sql
                comando.ExecuteNonQuery();


                MessageBox.Show("Aluno Cadastrado!");
                txt_codigo.Clear();
                txt_nome.Clear();
                txt_curso.Clear();
                txt_periodo.Clear();



                conectar.Close();//fecha a conexão
            }
            catch (SqlException resp) //SqlException resp = cria variavel p/ retornar o erro encontrado na conexao
            {
                MessageBox.Show("Acesso negado! Erro:" + resp);
            }

            Matricula novo = new Matricula();
            novo.Show();
            this.Hide();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Menu novo = new Menu();
            novo.Show();
            this.Hide();
        }

        private void Matricula_Load(object sender, EventArgs e)
        {

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpar3_Click(object sender, EventArgs e)
        {
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_curso.Clear();
            txt_periodo.Clear();
            txt_codigo.Focus();
        }
    }
}
