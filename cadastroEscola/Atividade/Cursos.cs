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
    public partial class Cursos : Form
    {
        string acesso = @"Data Source=FERNANDO\SQLEXPRESS;Initial Catalog=bd_cursos;Integrated Security=True";
        public Cursos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_curso1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_voltar1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar2_Click(object sender, EventArgs e)
        {
            // O @ no inicio do endereço da string de conexao ondica que o endereço é um parametro de conexao:
            String strConexao = @"Data Source=FERNANDO\SQLEXPRESS;Initial Catalog=bd_cursos;Integrated Security=True";
            // string de instrução ao comando
            string sql = "INSERT INTO tb_curso(id_curso, nm_curso) VALUES ( @id_curso, @nm_curso)";


            //instancia o objeto de conexao
            SqlConnection conectar = new SqlConnection(strConexao);


            try
            {
                // objeto que permite a interação com o sql:
                SqlCommand comando = new SqlCommand(sql, conectar);// sql = Chama string da função e conectar = chama a conexão ao banco

                // atribuir os dados aos parametros:
                comando.Parameters.Add(new SqlParameter("@id_curso", txt_codigo2.Text));
                comando.Parameters.Add(new SqlParameter("@nm_curso", txt_curso2.Text));
                



                conectar.Open();//abre a conexão

                //executar o comando sql
                comando.ExecuteNonQuery();


                MessageBox.Show("Curso Cadastrado!");
                txt_codigo2.Clear();
                txt_curso2.Clear();
                



                conectar.Close();//fecha a conexão
            }
            catch (SqlException resp) //SqlException resp = cria variavel p/ retornar o erro encontrado na conexao
            {
                MessageBox.Show("Acesso negado! Erro:" + resp);

            }

            Cursos novo = new Cursos();
            novo.Show();
            this.Hide();
        }

        private void btn_pesquisar2_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection(acesso);

            //string com instrução sql
            // SELECIONE NA TABELA CARROS O idChassi IGUAL AO textbox
            // o código só acaba quando as aspas duplas são colocadas, dica
            string pesquisar = "SELECT * FROM tb_curso WHERE id_curso = '" + txt_codigo2.Text + "' ";
            try
            {

                conectar.Open();
                SqlCommand cmd = new SqlCommand(pesquisar, conectar);

                //leitura dos registros SqlDataReader
                SqlDataReader ler = cmd.ExecuteReader();

                //se econtrar o registro exibe
                if (ler.Read() == true)
                {
                    txt_codigo2.Text = ler["id_curso"].ToString();
                    txt_curso2.Text = ler["nm_curso"].ToString();
                    
                    
                }

                conectar.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Acesso negado! " + erro);
            }
        }

        private void btn_excluir2_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection(acesso);
            try
            {
                conectar.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM tb_curso WHERE id_curso = @id_curso", conectar);

                cmd.Parameters.AddWithValue("@id_curso", txt_codigo2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro do curso excluido com sucesso");
                conectar.Close();


            }
            catch (SqlException erro)
            {
                MessageBox.Show("Acesso Negado! " + erro);
            }
        }

        private void btn_limpar2_Click(object sender, EventArgs e)
        {
            txt_codigo2.Clear();
            txt_curso2.Clear();
            txt_codigo2.Focus();
        }

        private void btn_voltar2_Click(object sender, EventArgs e)
        {
            Menu novo = new Menu();
            novo.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cursos_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
