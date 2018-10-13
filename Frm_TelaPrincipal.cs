using System;
using System.Windows.Forms;
using Projeto3Camadas.Código.BLL;
using Projeto3Camadas.Código.DTO;

namespace Projeto3Camadas
{
    public partial class Frm_TelaPrincipal : Form
    {
        /// <summary>
        /// Instância de outras classes do software.
        /// </summary>
        TelaPrincipalBLL bll_tp = new TelaPrincipalBLL();
        EquipamentoBLL bll = new EquipamentoBLL();
        EquipamentoDTO dto = new EquipamentoDTO();
        ProprietárioBLL bll_p = new ProprietárioBLL();
        ProprietárioDTO dto_p = new ProprietárioDTO();

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public Frm_TelaPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para carregamento do formulário da tela principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTela_Principal_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
        }

        /// <summary>
        /// Evento para ativação do formulário da tela principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_TelaPrincipal_Activated(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        /// <summary>
        /// Evento do botão "Cadastrar Proprietário" do formulário da tela principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cadastrar_Proprietário_Click(object sender, EventArgs e)
        {
            Frm_CadastroProprietário frm_cadastro_proprietario = new Frm_CadastroProprietário();
            frm_cadastro_proprietario.ShowDialog();
        }

        /// <summary>
        /// Evento do botão "Cadastrar Equipamento" do formulário da tela principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cadastrar_Equipamento_Click(object sender, EventArgs e)
        {
            Frm_CadastroEquipamento frm_cadastro_equipamento = new Frm_CadastroEquipamento();
            frm_cadastro_equipamento.ShowDialog();
        }

        /// <summary>
        /// Evento do botão "Cadastrar Responsável Técnico" do formulário da tela principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cadastrar_ResponsávelTécnico_Click(object sender, EventArgs e)
        {
            Frm_CadastroResponsávelTécnico frm_cadastro_responsavel_tecnico = new Frm_CadastroResponsávelTécnico();
            frm_cadastro_responsavel_tecnico.ShowDialog();
        }

        /// <summary>
        /// Evento do botão "Relatórios" do formulário da tela principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Relatórios_Click(object sender, EventArgs e)
        {
            Frm_Relatórios frm_relatorios = new Frm_Relatórios();
            frm_relatorios.ShowDialog();
        }

        /// <summary>
        /// Evento do botão "Próxima Manutenção" do formulário da tela principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Próxima_Manutenção_Click(object sender, EventArgs e)
        {
            Frm_Manutenção100Horas frm_manutencao_100Horas = new Frm_Manutenção100Horas();
            Frm_Manutenção500Horas frm_manutencao_500Horas = new Frm_Manutenção500Horas();
            Frm_Manutenção1000Horas frm_manutencao_1000Horas = new Frm_Manutenção1000Horas();

            var valor = float.Parse(Grid_Tela_Principal.CurrentRow.Cells[4].Value.ToString());

            if (valor == 1)
            {
                frm_manutencao_100Horas.txt_fk_equipamento.Text = Grid_Tela_Principal.CurrentRow.Cells[0].Value.ToString();
                frm_manutencao_100Horas.txt_monobloco.Text = Grid_Tela_Principal.CurrentRow.Cells[1].Value.ToString();
                frm_manutencao_100Horas.txt_serie.Text = Grid_Tela_Principal.CurrentRow.Cells[2].Value.ToString();
                frm_manutencao_100Horas.ShowDialog();
            }
            else if (valor >= 100 && valor < 500)
            {
                frm_manutencao_500Horas.txt_fk_equipamento.Text = Grid_Tela_Principal.CurrentRow.Cells[0].Value.ToString();
                frm_manutencao_500Horas.txt_monobloco.Text = Grid_Tela_Principal.CurrentRow.Cells[1].Value.ToString();
                frm_manutencao_500Horas.txt_serie.Text = Grid_Tela_Principal.CurrentRow.Cells[2].Value.ToString();
                frm_manutencao_500Horas.ShowDialog();
            }
            else if (valor >= 500 && valor < 998)
            {
                frm_manutencao_1000Horas.txt_fk_equipamento.Text = Grid_Tela_Principal.CurrentRow.Cells[0].Value.ToString();
                frm_manutencao_1000Horas.txt_monobloco.Text = Grid_Tela_Principal.CurrentRow.Cells[1].Value.ToString();
                frm_manutencao_1000Horas.txt_serie.Text = Grid_Tela_Principal.CurrentRow.Cells[2].Value.ToString();
                frm_manutencao_1000Horas.ShowDialog();
            }
            else
                MessageBox.Show("O equipamento não tem nenhuma revisão a ser realizada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Evento do botão "Sair" do formulário da tela principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento do botão "Pesquisar" do formulário da tela principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Grid_Tela_Principal.DataSource = bll.PesquisaEquipamento(txt_pesquisar.Text);

            if(txt_pesquisar.Text == "")
            {
                MessageBox.Show("Digite o monobloco do equipamento!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Grid_Tela_Principal.Columns[0].HeaderText = "Código do Equipamento";
                Grid_Tela_Principal.Columns[1].HeaderText = "Monobloco";
                Grid_Tela_Principal.Columns[2].HeaderText = "Motor";
                Grid_Tela_Principal.Columns[3].HeaderText = "Série";
                Grid_Tela_Principal.Columns[4].HeaderText = "Horímetro";
                Grid_Tela_Principal.Columns[5].HeaderText = "Nota Fiscal de Compra";

                for (int i = 0; i < 6; i++)
                {
                    Grid_Tela_Principal.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Grid_Tela_Principal.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                Grid_Tela_Principal.Columns[0].Width = 200;
                Grid_Tela_Principal.Columns[1].Width = 200;
                Grid_Tela_Principal.Columns[2].Width = 200;
                Grid_Tela_Principal.Columns[3].Width = 200;
                Grid_Tela_Principal.Columns[4].Width = 200;
                Grid_Tela_Principal.Columns[5].Width = 300;
            }
        }

        /// <summary>
        /// Método para carregar o DataGridView do formulário da tela principal.
        /// </summary>
        private void CarregarGrid()
        {
            Grid_Tela_Principal.DataSource = bll_tp.SelecionaEquipamentos_Proprietarios();

            Grid_Tela_Principal.Columns[0].HeaderText = "Código do Equipamento";
            Grid_Tela_Principal.Columns[1].HeaderText = "Monobloco";
            Grid_Tela_Principal.Columns[2].HeaderText = "Série";
            Grid_Tela_Principal.Columns[3].HeaderText = "Motor";
            Grid_Tela_Principal.Columns[4].HeaderText = "Horímetro";
            Grid_Tela_Principal.Columns[5].HeaderText = "Proprietário";

            for (int i = 0; i < 6; i++)
            {
                Grid_Tela_Principal.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid_Tela_Principal.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Grid_Tela_Principal.Columns[0].Width = 200;
            Grid_Tela_Principal.Columns[1].Width = 200;
            Grid_Tela_Principal.Columns[2].Width = 200;
            Grid_Tela_Principal.Columns[3].Width = 200;
            Grid_Tela_Principal.Columns[4].Width = 200;
            Grid_Tela_Principal.Columns[5].Width = 300;
        }

        /// <summary>
        /// Evento para formatação do número do monobloco do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_pesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para mostrar a data e a hora no formulário da tela principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime DataHora = DateTime.Now;
            lbl_data_hora.Text = "   Data: " + DataHora.ToShortDateString() + " - Horas: " + DataHora.ToLongTimeString();
        }
    }
}
