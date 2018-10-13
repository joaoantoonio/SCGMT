using System;
using System.Windows.Forms;
using Projeto3Camadas.Código.BLL;
using Projeto3Camadas.Código.DTO;

namespace Projeto3Camadas
{
    public partial class Frm_Manutenção500Horas : Form
    {
        /// <summary>
        /// Instância de outras classes do software.
        /// </summary>
        M500HorasBLL bll_500 = new M500HorasBLL();
        M500HorasDTO dto_500 = new M500HorasDTO();
        M100HorasBLL bll_100 = new M100HorasBLL();
        ResponsávelTécnicoBLL bll_resp_tec = new ResponsávelTécnicoBLL();
        EquipamentoBLL bll_eq = new EquipamentoBLL();

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public Frm_Manutenção500Horas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para carregamento do formulário de cadastro da manutenção de 500 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Manutenção500Horas_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
            cmb_fk_resp_tecnico.DataSource = bll_resp_tec.SelecionaTodosResponsaveisTecnicos();
            cmb_fk_resp_tecnico.DisplayMember = "nome";
            cmb_fk_resp_tecnico.ValueMember = "cpf";
            txt_cpf_resp_tecnico.Text = cmb_fk_resp_tecnico.SelectedText.ToString();
            CarregarGrid();
            Grid_Manutenção500Horas.Columns[0].Visible = false;
            txt_horimetro.Focus();
        }

        /// <summary>
        /// Evento do botão "Gravar" do formulário de cadastro da manutenção de 500 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            if (bll_500.CampoVazio(txt_horimetro))
                return;
            if (bll_500.CampoVazio(txt_data_manutencao))
                return;
            if (bll_500.CampoVazio(txt_cpf_resp_tecnico))
                return;

            dto_500.fk_equipamento = Convert.ToInt32(txt_fk_equipamento.Text);
            dto_500.horimetro = Convert.ToDecimal(txt_horimetro.Text);
            dto_500.data_manutencao = Convert.ToDateTime(txt_data_manutencao.Text);
            dto_500.cpf_resp_tecnico = txt_cpf_resp_tecnico.Text;

            var valor = dto_500.horimetro;

            DateTime data_500;
            DateTime data_100;
            
            data_500 = DateTime.Parse(txt_data_manutencao.Text);
            data_100 = bll_100.SelecionaDataManutencao100Horas(txt_fk_equipamento.Text);

