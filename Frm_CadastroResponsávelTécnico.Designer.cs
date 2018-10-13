namespace Projeto3Camadas
{
    partial class Frm_CadastroResponsávelTécnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroResponsávelTécnico));
            this.lbl_id_resp_tecnico = new System.Windows.Forms.Label();
            this.txt_id_resp_tecnico = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.Grid_ResponsáveisTécnicos = new System.Windows.Forms.DataGridView();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_nome_tela = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_data_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_pesquisa_nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ResponsáveisTécnicos)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id_resp_tecnico
            // 
            this.lbl_id_resp_tecnico.AutoSize = true;
            this.lbl_id_resp_tecnico.Location = new System.Drawing.Point(124, 43);
            this.lbl_id_resp_tecnico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_resp_tecnico.Name = "lbl_id_resp_tecnico";
            this.lbl_id_resp_tecnico.Size = new System.Drawing.Size(27, 15);
            this.lbl_id_resp_tecnico.TabIndex = 1;
            this.lbl_id_resp_tecnico.Text = "ID:";
            this.lbl_id_resp_tecnico.Visible = false;
            // 
            // txt_id_resp_tecnico
            // 
            this.txt_id_resp_tecnico.BackColor = System.Drawing.Color.White;
            this.txt_id_resp_tecnico.Location = new System.Drawing.Point(159, 35);
            this.txt_id_resp_tecnico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_id_resp_tecnico.Name = "txt_id_resp_tecnico";
            this.txt_id_resp_tecnico.ReadOnly = true;
            this.txt_id_resp_tecnico.Size = new System.Drawing.Size(163, 23);
            this.txt_id_resp_tecnico.TabIndex = 2;
            this.txt_id_resp_tecnico.Visible = false;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(17, 61);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 15);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.White;
            this.txt_nome.Location = new System.Drawing.Point(17, 81);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nome.MaxLength = 255;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(305, 23);
            this.txt_nome.TabIndex = 4;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(17, 107);
            this.lbl_cpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(39, 15);
            this.lbl_cpf.TabIndex = 5;
            this.lbl_cpf.Text = "CPF:";
            // 
            // txt_cpf
            // 
            this.txt_cpf.BackColor = System.Drawing.Color.White;
            this.txt_cpf.Location = new System.Drawing.Point(17, 127);
            this.txt_cpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_cpf.MaxLength = 14;
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(305, 23);
            this.txt_cpf.TabIndex = 6;
            this.txt_cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cpf_KeyPress);
            this.txt_cpf.Leave += new System.EventHandler(this.txt_cpf_Leave);
            // 
            // Grid_ResponsáveisTécnicos
            // 
            this.Grid_ResponsáveisTécnicos.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.Grid_ResponsáveisTécnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ResponsáveisTécnicos.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Grid_ResponsáveisTécnicos.Location = new System.Drawing.Point(17, 156);
            this.Grid_ResponsáveisTécnicos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Grid_ResponsáveisTécnicos.Name = "Grid_ResponsáveisTécnicos";
            this.Grid_ResponsáveisTécnicos.ReadOnly = true;
            this.Grid_ResponsáveisTécnicos.Size = new System.Drawing.Size(1336, 581);
            this.Grid_ResponsáveisTécnicos.TabIndex = 13;
            this.Grid_ResponsáveisTécnicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_ResponsáveisTécnicos_CellContentClick);
            // 
            // btn_Novo
            // 
            this.btn_Novo.BackColor = System.Drawing.Color.White;
            this.btn_Novo.Location = new System.Drawing.Point(1048, 81);
            this.btn_Novo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(98, 27);
            this.btn_Novo.TabIndex = 7;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = false;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.White;
            this.btn_Inserir.Location = new System.Drawing.Point(1154, 81);
            this.btn_Inserir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(91, 27);
            this.btn_Inserir.TabIndex = 8;
            this.btn_Inserir.Text = "Gravar";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(1253, 81);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(100, 27);
            this.btn_Sair.TabIndex = 9;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_nome_tela
            // 
            this.lbl_nome_tela.AutoSize = true;
            this.lbl_nome_tela.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_tela.Location = new System.Drawing.Point(123, 8);
            this.lbl_nome_tela.Name = "lbl_nome_tela";
            this.lbl_nome_tela.Size = new System.Drawing.Size(302, 23);
            this.lbl_nome_tela.TabIndex = 0;
            this.lbl_nome_tela.Text = "Cadastro Responsável Técnico";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 718);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 31);
            this.panel1.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_data_hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 7);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 24);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_data_hora
            // 
            this.lbl_data_hora.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_hora.Name = "lbl_data_hora";
            this.lbl_data_hora.Size = new System.Drawing.Size(178, 19);
            this.lbl_data_hora.Text = "toolStripStatusLabel1";
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.BackColor = System.Drawing.Color.White;
            this.txt_pesquisar.Location = new System.Drawing.Point(1048, 127);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(259, 23);
            this.txt_pesquisar.TabIndex = 11;
            this.txt_pesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pesquisar_KeyPress);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackColor = System.Drawing.Color.White;
            this.btn_Pesquisar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Pesquisar.Image = global::Projeto3Camadas.Properties.Resources.seo_social_web_network_internet_340_icon_icons1;
            this.btn_Pesquisar.Location = new System.Drawing.Point(1311, 107);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(42, 45);
            this.btn_Pesquisar.TabIndex = 12;
            this.btn_Pesquisar.UseVisualStyleBackColor = false;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_pesquisa_nome
            // 
            this.lbl_pesquisa_nome.AutoSize = true;
            this.lbl_pesquisa_nome.Location = new System.Drawing.Point(1049, 109);
            this.lbl_pesquisa_nome.Name = "lbl_pesquisa_nome";
            this.lbl_pesquisa_nome.Size = new System.Drawing.Size(256, 15);
            this.lbl_pesquisa_nome.TabIndex = 10;
            this.lbl_pesquisa_nome.Text = "Pesquisar Nome Responsável  Técnico:";
            // 
            // Frm_CadastroResponsávelTécnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lbl_pesquisa_nome);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_nome_tela);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.Grid_ResponsáveisTécnicos);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_id_resp_tecnico);
            this.Controls.Add(this.lbl_id_resp_tecnico);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_CadastroResponsávelTécnico";
            this.Text = "SCGMT - Sistema de Controle e Gerenciamento das  Manutenções em Tratores Agrícola" +
    "s";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadastro_ResponsávelTécnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ResponsáveisTécnicos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id_resp_tecnico;
        private System.Windows.Forms.TextBox txt_id_resp_tecnico;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.DataGridView Grid_ResponsáveisTécnicos;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_nome_tela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_data_hora;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Label lbl_pesquisa_nome;
    }
}