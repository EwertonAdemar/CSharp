namespace Atividade
{
    partial class Relatório
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_cursos = new System.Windows.Forms.DataGridView();
            this.bd_cursosDataSet = new Atividade.bd_cursosDataSet();
            this.tbalunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_alunoTableAdapter = new Atividade.bd_cursosDataSetTableAdapters.tb_alunoTableAdapter();
            this.idalunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmalunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idperiodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_voltar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_cursosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbalunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cursos
            // 
            this.dgv_cursos.AutoGenerateColumns = false;
            this.dgv_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalunoDataGridViewTextBoxColumn,
            this.nmalunoDataGridViewTextBoxColumn,
            this.idcursoDataGridViewTextBoxColumn,
            this.idperiodoDataGridViewTextBoxColumn});
            this.dgv_cursos.DataSource = this.tbalunoBindingSource;
            this.dgv_cursos.Location = new System.Drawing.Point(12, 12);
            this.dgv_cursos.Name = "dgv_cursos";
            this.dgv_cursos.Size = new System.Drawing.Size(444, 259);
            this.dgv_cursos.TabIndex = 1;
            this.dgv_cursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cursos_CellContentClick);
            // 
            // bd_cursosDataSet
            // 
            this.bd_cursosDataSet.DataSetName = "bd_cursosDataSet";
            this.bd_cursosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbalunoBindingSource
            // 
            this.tbalunoBindingSource.DataMember = "tb_aluno";
            this.tbalunoBindingSource.DataSource = this.bd_cursosDataSet;
            // 
            // tb_alunoTableAdapter
            // 
            this.tb_alunoTableAdapter.ClearBeforeFill = true;
            // 
            // idalunoDataGridViewTextBoxColumn
            // 
            this.idalunoDataGridViewTextBoxColumn.DataPropertyName = "id_aluno";
            this.idalunoDataGridViewTextBoxColumn.HeaderText = "id_aluno";
            this.idalunoDataGridViewTextBoxColumn.Name = "idalunoDataGridViewTextBoxColumn";
            // 
            // nmalunoDataGridViewTextBoxColumn
            // 
            this.nmalunoDataGridViewTextBoxColumn.DataPropertyName = "nm_aluno";
            this.nmalunoDataGridViewTextBoxColumn.HeaderText = "nm_aluno";
            this.nmalunoDataGridViewTextBoxColumn.Name = "nmalunoDataGridViewTextBoxColumn";
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            // 
            // idperiodoDataGridViewTextBoxColumn
            // 
            this.idperiodoDataGridViewTextBoxColumn.DataPropertyName = "id_periodo";
            this.idperiodoDataGridViewTextBoxColumn.HeaderText = "id_periodo";
            this.idperiodoDataGridViewTextBoxColumn.Name = "idperiodoDataGridViewTextBoxColumn";
            // 
            // btn_voltar2
            // 
            this.btn_voltar2.Location = new System.Drawing.Point(12, 277);
            this.btn_voltar2.Name = "btn_voltar2";
            this.btn_voltar2.Size = new System.Drawing.Size(444, 27);
            this.btn_voltar2.TabIndex = 0;
            this.btn_voltar2.Text = "Voltar";
            this.btn_voltar2.UseVisualStyleBackColor = true;
            this.btn_voltar2.Click += new System.EventHandler(this.btn_voltar2_Click);
            // 
            // Relatório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(475, 324);
            this.Controls.Add(this.btn_voltar2);
            this.Controls.Add(this.dgv_cursos);
            this.Name = "Relatório";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_cursosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbalunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cursos;
        private bd_cursosDataSet bd_cursosDataSet;
        private System.Windows.Forms.BindingSource tbalunoBindingSource;
        private bd_cursosDataSetTableAdapters.tb_alunoTableAdapter tb_alunoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmalunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idperiodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_voltar2;
    }
}