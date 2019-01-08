using System;
using System.Windows.Forms;
using Projeto3Camadas.Código.BLL;
using Projeto3Camadas.Código.DTO;

namespace Projeto3Camadas
{
    public partial class Frm_Manutenção100Horas : Form
    {
        /// <summary>
        /// Instância de outras classes do software.
        /// </summary>
        M100HorasBLL bll_100 = new M100HorasBLL();
        M100HorasDTO dto_100 = new M100HorasDTO();
        ResponsávelTécnicoBLL bll_resp_tec = new ResponsávelTécnicoBLL();
        EquipamentoBLL bll_eq = new EquipamentoBLL();

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public Frm_Manutenção100Horas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para carregamento do formulário de cadastro da manutenção de 100 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Manutenção100Horas_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
            cmb_fk_resp_tecnico.DataSource = bll_resp_tec.SelecionaTodosResponsaveisTecnicos();
            cmb_fk_resp_tecnico.DisplayMember = "nome";
            cmb_fk_resp_tecnico.ValueMember = "cpf";
            txt_cpf_resp_tecnico.Text = cmb_fk_resp_tecnico.SelectedText.ToString();
            CarregarGrid();
            Grid_Manutenção100Horas.Columns[0].Visible = false;
            txt_horimetro.Focus();
        }

        /// <summary>
        /// Evento do botão "Gravar" do formulário de cadastro da manutenção de 100 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            if (bll_100.CampoVazio(txt_horimetro))
                return;
            if (bll_100.CampoVazio(txt_data_manutencao))
                return;
            if (bll_100.CampoVazio(txt_cpf_resp_tecnico))
                return;
          
            dto_100.fk_equipamento = Convert.ToInt32(txt_fk_equipamento.Text);
            dto_100.horimetro = Convert.ToDecimal(txt_horimetro.Text);
            dto_100.data_manutencao = Convert.ToDateTime(txt_data_manutencao.Text);            
            dto_100.cpf_resp_tecnico = txt_cpf_resp_tecnico.Text;

            var valor = dto_100.horimetro;

            if(valor == 100)
            {
                if (txt_id_manut_100_horas.Text == "")
                {
                    if (bll_100.Inserir(dto_100))
                    {
                        MessageBox.Show("Manutenção de 100 horas cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bll_100.AtualizarHorimetro100Horas(Convert.ToDecimal(txt_horimetro.Text), Convert.ToInt32(txt_fk_equipamento.Text));
                        LimparTela();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar a manutenção de 100 horas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }      
                }
                else
                {
                    dto_100.id_manut_100_horas = int.Parse(txt_id_manut_100_horas.Text);

                    if (bll_100.Atualizar(dto_100))
                    {
                        MessageBox.Show("Manutenção de 100 horas editada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bll_100.AtualizarHorimetro100Horas(Convert.ToDecimal(txt_horimetro.Text), Convert.ToInt32(txt_fk_equipamento.Text));
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível editar a manutenção de 100 horas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("O Horímetro deve conter 100 horas de trabalho!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_horimetro.Focus();
            }

            CarregarGrid();
        }

        /// <summary>
        /// Evento do botão "Excluir" do formulário de cadastro da manutenção de 100 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (txt_id_manut_100_horas.Text != "")
            {
                var resultado = MessageBox.Show("Você realmente deseja excluir o registro selecionado?", "Exclusão Manutenção 100 Horas?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    bll_eq.ExcluirManut_500Horas(txt_fk_equipamento.Text);
                    bll_eq.ExcluirManut_1000Horas(txt_fk_equipamento.Text);
                    bll_100.Excluir(txt_id_manut_100_horas.Text);
                    MessageBox.Show("Manutenção de 100 horas excluída com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bll_100.AtualizarHorimetro100Horas(Convert.ToDecimal(1), Convert.ToInt32(txt_fk_equipamento.Text));
                    LimparTela();
                    CarregarGrid();   
                }
            }
        }

        /// <summary>
        /// Evento do botão "Sair" do formulário de cadastro da manutenção de 100 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento do DataGridView do formulário de cadastro da manutenção de 100 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_Manutenção100Horas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_manut_100_horas.Text = Grid_Manutenção100Horas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_fk_equipamento.Text = Grid_Manutenção100Horas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_monobloco.Text = Grid_Manutenção100Horas.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_serie.Text = Grid_Manutenção100Horas.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_horimetro.Text = Grid_Manutenção100Horas.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_data_manutencao.Text = Grid_Manutenção100Horas.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_cpf_resp_tecnico.Text = Grid_Manutenção100Horas.Rows[e.RowIndex].Cells[6].Value.ToString();

            txt_id_manut_100_horas.Enabled = false;
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
        /// Método para carregar o DataGridView do formulário de cadastro da manutenção de 100 horas do equipamento.
        /// </summary>
        private void CarregarGrid()
        {
            Grid_Manutenção100Horas.DataSource = bll_100.SelecionaTodasManutencoes100Horas();

            Grid_Manutenção100Horas.Columns[0].HeaderText = "Código da Manutenção";
            Grid_Manutenção100Horas.Columns[1].HeaderText = "Código do Equipamento";
            Grid_Manutenção100Horas.Columns[2].HeaderText = "Monobloco";
            Grid_Manutenção100Horas.Columns[3].HeaderText = "Série";
            Grid_Manutenção100Horas.Columns[4].HeaderText = "Horímetro";
            Grid_Manutenção100Horas.Columns[5].HeaderText = "Data da Manutenção";
            Grid_Manutenção100Horas.Columns[6].HeaderText = "CPF do Responsável Técnico";

            for(int i = 0; i < 7; i++)
            {
                Grid_Manutenção100Horas.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid_Manutenção100Horas.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Grid_Manutenção100Horas.Columns[0].Width = 0;
            Grid_Manutenção100Horas.Columns[1].Width = 185;
            Grid_Manutenção100Horas.Columns[2].Width = 135;
            Grid_Manutenção100Horas.Columns[3].Width = 110;
            Grid_Manutenção100Horas.Columns[4].Width = 110;
            Grid_Manutenção100Horas.Columns[5].Width = 110;
            Grid_Manutenção100Horas.Columns[6].Width = 270;
        }

        /// <summary>
        /// Método para limpar os campos do formulário de cadastro da manutenção de 100 horas do equipamento.
        /// </summary>
        private void LimparTela()
        {
            txt_id_manut_100_horas.Clear();
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
        /// Evento para formatação da data da manutenção de 100 horas do equipamento.
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
        /// Evento para validação da data da manutenção de 100 horas do equipamento.
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
        /// Evento para vincular o CPF do responsável técnico de acordo com a seleção do combobox no formulário de cadastro da manutenção de 100 horas do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_fk_resp_tecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cpf_resp_tecnico.Text = cmb_fk_resp_tecnico.SelectedValue.ToString();
        }
    }
}
