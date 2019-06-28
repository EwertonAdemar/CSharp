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
    public partial class Alunos : Form
    {
        string acesso = @"Data Source=FERNANDO\SQLEXPRESS;Initial Catalog=bd_cursos;Integrated Security=True";
        public Alunos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
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
                comando.Parameters.Add(new SqlParameter("@id_aluno", txt_codigo1.Text));
                comando.Parameters.Add(new SqlParameter("@nm_aluno", txt_nome1.Text));
                comando.Parameters.Add(new SqlParameter("@id_curso", txt_curso1.Text));
                comando.Parameters.Add(new SqlParameter("@id_periodo", txt_periodo1.Text));



                conectar.Open();//abre a conexão

                //executar o comando sql
                comando.ExecuteNonQuery();


                MessageBox.Show("Aluno Cadastrado!");
                txt_codigo1.Clear();
                txt_nome1.Clear();
                txt_curso1.Clear();
                txt_periodo1.Clear();



                conectar.Close();//fecha a conexão
            }
            catch (SqlException resp) //SqlException resp = cria variavel p/ retornar o erro encontrado na conexao
            {
                MessageBox.Show("Acesso negado! Erro:" + resp);
            }

            Alunos novo = new Alunos();
            novo.Show();
            this.Hide();
        }

        private void Alunos_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar1_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection(acesso);

            //string com instrução sql
            // SELECIONE NA TABELA CARROS O idChassi IGUAL AO textbox
            // o código só acaba quando as aspas duplas são colocadas, dica
            string pesquisar = "SELECT * FROM tb_aluno WHERE id_aluno = '" + txt_codigo1.Text + "' ";
            try
            {

                conectar.Open();
                SqlCommand cmd = new SqlCommand(pesquisar, conectar);

                //leitura dos registros SqlDataReader
                SqlDataReader ler = cmd.ExecuteReader();

                //se econtrar o registro exibe
                if (ler.Read() == true)
                {
                    txt_codigo1.Text = ler["id_aluno"].ToString();
                    txt_nome1.Text = ler["nm_aluno"].ToString();
                    txt_curso1.Text = ler["id_curso"].ToString();
                    txt_periodo1.Text = ler["id_periodo"].ToString();
                }

                conectar.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Acesso negado! " + erro);
            }
        }

        private void btn_excluir1_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection(acesso);
            try
            {
                conectar.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM tb_aluno WHERE id_aluno = @id_aluno", conectar);

                cmd.Parameters.AddWithValue("@id_aluno", txt_codigo1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro do aluno excluido com sucesso");
                conectar.Close();


            }
            catch (SqlException erro)
            {
                MessageBox.Show("Acesso Negado! " + erro);
            }
        }

        private void btn_limpar1_Click(object sender, EventArgs e)
        {
            txt_codigo1.Clear();
            txt_nome1.Clear();
            txt_curso1.Clear();
            txt_periodo1.Clear();

            txt_codigo1.Focus();
        }

        private void btn_voltar1_Click(object sender, EventArgs e)
        {
            Menu novo = new Menu();
            novo.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
