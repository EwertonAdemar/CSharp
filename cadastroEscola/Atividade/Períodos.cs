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

    public partial class Períodos : Form
    {
        string acesso = @"Data Source=FERNANDO\SQLEXPRESS;Initial Catalog=bd_cursos;Integrated Security=True";
        public Períodos()
        {
            
            InitializeComponent();
        }

        private void txt_codigo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar2_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection(acesso);

            //string com instrução sql
    
            // o código só acaba quando as aspas duplas são colocadas, dica
            string pesquisar = "SELECT * FROM tb_periodos WHERE id_periodo = '" + txt_codigo3.Text + "' ";
            try
            {

                conectar.Open();
                SqlCommand cmd = new SqlCommand(pesquisar, conectar);

                //leitura dos registros SqlDataReader
                SqlDataReader ler = cmd.ExecuteReader();

                //se econtrar o registro exibe
                if (ler.Read() == true)
                {
                    txt_codigo3.Text = ler["id_periodo"].ToString();
                    txt_periodo3.Text = ler["nm_periodo"].ToString();
                    
                }

                conectar.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Acesso negado! " + erro);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar3_Click(object sender, EventArgs e)
        {
            // O @ no inicio do endereço da string de conexao ondica que o endereço é um parametro de conexao:
            String strConexao = @"Data Source=FERNANDO\SQLEXPRESS;Initial Catalog=bd_cursos;Integrated Security=True";
            // string de instrução ao comando
            string sql = "INSERT INTO tb_periodos(id_periodo, nm_periodo) VALUES ( @id_periodo, @nm_periodo)";


            //instancia o objeto de conexao
            SqlConnection conectar = new SqlConnection(strConexao);


            try
            {
                // objeto que permite a interação com o sql:
                SqlCommand comando = new SqlCommand(sql, conectar);// sql = Chama string da função e conectar = chama a conexão ao banco

                // atribuir os dados aos parametros:
                comando.Parameters.Add(new SqlParameter("@id_periodo", txt_codigo3.Text));
                comando.Parameters.Add(new SqlParameter("@nm_periodo", txt_periodo3.Text));



                conectar.Open();//abre a conexão

                //executar o comando sql
                comando.ExecuteNonQuery();


                MessageBox.Show("Período Cadastrado!");
                txt_codigo3.Clear();
                txt_periodo3.Clear();

                conectar.Close();//fecha a conexão
            }
            catch (SqlException resp) //SqlException resp = cria variavel p/ retornar o erro encontrado na conexao
            {
                MessageBox.Show("Acesso negado! Erro:" + resp);
            }

            Períodos novo = new Períodos();
            novo.Show();
            this.Hide();
        }

        private void Períodos_Load(object sender, EventArgs e)
        {

        }

        private void btn_excluir3_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection(acesso);
            try
            {
                conectar.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM tb_periodos WHERE id_periodo = @id_periodo", conectar);

                cmd.Parameters.AddWithValue("@id_periodo", txt_codigo3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro do período excluido com sucesso");
                conectar.Close();


            }
            catch (SqlException erro)
            {
                MessageBox.Show("Acesso Negado! " + erro);
            }
        }

        private void btn_voltar3_Click(object sender, EventArgs e)
        {
            Menu novo = new Menu();
            novo.Show();
            this.Hide();
        }

        private void btn_limpar3_Click(object sender, EventArgs e)
        {
            txt_codigo3.Clear();
            txt_periodo3.Clear();

            txt_codigo3.Focus();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
