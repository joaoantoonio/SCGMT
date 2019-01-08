namespace Projeto3Camadas
{
    partial class Frm_Usuário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuário));
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_Entrar_Login = new System.Windows.Forms.Button();
            this.btn_Sair_Login = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_nome_tela = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(13, 78);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(57, 15);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuário";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(13, 122);
            this.lbl_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(45, 15);
            this.lbl_senha.TabIndex = 2;
            this.lbl_senha.Text = "Senha";
            // 
            // btn_Entrar_Login
            // 
            this.btn_Entrar_Login.BackColor = System.Drawing.Color.White;
            this.btn_Entrar_Login.Location = new System.Drawing.Point(13, 169);
            this.btn_Entrar_Login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Entrar_Login.Name = "btn_Entrar_Login";
            this.btn_Entrar_Login.Size = new System.Drawing.Size(101, 25);
            this.btn_Entrar_Login.TabIndex = 4;
            this.btn_Entrar_Login.Text = "Entrar";
            this.btn_Entrar_Login.UseVisualStyleBackColor = false;
            this.btn_Entrar_Login.Click += new System.EventHandler(this.btn_Entrar_Login_Click);
            // 
            // btn_Sair_Login
            // 
            this.btn_Sair_Login.BackColor = System.Drawing.Color.White;
            this.btn_Sair_Login.Location = new System.Drawing.Point(186, 169);
            this.btn_Sair_Login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sair_Login.Name = "btn_Sair_Login";
            this.btn_Sair_Login.Size = new System.Drawing.Size(101, 25);
            this.btn_Sair_Login.TabIndex = 5;
            this.btn_Sair_Login.Text = "Sair";
            this.btn_Sair_Login.UseVisualStyleBackColor = false;
            this.btn_Sair_Login.Click += new System.EventHandler(this.btn_Sair_Login_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.White;
            this.txt_usuario.Location = new System.Drawing.Point(13, 96);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_usuario.MaxLength = 8;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(274, 23);
            this.txt_usuario.TabIndex = 1;
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.Color.White;
            this.txt_senha.Location = new System.Drawing.Point(13, 140);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_senha.MaxLength = 8;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(274, 23);
            this.txt_senha.TabIndex = 3;
            // 
            // lbl_nome_tela
            // 
            this.lbl_nome_tela.AutoSize = true;
            this.lbl_nome_tela.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_tela.Location = new System.Drawing.Point(122, 12);
            this.lbl_nome_tela.Name = "lbl_nome_tela";
            this.lbl_nome_tela.Size = new System.Drawing.Size(165, 23);
            this.lbl_nome_tela.TabIndex = 6;
            this.lbl_nome_tela.Text = "Acessar Sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Usuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(301, 218);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_nome_tela);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_Sair_Login);
            this.Controls.Add(this.btn_Entrar_Login);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_Usuário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCGMT";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_Entrar_Login;
        private System.Windows.Forms.Button btn_Sair_Login;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_nome_tela;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}