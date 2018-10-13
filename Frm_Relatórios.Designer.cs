namespace Projeto3Camadas
{
    partial class Frm_Relatórios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Relatórios));
            this.Grid_Relatórios = new System.Windows.Forms.DataGridView();
            this.btn_relatorio_100Horas = new System.Windows.Forms.Button();
            this.btn_relatorio_500Horas = new System.Windows.Forms.Button();
            this.btn_relatorio_1000Horas = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_nome_tela = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_data_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Relatórios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_Relatórios
            // 
            this.Grid_Relatórios.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.Grid_Relatórios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Relatórios.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Grid_Relatórios.Location = new System.Drawing.Point(13, 68);
            this.Grid_Relatórios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Grid_Relatórios.Name = "Grid_Relatórios";
            this.Grid_Relatórios.ReadOnly = true;
            this.Grid_Relatórios.Size = new System.Drawing.Size(1339, 592);
            this.Grid_Relatórios.TabIndex = 6;
            // 
            // btn_relatorio_100Horas
            // 
            this.btn_relatorio_100Horas.BackColor = System.Drawing.Color.White;
            this.btn_relatorio_100Horas.Location = new System.Drawing.Point(13, 666);
            this.btn_relatorio_100Horas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_relatorio_100Horas.Name = "btn_relatorio_100Horas";
            this.btn_relatorio_100Horas.Size = new System.Drawing.Size(275, 25);
            this.btn_relatorio_100Horas.TabIndex = 1;
            this.btn_relatorio_100Horas.Text = "Manutenções 100 Horas";
            this.btn_relatorio_100Horas.UseVisualStyleBackColor = false;
            this.btn_relatorio_100Horas.Click += new System.EventHandler(this.btn_relatorio_100Horas_Click);
            // 
            // btn_relatorio_500Horas
            // 
            this.btn_relatorio_500Horas.BackColor = System.Drawing.Color.White;
            this.btn_relatorio_500Horas.Location = new System.Drawing.Point(296, 666);
            this.btn_relatorio_500Horas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_relatorio_500Horas.Name = "btn_relatorio_500Horas";
            this.btn_relatorio_500Horas.Size = new System.Drawing.Size(275, 25);
            this.btn_relatorio_500Horas.TabIndex = 2;
            this.btn_relatorio_500Horas.Text = "Manutenções 500 Horas";
            this.btn_relatorio_500Horas.UseVisualStyleBackColor = false;
            this.btn_relatorio_500Horas.Click += new System.EventHandler(this.btn_relatorio_500Horas_Click);
            // 
            // btn_relatorio_1000Horas
            // 
            this.btn_relatorio_1000Horas.BackColor = System.Drawing.Color.White;
            this.btn_relatorio_1000Horas.Location = new System.Drawing.Point(579, 666);
            this.btn_relatorio_1000Horas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_relatorio_1000Horas.Name = "btn_relatorio_1000Horas";
            this.btn_relatorio_1000Horas.Size = new System.Drawing.Size(275, 25);
            this.btn_relatorio_1000Horas.TabIndex = 3;
            this.btn_relatorio_1000Horas.Text = "Manutenções 1000 Horas";
            this.btn_relatorio_1000Horas.UseVisualStyleBackColor = false;
            this.btn_relatorio_1000Horas.Click += new System.EventHandler(this.btn_relatorio_1000Horas_Click);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.BackColor = System.Drawing.Color.White;
            this.btn_Imprimir.Location = new System.Drawing.Point(862, 666);
            this.btn_Imprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(250, 25);
            this.btn_Imprimir.TabIndex = 4;
            this.btn_Imprimir.Text = "Imprimir Relatório";
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(1120, 666);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(232, 25);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_nome_tela
            // 
            this.lbl_nome_tela.AutoSize = true;
            this.lbl_nome_tela.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_tela.Location = new System.Drawing.Point(120, 12);
            this.lbl_nome_tela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome_tela.Name = "lbl_nome_tela";
            this.lbl_nome_tela.Size = new System.Drawing.Size(108, 23);
            this.lbl_nome_tela.TabIndex = 0;
            this.lbl_nome_tela.Text = "Relatórios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
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
            this.panel1.Location = new System.Drawing.Point(0, 721);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 24);
            this.panel1.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_data_hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 24);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_data_hora
            // 
            this.lbl_data_hora.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_hora.Name = "lbl_data_hora";
            this.lbl_data_hora.Size = new System.Drawing.Size(178, 19);
            this.lbl_data_hora.Text = "toolStripStatusLabel1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Frm_Relatórios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1370, 745);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_nome_tela);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.btn_relatorio_1000Horas);
            this.Controls.Add(this.btn_relatorio_500Horas);
            this.Controls.Add(this.btn_relatorio_100Horas);
            this.Controls.Add(this.Grid_Relatórios);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_Relatórios";
            this.Text = "SCGMT - Sistema de Controle e Gerenciamento das Manutenções em Tratores Agrícolas" +
    "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Relatórios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Relatórios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Relatórios;
        private System.Windows.Forms.Button btn_relatorio_100Horas;
        private System.Windows.Forms.Button btn_relatorio_500Horas;
        private System.Windows.Forms.Button btn_relatorio_1000Horas;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_nome_tela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_data_hora;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}