using System;
using System.Windows.Forms;
using Projeto3Camadas.Código.BLL;
using System.Drawing;

namespace Projeto3Camadas
{
    public partial class Frm_Relatórios : Form
    {
        /// <summary>
        /// Instância de outra classe do software.
        /// </summary>
        RelatóriosBLL bll = new RelatóriosBLL();

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public Frm_Relatórios()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para carregamento do formulário de relatórios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Relatórios_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
        }

        /// <summary>
        /// Evento do botão "Manutenções 100 Horas" do formulário de relatórios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_relatorio_100Horas_Click(object sender, EventArgs e)
        {
            CarregarGrid_100Horas();
        }

        /// <summary>
        /// Evento do botão "Manutenções 500 Horas" do formulário de relatórios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_relatorio_500Horas_Click(object sender, EventArgs e)
        {
            CarregarGrid_500Horas();
        }

        /// <summary>
        /// Evento do botão "Manutenções 1000 Horas" do formulário de relatórios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_relatorio_1000Horas_Click(object sender, EventArgs e)
        {
            CarregarGrid_1000Horas();
        }

        /// <summary>
        /// Evento do botão "Imprimir Relatório" do formulário de relatórios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        /// <summary>
        /// Evento do botão "Sair" do formulário de relatórios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método para carregar o DataGridView do formulário de relatórios com as manutenções de 100 horas já realizadas.
        /// </summary>
        private void CarregarGrid_100Horas()
        {
            Grid_Relatórios.DataSource = bll.SelecionaManutencao100Horas();

            Grid_Relatórios.Columns[0].HeaderText = "Monobloco";
            Grid_Relatórios.Columns[1].HeaderText = "Proprietário";
            Grid_Relatórios.Columns[2].HeaderText = "Horímetro";
            Grid_Relatórios.Columns[3].HeaderText = "Data da Manutenção";
            Grid_Relatórios.Columns[4].HeaderText = "CPF do RP";

            for (int i = 0; i < 4; i++)
            {
                Grid_Relatórios.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid_Relatórios.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Grid_Relatórios.Columns[0].Width = 160;
            Grid_Relatórios.Columns[1].Width = 200;
            Grid_Relatórios.Columns[2].Width = 80;
            Grid_Relatórios.Columns[3].Width = 200;
            Grid_Relatórios.Columns[4].Width = 1000;
        }

        /// <summary>
        /// Método para carregar o DataGridView do formulário de relatórios com as manutenções de 500 horas já realizadas.
        /// </summary>
        private void CarregarGrid_500Horas()
        {
            Grid_Relatórios.DataSource = bll.SelecionaManutencao500Horas();

            Grid_Relatórios.Columns[0].HeaderText = "Monobloco";
            Grid_Relatórios.Columns[1].HeaderText = "Proprietário";
            Grid_Relatórios.Columns[2].HeaderText = "Horímetro";
            Grid_Relatórios.Columns[3].HeaderText = "Data da Manutenção";
            Grid_Relatórios.Columns[4].HeaderText = "CPF do RP";

            for (int i = 0; i < 4; i++)
            {
                Grid_Relatórios.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid_Relatórios.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Grid_Relatórios.Columns[0].Width = 160;
            Grid_Relatórios.Columns[1].Width = 200;
            Grid_Relatórios.Columns[2].Width = 80;
            Grid_Relatórios.Columns[3].Width = 200;
            Grid_Relatórios.Columns[4].Width = 1000;
        }

        /// <summary>
        /// Método para carregar o DataGridView do formulário de relatórios com as manutenções de 1000 horas já realizadas.
        /// </summary>
        private void CarregarGrid_1000Horas()
        {
            Grid_Relatórios.DataSource = bll.SelecionaManutencao1000Horas();

            Grid_Relatórios.Columns[0].HeaderText = "Monobloco";
            Grid_Relatórios.Columns[1].HeaderText = "Proprietário";
            Grid_Relatórios.Columns[2].HeaderText = "Horímetro";
            Grid_Relatórios.Columns[3].HeaderText = "Data da Manutenção";
            Grid_Relatórios.Columns[4].HeaderText = "CPF do RP";

            for (int i = 0; i < 4; i++)
            {
                Grid_Relatórios.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid_Relatórios.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Grid_Relatórios.Columns[0].Width = 160;
            Grid_Relatórios.Columns[1].Width = 200;
            Grid_Relatórios.Columns[2].Width = 80;
            Grid_Relatórios.Columns[3].Width = 200;
            Grid_Relatórios.Columns[4].Width = 1000;
        }

        /// <summary>
        /// Evento para impressão do relatório selecionado no DataGridView do formulário de relatórios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.Grid_Relatórios.Width, this.Grid_Relatórios.Height);
            Grid_Relatórios.DrawToBitmap(objBmp, new Rectangle(0, 0, this.Grid_Relatórios.Width, this.Grid_Relatórios.Height));
            e.Graphics.DrawImage(objBmp, 1, 80);
            e.Graphics.DrawString(lbl_nome_tela.Text, new Font("Rocket", 16, FontStyle.Bold), Brushes.Black, new Point(13, 30));
        }

        /// <summary>
        /// Evento para mostrar a data e a hora no formulário de relatórios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime DataHora = DateTime.Now;
            lbl_data_hora.Text = "  Data: " + DataHora.ToShortDateString() + " - Horas: " + DataHora.ToLongTimeString();
        }
    }
}
