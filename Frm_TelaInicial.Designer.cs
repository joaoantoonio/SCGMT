namespace Projeto3Camadas
{
    partial class Frm_TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TelaInicial));
            this.pcbx_tela_inicial = new System.Windows.Forms.PictureBox();
            this.pgb_tela_inicial = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_tela_inicial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_tela_inicial)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbx_tela_inicial
            // 
            this.pcbx_tela_inicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbx_tela_inicial.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcbx_tela_inicial.ErrorImage")));
            this.pcbx_tela_inicial.Image = ((System.Drawing.Image)(resources.GetObject("pcbx_tela_inicial.Image")));
            this.pcbx_tela_inicial.Location = new System.Drawing.Point(0, 0);
            this.pcbx_tela_inicial.Name = "pcbx_tela_inicial";
            this.pcbx_tela_inicial.Size = new System.Drawing.Size(1077, 601);
            this.pcbx_tela_inicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbx_tela_inicial.TabIndex = 0;
            this.pcbx_tela_inicial.TabStop = false;
            // 
            // pgb_tela_inicial
            // 
            this.pgb_tela_inicial.BackColor = System.Drawing.Color.White;
            this.pgb_tela_inicial.ForeColor = System.Drawing.Color.White;
            this.pgb_tela_inicial.Location = new System.Drawing.Point(12, 75);
            this.pgb_tela_inicial.Name = "pgb_tela_inicial";
            this.pgb_tela_inicial.Size = new System.Drawing.Size(71, 452);
            this.pgb_tela_inicial.TabIndex = 1;
            this.pgb_tela_inicial.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_tela_inicial
            // 
            this.lbl_tela_inicial.AutoSize = true;
            this.lbl_tela_inicial.BackColor = System.Drawing.Color.White;
            this.lbl_tela_inicial.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tela_inicial.ForeColor = System.Drawing.Color.Black;
            this.lbl_tela_inicial.Location = new System.Drawing.Point(329, 504);
            this.lbl_tela_inicial.Name = "lbl_tela_inicial";
            this.lbl_tela_inicial.Size = new System.Drawing.Size(758, 23);
            this.lbl_tela_inicial.TabIndex = 2;
            this.lbl_tela_inicial.Text = "Sistema de Controle e Gerenciamento das Manutenções em Tratores Agrícolas";
            this.lbl_tela_inicial.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Frm_TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 601);
            this.Controls.Add(this.lbl_tela_inicial);
            this.Controls.Add(this.pgb_tela_inicial);
            this.Controls.Add(this.pcbx_tela_inicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_TelaInicial";
            this.Text = "SCGMT - Sistema de Controle e Gerenciamento das Manutenções em Tratores Agrícolas" +
    "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_tela_inicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbx_tela_inicial;
        private System.Windows.Forms.ProgressBar pgb_tela_inicial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_tela_inicial;
    }
}