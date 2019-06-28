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
    public partial class Relatório : Form
    {
        public Relatório()
        {
            InitializeComponent();
        }

        private void frmAtividade_Load(object sender, EventArgs e)
        {

            string strConectar = @"Data Source=FERNANDO\SQLEXPRESS;Initial Catalog=bd_cursos;Integrated Security=True";

            string strSelect = "SELECT tb_aluno.id_aluno, tb_aluno.nm_aluno, tb_curso.nm_curso, tb_periodos.nm_periodo FROM tb_aluno INNER JOIN tb_curso ON tb_aluno.id_curso = tb_curso.id_curso INNER JOIN tb_periodos ON tb_aluno.id_periodo = tb_periodos.id_periodo";

            SqlConnection conectar = new SqlConnection(strConectar);

            try
            {
                SqlCommand cmd = new SqlCommand(strSelect, conectar);

                conectar.Open();

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgv_cursos.DataSource = dt;

                cmd.ExecuteNonQuery();

                conectar.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Acesso Negado, erro:" + ex);
            }


        }

        private void dgv_cursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_cursosDataSet.tb_aluno' table. You can move, or remove it, as needed.
            this.tb_alunoTableAdapter.Fill(this.bd_cursosDataSet.tb_aluno);

        }

        private void btn_voltar2_Click(object sender, EventArgs e)
        {
            Menu novo = new Menu();
            novo.Show();
            this.Hide();
        }
    }
}
