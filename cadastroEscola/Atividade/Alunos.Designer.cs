namespace Atividade
{
    partial class Alunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alunos));
            this.txt_codigo1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_periodo1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_voltar1 = new System.Windows.Forms.Button();
            this.btn_cadastrar1 = new System.Windows.Forms.Button();
            this.txt_curso1 = new System.Windows.Forms.TextBox();
            this.txt_nome1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pesquisar1 = new System.Windows.Forms.Button();
            this.btn_excluir1 = new System.Windows.Forms.Button();
            this.btn_limpar1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_codigo1
            // 
            this.txt_codigo1.Location = new System.Drawing.Point(111, 53);
            this.txt_codigo1.Name = "txt_codigo1";
            this.txt_codigo1.Size = new System.Drawing.Size(145, 20);
            this.txt_codigo1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Código:";
            // 
            // txt_periodo1
            // 
            this.txt_periodo1.Location = new System.Drawing.Point(111, 131);
            this.txt_periodo1.Name = "txt_periodo1";
            this.txt_periodo1.Size = new System.Drawing.Size(145, 20);
            this.txt_periodo1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Período:";
            // 
            // btn_voltar1
            // 
            this.btn_voltar1.Location = new System.Drawing.Point(367, 219);
            this.btn_voltar1.Name = "btn_voltar1";
            this.btn_voltar1.Size = new System.Drawing.Size(75, 26);
            this.btn_voltar1.TabIndex = 8;
            this.btn_voltar1.Text = "Voltar";
            this.btn_voltar1.UseVisualStyleBackColor = true;
            this.btn_voltar1.Click += new System.EventHandler(this.btn_voltar1_Click);
            // 
            // btn_cadastrar1
            // 
            this.btn_cadastrar1.Location = new System.Drawing.Point(43, 218);
            this.btn_cadastrar1.Name = "btn_cadastrar1";
            this.btn_cadastrar1.Size = new System.Drawing.Size(75, 26);
            this.btn_cadastrar1.TabIndex = 4;
            this.btn_cadastrar1.Text = "Cadastrar";
            this.btn_cadastrar1.UseVisualStyleBackColor = true;
            this.btn_cadastrar1.Click += new System.EventHandler(this.bt_cadastro_Click);
            // 
            // txt_curso1
            // 
            this.txt_curso1.Location = new System.Drawing.Point(111, 105);
            this.txt_curso1.Name = "txt_curso1";
            this.txt_curso1.Size = new System.Drawing.Size(145, 20);
            this.txt_curso1.TabIndex = 2;
            // 
            // txt_nome1
            // 
            this.txt_nome1.Location = new System.Drawing.Point(111, 79);
            this.txt_nome1.Name = "txt_nome1";
            this.txt_nome1.Size = new System.Drawing.Size(145, 20);
            this.txt_nome1.TabIndex = 1;
            this.txt_nome1.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Curso:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome:";
            // 
            // btn_pesquisar1
            // 
            this.btn_pesquisar1.Location = new System.Drawing.Point(124, 218);
            this.btn_pesquisar1.Name = "btn_pesquisar1";
            this.btn_pesquisar1.Size = new System.Drawing.Size(75, 26);
            this.btn_pesquisar1.TabIndex = 5;
            this.btn_pesquisar1.Text = "Pesquisar";
            this.btn_pesquisar1.UseVisualStyleBackColor = true;
            this.btn_pesquisar1.Click += new System.EventHandler(this.btn_pesquisar1_Click);
            // 
            // btn_excluir1
            // 
            this.btn_excluir1.Location = new System.Drawing.Point(205, 218);
            this.btn_excluir1.Name = "btn_excluir1";
            this.btn_excluir1.Size = new System.Drawing.Size(75, 26);
            this.btn_excluir1.TabIndex = 6;
            this.btn_excluir1.Text = "Excluir";
            this.btn_excluir1.UseVisualStyleBackColor = true;
            this.btn_excluir1.Click += new System.EventHandler(this.btn_excluir1_Click);
            // 
            // btn_limpar1
            // 
            this.btn_limpar1.Location = new System.Drawing.Point(286, 219);
            this.btn_limpar1.Name = "btn_limpar1";
            this.btn_limpar1.Size = new System.Drawing.Size(75, 26);
            this.btn_limpar1.TabIndex = 7;
            this.btn_limpar1.Text = "Limpar";
            this.btn_limpar1.UseVisualStyleBackColor = true;
            this.btn_limpar1.Click += new System.EventHandler(this.btn_limpar1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "as três funções básicas, ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "* Só usa o código para fazer ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "menos o cadastrar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 32);
            this.label9.TabIndex = 59;
            this.label9.Text = "Alunos";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(479, 257);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_limpar1);
            this.Controls.Add(this.btn_excluir1);
            this.Controls.Add(this.btn_pesquisar1);
            this.Controls.Add(this.txt_codigo1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_periodo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_voltar1);
            this.Controls.Add(this.btn_cadastrar1);
            this.Controls.Add(this.txt_curso1);
            this.Controls.Add(this.txt_nome1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Alunos";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codigo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_periodo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_voltar1;
        private System.Windows.Forms.Button btn_cadastrar1;
        private System.Windows.Forms.TextBox txt_curso1;
        private System.Windows.Forms.TextBox txt_nome1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pesquisar1;
        private System.Windows.Forms.Button btn_excluir1;
        private System.Windows.Forms.Button btn_limpar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}