            if(data_500 > data_100)
            {
                if (valor == 500)
                {
                    if (txt_id_manut_500_horas.Text == "")
                    {
                        if (bll_500.Inserir(dto_500))
                        {
                            MessageBox.Show("Manutenção de 500 horas cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bll_500.AtualizarHorimetro500Horas(Convert.ToDecimal(txt_horimetro.Text), Convert.ToInt32(txt_fk_equipamento.Text));
                            LimparTela();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cadastrar a manutenção de 500 horas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        dto_500.id_manut_500_horas = int.Parse(txt_id_manut_500_horas.Text);

                        if (bll_500.Atualizar(dto_500))
                        {
                            MessageBox.Show("Manutenção de 500 horas editada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bll_500.AtualizarHorimetro500Horas(Convert.ToDecimal(txt_horimetro.Text), Convert.ToInt32(txt_fk_equipamento.Text));
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível editar a manutenção de 500 horas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O Horímetro deve deve conter 500 horas de trabalho!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_horimetro.Focus();
                }
            }
            else
            {
                MessageBox.Show("Data anterior ou igual a data da manutenção de 100 horas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_data_manutencao.Focus();
            }

            CarregarGrid();
        }

        /// <summary>
        /// Evento do botão "Excluir" do formulário de cadastro da manutenção de 500 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (txt_id_manut_500_horas.Text != "")
            {
                var resultado = MessageBox.Show("Você realmente deseja excluir o registro selecionado?", "Exclusão Manutenção 500 Horas?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    bll_eq.ExcluirManut_1000Horas(txt_fk_equipamento.Text);
                    bll_500.Excluir(txt_id_manut_500_horas.Text);
                    MessageBox.Show("Manutenção de 500 horas excluída com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bll_500.AtualizarHorimetro500Horas(Convert.ToDecimal(100), Convert.ToInt32(txt_fk_equipamento.Text));
                    LimparTela();
                    CarregarGrid();
                }
            }
        }

        /// <summary>
        /// Evento do botão "Sair" do formulário de cadastro da manutenção de 500 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento do DataGridView do formulário de cadastro da manutenção de 500 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_Manutenção500Horas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_manut_500_horas.Text = Grid_Manutenção500Horas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_fk_equipamento.Text = Grid_Manutenção500Horas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_monobloco.Text = Grid_Manutenção500Horas.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_serie.Text = Grid_Manutenção500Horas.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_horimetro.Text = Grid_Manutenção500Horas.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_data_manutencao.Text = Grid_Manutenção500Horas.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_cpf_resp_tecnico.Text = Grid_Manutenção500Horas.Rows[e.RowIndex].Cells[6].Value.ToString();

            txt_id_manut_500_horas.Enabled = false;
            txt_fk_equipamento.Enabled = false;
            txt_monobloco.Enabled = false;
            txt_serie.Enabled = false;
            txt_horimetro.Enabled = false;
            txt_data_manutencao.Enabled = false;
            cmb_fk_resp_tecnico.Enabled = false;
            txt_cpf_resp_tecnico.Enabled = false;
            btn_Inserir.Enabled = false;
        }

        /// <summary>
        /// Método para carregar o DataGridView do formulário de cadastro da manutenção de 500 horas do equipamento.
        /// </summary>
        private void CarregarGrid()
        {
            Grid_Manutenção500Horas.DataSource = bll_500.SelecionaTodasManutencoes500Horas();

            Grid_Manutenção500Horas.Columns[0].HeaderText = "Código Manutenção";
            Grid_Manutenção500Horas.Columns[1].HeaderText = "Código do Equipamento";
            Grid_Manutenção500Horas.Columns[2].HeaderText = "Monobloco";
            Grid_Manutenção500Horas.Columns[3].HeaderText = "Série";
            Grid_Manutenção500Horas.Columns[4].HeaderText = "Horímetro";
            Grid_Manutenção500Horas.Columns[5].HeaderText = "Data da Manutenção";
            Grid_Manutenção500Horas.Columns[6].HeaderText = "CPF do Responsável Técnico";

            for(int i = 0; i < 7; i++)
            {
                Grid_Manutenção500Horas.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid_Manutenção500Horas.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Grid_Manutenção500Horas.Columns[0].Width = 0;
            Grid_Manutenção500Horas.Columns[1].Width = 185;
            Grid_Manutenção500Horas.Columns[2].Width = 135;
            Grid_Manutenção500Horas.Columns[3].Width = 110;
            Grid_Manutenção500Horas.Columns[4].Width = 110;
            Grid_Manutenção500Horas.Columns[5].Width = 110;
            Grid_Manutenção500Horas.Columns[6].Width = 270;
        }

        /// <summary>
        /// Método para limpar os campos do formulário de cadastro da manutenção de 500 horas do equipamento.
        /// </summary>
        private void LimparTela()
        {
            txt_id_manut_500_horas.Clear();
            txt_fk_equipamento.Clear();
            txt_monobloco.Clear();
            txt_serie.Clear();
            txt_horimetro.Clear();
            txt_data_manutencao.Clear();
            txt_cpf_resp_tecnico.Clear();
        }

        /// <summary>
        /// Evento para formatação do número do horímetro do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_horimetro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação da data da manutenção de 500 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_data_manutencao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_data_manutencao.TextLength)
                {
                    case 0:
                        txt_data_manutencao.Text = "";
                        break;

                    case 2:
                        txt_data_manutencao.Text = txt_data_manutencao.Text + "/";
                        txt_data_manutencao.SelectionStart = 4;
                        break;

                    case 5:
                        txt_data_manutencao.Text = txt_data_manutencao.Text + "/";
                        txt_data_manutencao.SelectionStart = 7;
                        break;
                }
            }
        }

        /// <summary>
        /// Evento para validação da data da manutenção de 500 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_data_manutencao_Leave(object sender, EventArgs e)
        {
            if (txt_data_manutencao.TextLength == 10)
            {

            }
            else
            {
                MessageBox.Show("Digite 8 caracteres para a data da manutenção!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_data_manutencao.Focus();
            }
        }

        /// <summary>
        /// Evento para mostrar a data e a hora no formulário de cadastro da manutenção de 100 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime DataHora = DateTime.Now;
            lbl_data_hora.Text = "  Data: " + DataHora.ToShortDateString() + " - Horas: " + DataHora.ToLongTimeString();
        }

        /// <summary>
        /// Evento para vincular o CPF do responsável técnico de acordo com a seleção do combobox no formulário de cadastro da manutenção de 500 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_fk_resp_tecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cpf_resp_tecnico.Text = cmb_fk_resp_tecnico.SelectedValue.ToString();
        }
    }
}
