namespace Projeto3Camadas
{
    partial class Frm_Manutenção100Horas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Manutenção100Horas));
            this.lbl_fk_equipamento = new System.Windows.Forms.Label();
            this.txt_fk_equipamento = new System.Windows.Forms.TextBox();
            this.lbl_monobloco = new System.Windows.Forms.Label();
            this.txt_monobloco = new System.Windows.Forms.TextBox();
            this.lbl_serie = new System.Windows.Forms.Label();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.lbl_horimetro = new System.Windows.Forms.Label();
            this.lbl_data_manutencao = new System.Windows.Forms.Label();
            this.lbl_nome_resp_tecnico = new System.Windows.Forms.Label();
            this.lbl_cpf_resp_tecnico = new System.Windows.Forms.Label();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.Grid_Manutenção100Horas = new System.Windows.Forms.DataGridView();
            this.cmb_fk_resp_tecnico = new System.Windows.Forms.ComboBox();
            this.lbl_id_manut_100_horas = new System.Windows.Forms.Label();
            this.txt_id_manut_100_horas = new System.Windows.Forms.TextBox();
            this.txt_horimetro = new System.Windows.Forms.TextBox();
            this.txt_data_manutencao = new System.Windows.Forms.TextBox();
            this.lbl_nome_tela = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_data_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_cpf_resp_tecnico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Manutenção100Horas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_fk_equipamento
            // 
            this.lbl_fk_equipamento.AutoSize = true;
            this.lbl_fk_equipamento.Location = new System.Drawing.Point(395, 28);
            this.lbl_fk_equipamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fk_equipamento.Name = "lbl_fk_equipamento";
            this.lbl_fk_equipamento.Size = new System.Drawing.Size(116, 15);
            this.lbl_fk_equipamento.TabIndex = 3;
            this.lbl_fk_equipamento.Text = "ID Equipamento:";
            this.lbl_fk_equipamento.Visible = false;
            // 
            // txt_fk_equipamento
            // 
            this.txt_fk_equipamento.BackColor = System.Drawing.Color.White;
            this.txt_fk_equipamento.Location = new System.Drawing.Point(398, 46);
            this.txt_fk_equipamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_fk_equipamento.Name = "txt_fk_equipamento";
            this.txt_fk_equipamento.ReadOnly = true;
            this.txt_fk_equipamento.Size = new System.Drawing.Size(207, 23);
            this.txt_fk_equipamento.TabIndex = 4;
            this.txt_fk_equipamento.Visible = false;
            // 
            // lbl_monobloco
            // 
            this.lbl_monobloco.AutoSize = true;
            this.lbl_monobloco.Location = new System.Drawing.Point(16, 55);
            this.lbl_monobloco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_monobloco.Name = "lbl_monobloco";
            this.lbl_monobloco.Size = new System.Drawing.Size(82, 15);
            this.lbl_monobloco.TabIndex = 5;
            this.lbl_monobloco.Text = "Monobloco:";
            // 
            // txt_monobloco
            // 
            this.txt_monobloco.BackColor = System.Drawing.Color.White;
            this.txt_monobloco.Location = new System.Drawing.Point(16, 74);
            this.txt_monobloco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_monobloco.MaxLength = 15;
            this.txt_monobloco.Name = "txt_monobloco";
            this.txt_monobloco.ReadOnly = true;
            this.txt_monobloco.Size = new System.Drawing.Size(207, 23);
            this.txt_monobloco.TabIndex = 6;
            // 
            // lbl_serie
            // 
            this.lbl_serie.AutoSize = true;
            this.lbl_serie.Location = new System.Drawing.Point(16, 100);
            this.lbl_serie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_serie.Name = "lbl_serie";
            this.lbl_serie.Size = new System.Drawing.Size(44, 15);
            this.lbl_serie.TabIndex = 7;
            this.lbl_serie.Text = "Série:";
            // 
            // txt_serie
            // 
            this.txt_serie.BackColor = System.Drawing.Color.White;
            this.txt_serie.Location = new System.Drawing.Point(16, 119);
            this.txt_serie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_serie.MaxLength = 10;
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.ReadOnly = true;
            this.txt_serie.Size = new System.Drawing.Size(207, 23);
            this.txt_serie.TabIndex = 8;
            // 
            // lbl_horimetro
            // 
            this.lbl_horimetro.AutoSize = true;
            this.lbl_horimetro.Location = new System.Drawing.Point(16, 145);
            this.lbl_horimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_horimetro.Name = "lbl_horimetro";
            this.lbl_horimetro.Size = new System.Drawing.Size(78, 15);
            this.lbl_horimetro.TabIndex = 9;
            this.lbl_horimetro.Text = "Horímetro:";
            // 
            // lbl_data_manutencao
            // 
            this.lbl_data_manutencao.AutoSize = true;
            this.lbl_data_manutencao.Location = new System.Drawing.Point(16, 190);
            this.lbl_data_manutencao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_data_manutencao.Name = "lbl_data_manutencao";
            this.lbl_data_manutencao.Size = new System.Drawing.Size(144, 15);
            this.lbl_data_manutencao.TabIndex = 11;
            this.lbl_data_manutencao.Text = "Data da manutenção:";
            // 
            // lbl_nome_resp_tecnico
            // 
            this.lbl_nome_resp_tecnico.AutoSize = true;
            this.lbl_nome_resp_tecnico.Location = new System.Drawing.Point(16, 235);
            this.lbl_nome_resp_tecnico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome_resp_tecnico.Name = "lbl_nome_resp_tecnico";
            this.lbl_nome_resp_tecnico.Size = new System.Drawing.Size(374, 15);
            this.lbl_nome_resp_tecnico.TabIndex = 13;
            this.lbl_nome_resp_tecnico.Text = "Nome do responsável técnico que executou a manutenção:";
            // 
            // lbl_cpf_resp_tecnico
            // 
            this.lbl_cpf_resp_tecnico.AutoSize = true;
            this.lbl_cpf_resp_tecnico.Location = new System.Drawing.Point(16, 280);
            this.lbl_cpf_resp_tecnico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cpf_resp_tecnico.Name = "lbl_cpf_resp_tecnico";
            this.lbl_cpf_resp_tecnico.Size = new System.Drawing.Size(367, 15);
            this.lbl_cpf_resp_tecnico.TabIndex = 15;
            this.lbl_cpf_resp_tecnico.Text = "CPF do responsável técnico que executou a manutenção: ";
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.White;
            this.btn_Inserir.Location = new System.Drawing.Point(16, 329);
            this.btn_Inserir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(100, 25);
            this.btn_Inserir.TabIndex = 17;
            this.btn_Inserir.Text = "Gravar";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.White;
            this.btn_Excluir.Location = new System.Drawing.Point(123, 329);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(100, 25);
            this.btn_Excluir.TabIndex = 18;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(231, 329);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(100, 25);
            this.btn_Sair.TabIndex = 19;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // Grid_Manutenção100Horas
            // 
            this.Grid_Manutenção100Horas.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.Grid_Manutenção100Horas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Manutenção100Horas.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Grid_Manutenção100Horas.Location = new System.Drawing.Point(398, 74);
            this.Grid_Manutenção100Horas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Grid_Manutenção100Horas.Name = "Grid_Manutenção100Horas";
            this.Grid_Manutenção100Horas.ReadOnly = true;
            this.Grid_Manutenção100Horas.Size = new System.Drawing.Size(952, 280);
            this.Grid_Manutenção100Horas.TabIndex = 20;
            this.Grid_Manutenção100Horas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Manutenção100Horas_CellContentClick);
            // 
            // cmb_fk_resp_tecnico
            // 
            this.cmb_fk_resp_tecnico.BackColor = System.Drawing.Color.White;
            this.cmb_fk_resp_tecnico.FormattingEnabled = true;
            this.cmb_fk_resp_tecnico.Location = new System.Drawing.Point(16, 255);
            this.cmb_fk_resp_tecnico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_fk_resp_tecnico.Name = "cmb_fk_resp_tecnico";
            this.cmb_fk_resp_tecnico.Size = new System.Drawing.Size(315, 23);
            this.cmb_fk_resp_tecnico.TabIndex = 14;
            this.cmb_fk_resp_tecnico.SelectedIndexChanged += new System.EventHandler(this.cmb_fk_resp_tecnico_SelectedIndexChanged);
            // 
            // lbl_id_manut_100_horas
            // 
            this.lbl_id_manut_100_horas.AutoSize = true;
            this.lbl_id_manut_100_horas.Location = new System.Drawing.Point(610, 28);
            this.lbl_id_manut_100_horas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_manut_100_horas.Name = "lbl_id_manut_100_horas";
            this.lbl_id_manut_100_horas.Size = new System.Drawing.Size(110, 15);
            this.lbl_id_manut_100_horas.TabIndex = 1;
            this.lbl_id_manut_100_horas.Text = "ID Manutenção:";
            this.lbl_id_manut_100_horas.Visible = false;
            // 
            // txt_id_manut_100_horas
            // 
            this.txt_id_manut_100_horas.BackColor = System.Drawing.Color.White;
            this.txt_id_manut_100_horas.Location = new System.Drawing.Point(613, 46);
            this.txt_id_manut_100_horas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_id_manut_100_horas.Name = "txt_id_manut_100_horas";
            this.txt_id_manut_100_horas.ReadOnly = true;
            this.txt_id_manut_100_horas.Size = new System.Drawing.Size(99, 23);
            this.txt_id_manut_100_horas.TabIndex = 2;
            this.txt_id_manut_100_horas.Visible = false;
            // 
            // txt_horimetro
            // 
            this.txt_horimetro.BackColor = System.Drawing.Color.White;
            this.txt_horimetro.Location = new System.Drawing.Point(16, 164);
            this.txt_horimetro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_horimetro.MaxLength = 3;
            this.txt_horimetro.Name = "txt_horimetro";
            this.txt_horimetro.Size = new System.Drawing.Size(207, 23);
            this.txt_horimetro.TabIndex = 10;
            this.txt_horimetro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_horimetro_KeyPress);
            // 
            // txt_data_manutencao
            // 
            this.txt_data_manutencao.BackColor = System.Drawing.Color.White;
            this.txt_data_manutencao.Location = new System.Drawing.Point(16, 210);
            this.txt_data_manutencao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_data_manutencao.MaxLength = 10;
            this.txt_data_manutencao.Name = "txt_data_manutencao";
            this.txt_data_manutencao.Size = new System.Drawing.Size(207, 23);
            this.txt_data_manutencao.TabIndex = 12;
            this.txt_data_manutencao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_data_manutencao_KeyPress);
            this.txt_data_manutencao.Leave += new System.EventHandler(this.txt_data_manutencao_Leave);
            // 
            // lbl_nome_tela
            // 
            this.lbl_nome_tela.AutoSize = true;
            this.lbl_nome_tela.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_tela.Location = new System.Drawing.Point(119, 2);
            this.lbl_nome_tela.Name = "lbl_nome_tela";
            this.lbl_nome_tela.Size = new System.Drawing.Size(251, 23);
            this.lbl_nome_tela.TabIndex = 0;
            this.lbl_nome_tela.Text = "Manutenção de 100 Horas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 27);
            this.panel1.TabIndex = 22;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_data_hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 24);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_data_hora
            // 
            this.lbl_data_hora.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_hora.Name = "lbl_data_hora";
            this.lbl_data_hora.Size = new System.Drawing.Size(178, 19);
            this.lbl_data_hora.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_cpf_resp_tecnico
            // 
            this.txt_cpf_resp_tecnico.BackColor = System.Drawing.Color.White;
            this.txt_cpf_resp_tecnico.Location = new System.Drawing.Point(16, 300);
            this.txt_cpf_resp_tecnico.Name = "txt_cpf_resp_tecnico";
            this.txt_cpf_resp_tecnico.ReadOnly = true;
            this.txt_cpf_resp_tecnico.Size = new System.Drawing.Size(315, 23);
            this.txt_cpf_resp_tecnico.TabIndex = 16;
            // 
            // Frm_Manutenção100Horas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1370, 421);
            this.Controls.Add(this.txt_cpf_resp_tecnico);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_nome_tela);
            this.Controls.Add(this.txt_data_manutencao);
            this.Controls.Add(this.txt_id_manut_100_horas);
            this.Controls.Add(this.lbl_id_manut_100_horas);
            this.Controls.Add(this.cmb_fk_resp_tecnico);
            this.Controls.Add(this.Grid_Manutenção100Horas);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.lbl_cpf_resp_tecnico);
            this.Controls.Add(this.lbl_nome_resp_tecnico);
            this.Controls.Add(this.lbl_data_manutencao);
            this.Controls.Add(this.txt_horimetro);
            this.Controls.Add(this.lbl_horimetro);
            this.Controls.Add(this.txt_serie);
            this.Controls.Add(this.lbl_serie);
            this.Controls.Add(this.txt_monobloco);
            this.Controls.Add(this.lbl_monobloco);
            this.Controls.Add(this.txt_fk_equipamento);
            this.Controls.Add(this.lbl_fk_equipamento);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_Manutenção100Horas";
            this.Text = "SCGMT - Sistema de Controle e Gerenciamento das Manutenções em Tratores Agrícolas" +
    "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Manutenção100Horas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Manutenção100Horas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fk_equipamento;
        private System.Windows.Forms.Label lbl_monobloco;
        private System.Windows.Forms.Label lbl_serie;
        private System.Windows.Forms.Label lbl_horimetro;
        private System.Windows.Forms.Label lbl_data_manutencao;
        private System.Windows.Forms.Label lbl_nome_resp_tecnico;
        private System.Windows.Forms.Label lbl_cpf_resp_tecnico;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.DataGridView Grid_Manutenção100Horas;
        public System.Windows.Forms.TextBox txt_fk_equipamento;
        public System.Windows.Forms.TextBox txt_monobloco;
        public System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.ComboBox cmb_fk_resp_tecnico;
        private System.Windows.Forms.Label lbl_id_manut_100_horas;
        private System.Windows.Forms.TextBox txt_id_manut_100_horas;
        public System.Windows.Forms.TextBox txt_horimetro;
        private System.Windows.Forms.TextBox txt_data_manutencao;
        private System.Windows.Forms.Label lbl_nome_tela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_data_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_cpf_resp_tecnico;
    }
}