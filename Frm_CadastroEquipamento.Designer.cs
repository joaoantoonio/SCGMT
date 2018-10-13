using System;

namespace Projeto3Camadas
{
    partial class Frm_CadastroEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroEquipamento));
            this.lbl_monobloco = new System.Windows.Forms.Label();
            this.lbl_motor = new System.Windows.Forms.Label();
            this.lbl_serie = new System.Windows.Forms.Label();
            this.lbl_horimetro = new System.Windows.Forms.Label();
            this.lbl_nf_compra = new System.Windows.Forms.Label();
            this.lbl_NF_Venda = new System.Windows.Forms.Label();
            this.txt_monobloco = new System.Windows.Forms.TextBox();
            this.txt_motor = new System.Windows.Forms.TextBox();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.txt_horimetro = new System.Windows.Forms.TextBox();
            this.txt_nf_compra = new System.Windows.Forms.TextBox();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.Grid_Equipamentos = new System.Windows.Forms.DataGridView();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.lbl_id_equipamento = new System.Windows.Forms.Label();
            this.txt_id_equipamento = new System.Windows.Forms.TextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.cmb_fk_proprietario = new System.Windows.Forms.ComboBox();
            this.lbl_fk_proprietario = new System.Windows.Forms.Label();
            this.lbl_nome_tela = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_data_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_pesquisa_monobloco = new System.Windows.Forms.Label();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Equipamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_monobloco
            // 
            this.lbl_monobloco.AutoSize = true;
            this.lbl_monobloco.Location = new System.Drawing.Point(16, 70);
            this.lbl_monobloco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_monobloco.Name = "lbl_monobloco";
            this.lbl_monobloco.Size = new System.Drawing.Size(82, 15);
            this.lbl_monobloco.TabIndex = 3;
            this.lbl_monobloco.Text = "Monobloco:";
            // 
            // lbl_motor
            // 
            this.lbl_motor.AutoSize = true;
            this.lbl_motor.Location = new System.Drawing.Point(16, 126);
            this.lbl_motor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_motor.Name = "lbl_motor";
            this.lbl_motor.Size = new System.Drawing.Size(51, 15);
            this.lbl_motor.TabIndex = 5;
            this.lbl_motor.Text = "Motor:";
            // 
            // lbl_serie
            // 
            this.lbl_serie.AutoSize = true;
            this.lbl_serie.Location = new System.Drawing.Point(16, 181);
            this.lbl_serie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_serie.Name = "lbl_serie";
            this.lbl_serie.Size = new System.Drawing.Size(44, 15);
            this.lbl_serie.TabIndex = 7;
            this.lbl_serie.Text = "Série:";
            // 
            // lbl_horimetro
            // 
            this.lbl_horimetro.AutoSize = true;
            this.lbl_horimetro.Location = new System.Drawing.Point(16, 234);
            this.lbl_horimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_horimetro.Name = "lbl_horimetro";
            this.lbl_horimetro.Size = new System.Drawing.Size(78, 15);
            this.lbl_horimetro.TabIndex = 9;
            this.lbl_horimetro.Text = "Horímetro:";
            // 
            // lbl_nf_compra
            // 
            this.lbl_nf_compra.AutoSize = true;
            this.lbl_nf_compra.Location = new System.Drawing.Point(16, 286);
            this.lbl_nf_compra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nf_compra.Name = "lbl_nf_compra";
            this.lbl_nf_compra.Size = new System.Drawing.Size(158, 15);
            this.lbl_nf_compra.TabIndex = 11;
            this.lbl_nf_compra.Text = "Nota Fiscal de Compra:";
            this.lbl_nf_compra.Click += new System.EventHandler(this.lbl_NF_Compra_Click);
            // 
            // lbl_NF_Venda
            // 
            this.lbl_NF_Venda.AutoSize = true;
            this.lbl_NF_Venda.Location = new System.Drawing.Point(16, 271);
            this.lbl_NF_Venda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NF_Venda.Name = "lbl_NF_Venda";
            this.lbl_NF_Venda.Size = new System.Drawing.Size(0, 15);
            this.lbl_NF_Venda.TabIndex = 5;
            // 
            // txt_monobloco
            // 
            this.txt_monobloco.BackColor = System.Drawing.Color.White;
            this.txt_monobloco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_monobloco.Location = new System.Drawing.Point(19, 88);
            this.txt_monobloco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_monobloco.MaxLength = 15;
            this.txt_monobloco.Name = "txt_monobloco";
            this.txt_monobloco.Size = new System.Drawing.Size(304, 23);
            this.txt_monobloco.TabIndex = 4;
            this.txt_monobloco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monobloco_KeyPress);
            this.txt_monobloco.Leave += new System.EventHandler(this.txt_monobloco_Leave);
            // 
            // txt_motor
            // 
            this.txt_motor.BackColor = System.Drawing.Color.White;
            this.txt_motor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_motor.Location = new System.Drawing.Point(19, 144);
            this.txt_motor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_motor.MaxLength = 8;
            this.txt_motor.Name = "txt_motor";
            this.txt_motor.Size = new System.Drawing.Size(304, 23);
            this.txt_motor.TabIndex = 6;
            this.txt_motor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_motor_KeyPress);
            this.txt_motor.Leave += new System.EventHandler(this.txt_motor_Leave);
            // 
            // txt_serie
            // 
            this.txt_serie.BackColor = System.Drawing.Color.White;
            this.txt_serie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_serie.Location = new System.Drawing.Point(19, 199);
            this.txt_serie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_serie.MaxLength = 10;
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(304, 23);
            this.txt_serie.TabIndex = 8;
            this.txt_serie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_serie_KeyPress);
            this.txt_serie.Leave += new System.EventHandler(this.txt_serie_Leave);
            // 
            // txt_horimetro
            // 
            this.txt_horimetro.BackColor = System.Drawing.Color.White;
            this.txt_horimetro.Location = new System.Drawing.Point(19, 252);
            this.txt_horimetro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_horimetro.MaxLength = 4;
            this.txt_horimetro.Name = "txt_horimetro";
            this.txt_horimetro.Size = new System.Drawing.Size(304, 23);
            this.txt_horimetro.TabIndex = 10;
            this.txt_horimetro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_horimetro_KeyPress);
            // 
            // txt_nf_compra
            // 
            this.txt_nf_compra.BackColor = System.Drawing.Color.White;
            this.txt_nf_compra.Location = new System.Drawing.Point(19, 304);
            this.txt_nf_compra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nf_compra.MaxLength = 6;
            this.txt_nf_compra.Name = "txt_nf_compra";
            this.txt_nf_compra.Size = new System.Drawing.Size(304, 23);
            this.txt_nf_compra.TabIndex = 12;
            this.txt_nf_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nf_compra_KeyPress);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.White;
            this.btn_Inserir.Location = new System.Drawing.Point(1039, 86);
            this.btn_Inserir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(100, 25);
            this.btn_Inserir.TabIndex = 16;
            this.btn_Inserir.Text = "Gravar";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // Grid_Equipamentos
            // 
            this.Grid_Equipamentos.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.Grid_Equipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Equipamentos.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Grid_Equipamentos.Location = new System.Drawing.Point(19, 386);
            this.Grid_Equipamentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Grid_Equipamentos.Name = "Grid_Equipamentos";
            this.Grid_Equipamentos.ReadOnly = true;
            this.Grid_Equipamentos.Size = new System.Drawing.Size(1336, 353);
            this.Grid_Equipamentos.TabIndex = 22;
            this.Grid_Equipamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Equipamentos_CellContentClick);
            // 
            // btn_Novo
            // 
            this.btn_Novo.BackColor = System.Drawing.Color.White;
            this.btn_Novo.Location = new System.Drawing.Point(931, 86);
            this.btn_Novo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(100, 25);
            this.btn_Novo.TabIndex = 15;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = false;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.White;
            this.btn_Excluir.Location = new System.Drawing.Point(1147, 86);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(100, 25);
            this.btn_Excluir.TabIndex = 17;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // lbl_id_equipamento
            // 
            this.lbl_id_equipamento.AutoSize = true;
            this.lbl_id_equipamento.Location = new System.Drawing.Point(126, 44);
            this.lbl_id_equipamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_equipamento.Name = "lbl_id_equipamento";
            this.lbl_id_equipamento.Size = new System.Drawing.Size(27, 15);
            this.lbl_id_equipamento.TabIndex = 1;
            this.lbl_id_equipamento.Text = "ID:";
            this.lbl_id_equipamento.Visible = false;
            // 
            // txt_id_equipamento
            // 
            this.txt_id_equipamento.BackColor = System.Drawing.Color.White;
            this.txt_id_equipamento.Location = new System.Drawing.Point(153, 36);
            this.txt_id_equipamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_id_equipamento.Name = "txt_id_equipamento";
            this.txt_id_equipamento.ReadOnly = true;
            this.txt_id_equipamento.Size = new System.Drawing.Size(67, 23);
            this.txt_id_equipamento.TabIndex = 2;
            this.txt_id_equipamento.Visible = false;
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(1255, 86);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(100, 25);
            this.btn_Sair.TabIndex = 18;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // cmb_fk_proprietario
            // 
            this.cmb_fk_proprietario.BackColor = System.Drawing.Color.White;
            this.cmb_fk_proprietario.FormattingEnabled = true;
            this.cmb_fk_proprietario.Location = new System.Drawing.Point(19, 357);
            this.cmb_fk_proprietario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_fk_proprietario.Name = "cmb_fk_proprietario";
            this.cmb_fk_proprietario.Size = new System.Drawing.Size(304, 23);
            this.cmb_fk_proprietario.TabIndex = 14;
            // 
            // lbl_fk_proprietario
            // 
            this.lbl_fk_proprietario.AutoSize = true;
            this.lbl_fk_proprietario.Location = new System.Drawing.Point(16, 339);
            this.lbl_fk_proprietario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fk_proprietario.Name = "lbl_fk_proprietario";
            this.lbl_fk_proprietario.Size = new System.Drawing.Size(149, 15);
            this.lbl_fk_proprietario.TabIndex = 13;
            this.lbl_fk_proprietario.Text = "Nome do Proprietário:";
            // 
            // lbl_nome_tela
            // 
            this.lbl_nome_tela.AutoSize = true;
            this.lbl_nome_tela.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_tela.Location = new System.Drawing.Point(123, 9);
            this.lbl_nome_tela.Name = "lbl_nome_tela";
            this.lbl_nome_tela.Size = new System.Drawing.Size(228, 23);
            this.lbl_nome_tela.TabIndex = 0;
            this.lbl_nome_tela.Text = "Cadastro Equipamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
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
            this.panel1.Location = new System.Drawing.Point(0, 630);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 27);
            this.panel1.TabIndex = 25;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_data_hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 24);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_data_hora
            // 
            this.lbl_data_hora.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_hora.Name = "lbl_data_hora";
            this.lbl_data_hora.Size = new System.Drawing.Size(178, 19);
            this.lbl_data_hora.Text = "toolStripStatusLabel1";
            // 
            // lbl_pesquisa_monobloco
            // 
            this.lbl_pesquisa_monobloco.AutoSize = true;
            this.lbl_pesquisa_monobloco.Location = new System.Drawing.Point(928, 126);
            this.lbl_pesquisa_monobloco.Name = "lbl_pesquisa_monobloco";
            this.lbl_pesquisa_monobloco.Size = new System.Drawing.Size(257, 15);
            this.lbl_pesquisa_monobloco.TabIndex = 19;
            this.lbl_pesquisa_monobloco.Text = "Pesquisar Monobloco do Equipamento:";
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.BackColor = System.Drawing.Color.White;
            this.txt_pesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pesquisar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_pesquisar.Location = new System.Drawing.Point(931, 144);
            this.txt_pesquisar.MaxLength = 15;
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(371, 23);
            this.txt_pesquisar.TabIndex = 20;
            this.txt_pesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pesquisar_KeyPress);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackColor = System.Drawing.Color.White;
            this.btn_Pesquisar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Pesquisar.Image = global::Projeto3Camadas.Properties.Resources.seo_social_web_network_internet_340_icon_icons1;
            this.btn_Pesquisar.Location = new System.Drawing.Point(1313, 126);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(42, 45);
            this.btn_Pesquisar.TabIndex = 21;
            this.btn_Pesquisar.UseVisualStyleBackColor = false;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // Frm_CadastroEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1370, 657);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.lbl_pesquisa_monobloco);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_nome_tela);
            this.Controls.Add(this.lbl_fk_proprietario);
            this.Controls.Add(this.cmb_fk_proprietario);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.txt_id_equipamento);
            this.Controls.Add(this.lbl_id_equipamento);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.Grid_Equipamentos);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.txt_nf_compra);
            this.Controls.Add(this.txt_horimetro);
            this.Controls.Add(this.txt_serie);
            this.Controls.Add(this.txt_motor);
            this.Controls.Add(this.txt_monobloco);
            this.Controls.Add(this.lbl_NF_Venda);
            this.Controls.Add(this.lbl_nf_compra);
            this.Controls.Add(this.lbl_horimetro);
            this.Controls.Add(this.lbl_serie);
            this.Controls.Add(this.lbl_motor);
            this.Controls.Add(this.lbl_monobloco);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_CadastroEquipamento";
            this.Text = "SCGMT - Sistema de Controle e Gerenciamento das Manutenções em Tratores Agrícolas" +
    "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadastro_Trator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Equipamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lbl_NF_Compra_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lbl_monobloco;
        private System.Windows.Forms.Label lbl_motor;
        private System.Windows.Forms.Label lbl_serie;
        private System.Windows.Forms.Label lbl_horimetro;
        private System.Windows.Forms.Label lbl_nf_compra;
        private System.Windows.Forms.Label lbl_NF_Venda;
        private System.Windows.Forms.TextBox txt_monobloco;
        private System.Windows.Forms.TextBox txt_motor;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.TextBox txt_nf_compra;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.DataGridView Grid_Equipamentos;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Label lbl_id_equipamento;
        private System.Windows.Forms.TextBox txt_id_equipamento;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.ComboBox cmb_fk_proprietario;
        private System.Windows.Forms.Label lbl_fk_proprietario;
        public System.Windows.Forms.TextBox txt_horimetro;
        private System.Windows.Forms.Label lbl_nome_tela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_data_hora;
        private System.Windows.Forms.Label lbl_pesquisa_monobloco;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Button btn_Pesquisar;
    }
}