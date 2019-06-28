namespace NewGame
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label7 = new System.Windows.Forms.Label();
            this.tb_cadastro = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(391, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 45);
            this.label7.TabIndex = 56;
            this.label7.Text = "LOGIN";
            // 
            // tb_cadastro
            // 
            this.tb_cadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_cadastro.BackColor = System.Drawing.Color.Silver;
            this.tb_cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_cadastro.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.tb_cadastro.FlatAppearance.BorderSize = 0;
            this.tb_cadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.tb_cadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.tb_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tb_cadastro.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_cadastro.ForeColor = System.Drawing.Color.Black;
            this.tb_cadastro.Location = new System.Drawing.Point(370, 228);
            this.tb_cadastro.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cadastro.Name = "tb_cadastro";
            this.tb_cadastro.Size = new System.Drawing.Size(232, 38);
            this.tb_cadastro.TabIndex = 64;
            this.tb_cadastro.Text = "Cadastre - se";
            this.tb_cadastro.UseVisualStyleBackColor = false;
            this.tb_cadastro.Click += new System.EventHandler(this.tb_cadastro_Click_1);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 10F);
            this.lblMensagem.ForeColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Location = new System.Drawing.Point(396, 169);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 16);
            this.lblMensagem.TabIndex = 63;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.Silver;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(370, 182);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 38);
            this.btnSair.TabIndex = 62;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(370, 135);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(232, 20);
            this.txt_senha.TabIndex = 61;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(370, 103);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(232, 20);
            this.txt_login.TabIndex = 60;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSenha.ForeColor = System.Drawing.Color.Transparent;
            this.lblSenha.Location = new System.Drawing.Point(298, 137);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(61, 18);
            this.lblSenha.TabIndex = 59;
            this.lblSenha.Text = "Senha :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 12F);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogin.Location = new System.Drawing.Point(298, 105);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 18);
            this.lblLogin.TabIndex = 58;
            this.lblLogin.Text = "Login :";
            // 
            // btn_entrar
            // 
            this.btn_entrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_entrar.BackColor = System.Drawing.Color.Silver;
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_entrar.FlatAppearance.BorderSize = 0;
            this.btn_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_entrar.ForeColor = System.Drawing.Color.Black;
            this.btn_entrar.Location = new System.Drawing.Point(490, 182);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_entrar.Size = new System.Drawing.Size(112, 38);
            this.btn_entrar.TabIndex = 57;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_cadastro);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button tb_cadastro;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}