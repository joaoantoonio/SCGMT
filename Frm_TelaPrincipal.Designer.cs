namespace Projeto3Camadas
{
    partial class Frm_TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TelaPrincipal));
            this.Grid_Tela_Principal = new System.Windows.Forms.DataGridView();
            this.btn_Cadastrar_Proprietário = new System.Windows.Forms.Button();
            this.btn_Cadastrar_Equipamento = new System.Windows.Forms.Button();
            this.btn_Relatórios = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Cadastrar_ResponsávelTécnico = new System.Windows.Forms.Button();
            this.lbl_nome_tela = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_data_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Próxima_Manutenção = new System.Windows.Forms.Button();
            this.lbl_pesquisa_monobloco = new System.Windows.Forms.Label();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Tela_Principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_Tela_Principal
            // 
            this.Grid_Tela_Principal.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.Grid_Tela_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Tela_Principal.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Grid_Tela_Principal.Location = new System.Drawing.Point(13, 68);
            this.Grid_Tela_Principal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Grid_Tela_Principal.Name = "Grid_Tela_Principal";
            this.Grid_Tela_Principal.ReadOnly = true;
            this.Grid_Tela_Principal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Tela_Principal.Size = new System.Drawing.Size(1341, 561);
            this.Grid_Tela_Principal.TabIndex = 10;
            // 
            // btn_Cadastrar_Proprietário
            // 
            this.btn_Cadastrar_Proprietário.BackColor = System.Drawing.Color.White;
            this.btn_Cadastrar_Proprietário.Location = new System.Drawing.Point(13, 635);
            this.btn_Cadastrar_Proprietário.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Cadastrar_Proprietário.Name = "btn_Cadastrar_Proprietário";
            this.btn_Cadastrar_Proprietário.Size = new System.Drawing.Size(251, 25);
            this.btn_Cadastrar_Proprietário.TabIndex = 1;
            this.btn_Cadastrar_Proprietário.Text = "Cadastrar Proprietário";
            this.btn_Cadastrar_Proprietário.UseVisualStyleBackColor = false;
            this.btn_Cadastrar_Proprietário.Click += new System.EventHandler(this.btn_Cadastrar_Proprietário_Click);
            // 
            // btn_Cadastrar_Equipamento
            // 
            this.btn_Cadastrar_Equipamento.BackColor = System.Drawing.Color.White;
            this.btn_Cadastrar_Equipamento.Location = new System.Drawing.Point(272, 635);
            this.btn_Cadastrar_Equipamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Cadastrar_Equipamento.Name = "btn_Cadastrar_Equipamento";
            this.btn_Cadastrar_Equipamento.Size = new System.Drawing.Size(225, 25);
            this.btn_Cadastrar_Equipamento.TabIndex = 2;
            this.btn_Cadastrar_Equipamento.Text = "Cadastrar Equipamento";
            this.btn_Cadastrar_Equipamento.UseVisualStyleBackColor = false;
            this.btn_Cadastrar_Equipamento.Click += new System.EventHandler(this.btn_Cadastrar_Equipamento_Click);
            // 
            // btn_Relatórios
            // 
            this.btn_Relatórios.BackColor = System.Drawing.Color.White;
            this.btn_Relatórios.Location = new System.Drawing.Point(738, 635);
            this.btn_Relatórios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Relatórios.Name = "btn_Relatórios";
            this.btn_Relatórios.Size = new System.Drawing.Size(200, 25);
            this.btn_Relatórios.TabIndex = 4;
            this.btn_Relatórios.Text = "Relatórios";
            this.btn_Relatórios.UseVisualStyleBackColor = false;
            this.btn_Relatórios.Click += new System.EventHandler(this.btn_Relatórios_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(1180, 635);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(174, 25);
            this.btn_Sair.TabIndex = 6;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Cadastrar_ResponsávelTécnico
            // 
            this.btn_Cadastrar_ResponsávelTécnico.BackColor = System.Drawing.Color.White;
            this.btn_Cadastrar_ResponsávelTécnico.Location = new System.Drawing.Point(505, 635);
            this.btn_Cadastrar_ResponsávelTécnico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Cadastrar_ResponsávelTécnico.Name = "btn_Cadastrar_ResponsávelTécnico";
            this.btn_Cadastrar_ResponsávelTécnico.Size = new System.Drawing.Size(225, 25);
            this.btn_Cadastrar_ResponsávelTécnico.TabIndex = 3;
            this.btn_Cadastrar_ResponsávelTécnico.Text = "Cadastrar Responsável Técnico";
            this.btn_Cadastrar_ResponsávelTécnico.UseVisualStyleBackColor = false;
            this.btn_Cadastrar_ResponsávelTécnico.Click += new System.EventHandler(this.btn_Cadastrar_ResponsávelTécnico_Click);
            // 
            // lbl_nome_tela
            // 
            this.lbl_nome_tela.AutoSize = true;
            this.lbl_nome_tela.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_tela.Location = new System.Drawing.Point(119, 12);
            this.lbl_nome_tela.Name = "lbl_nome_tela";
            this.lbl_nome_tela.Size = new System.Drawing.Size(146, 23);
            this.lbl_nome_tela.TabIndex = 0;
            this.lbl_nome_tela.Text = "Tela Principal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            this.panel1.Location = new System.Drawing.Point(0, 710);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 39);
            this.panel1.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_data_hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 15);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 24);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_data_hora
            // 
            this.lbl_data_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_data_hora.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_hora.Name = "lbl_data_hora";
            this.lbl_data_hora.Size = new System.Drawing.Size(178, 19);
            this.lbl_data_hora.Text = "toolStripStatusLabel1";
            // 
            // btn_Próxima_Manutenção
            // 
            this.btn_Próxima_Manutenção.BackColor = System.Drawing.Color.White;
            this.btn_Próxima_Manutenção.Location = new System.Drawing.Point(945, 635);
            this.btn_Próxima_Manutenção.Name = "btn_Próxima_Manutenção";
            this.btn_Próxima_Manutenção.Size = new System.Drawing.Size(228, 25);
            this.btn_Próxima_Manutenção.TabIndex = 5;
            this.btn_Próxima_Manutenção.Text = "Próxima Manutenção";
            this.btn_Próxima_Manutenção.UseVisualStyleBackColor = false;
            this.btn_Próxima_Manutenção.Click += new System.EventHandler(this.btn_Próxima_Manutenção_Click);
            // 
            // lbl_pesquisa_monobloco
            // 
            this.lbl_pesquisa_monobloco.AutoSize = true;
            this.lbl_pesquisa_monobloco.Location = new System.Drawing.Point(12, 670);
            this.lbl_pesquisa_monobloco.Name = "lbl_pesquisa_monobloco";
            this.lbl_pesquisa_monobloco.Size = new System.Drawing.Size(257, 15);
            this.lbl_pesquisa_monobloco.TabIndex = 7;
            this.lbl_pesquisa_monobloco.Text = "Pesquisar Monobloco do Equipamento:";
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.BackColor = System.Drawing.Color.White;
            this.txt_pesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pesquisar.Location = new System.Drawing.Point(15, 688);
            this.txt_pesquisar.MaxLength = 15;
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(296, 23);
            this.txt_pesquisar.TabIndex = 8;
            this.txt_pesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pesquisar_KeyPress);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackColor = System.Drawing.Color.White;
            this.btn_Pesquisar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Pesquisar.Image = global::Projeto3Camadas.Properties.Resources.seo_social_web_network_internet_340_icon_icons1;
            this.btn_Pesquisar.Location = new System.Drawing.Point(317, 668);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(42, 45);
            this.btn_Pesquisar.TabIndex = 9;
            this.btn_Pesquisar.UseVisualStyleBackColor = false;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // Frm_TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.lbl_pesquisa_monobloco);
            this.Controls.Add(this.btn_Próxima_Manutenção);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_nome_tela);
            this.Controls.Add(this.btn_Cadastrar_ResponsávelTécnico);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Relatórios);
            this.Controls.Add(this.btn_Cadastrar_Equipamento);
            this.Controls.Add(this.btn_Cadastrar_Proprietário);
            this.Controls.Add(this.Grid_Tela_Principal);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_TelaPrincipal";
            this.Text = "SCGMT - Sistema de Controle e Gerenciamento das Manutenções em Tratores Agrícolas" +
    "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Frm_TelaPrincipal_Activated);
            this.Load += new System.EventHandler(this.FrmTela_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Tela_Principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Tela_Principal;
        private System.Windows.Forms.Button btn_Cadastrar_Proprietário;
        private System.Windows.Forms.Button btn_Cadastrar_Equipamento;
        private System.Windows.Forms.Button btn_Relatórios;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Cadastrar_ResponsávelTécnico;
        private System.Windows.Forms.Label lbl_nome_tela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_data_hora;
        private System.Windows.Forms.Button btn_Próxima_Manutenção;
        private System.Windows.Forms.Label lbl_pesquisa_monobloco;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Button btn_Pesquisar;
    }
}