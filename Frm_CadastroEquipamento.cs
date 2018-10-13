using System;
using System.Windows.Forms;
using Projeto3Camadas.Código.BLL;
using Projeto3Camadas.Código.DTO;

namespace Projeto3Camadas
{
    public partial class Frm_CadastroEquipamento : Form
    {
        /// <summary>
        /// Instância de outras classes do software.
        /// </summary>
        EquipamentoBLL bll = new EquipamentoBLL();
        EquipamentoDTO dto = new EquipamentoDTO();
        ProprietárioBLL bll_p = new ProprietárioBLL();
       
        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public Frm_CadastroEquipamento()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para carregamento do formulário de cadastro do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCadastro_Trator_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
            cmb_fk_proprietario.DataSource = bll_p.SelecionaTodosProprietarios();
            cmb_fk_proprietario.DisplayMember = "nome_razaosocial";
            cmb_fk_proprietario.ValueMember = "id_proprietario";
            CarregarGrid();
        }

        /// <summary>
        /// Evento do botão "Novo" do formulário de cadastro do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            LimparTela();   
            txt_monobloco.Enabled = true;
            txt_motor.Enabled = true;
            txt_serie.Enabled = true;
            txt_horimetro.Enabled = true;
            txt_monobloco.Focus();
        }

        /// <summary>
        /// Evento do botão "Gravar" do formulário de cadastro do equipamento. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            if (bll.CampoVazio(txt_monobloco))
                return;
            if (bll.CampoVazio(txt_motor))
                return;
            if (bll.CampoVazio(txt_serie))
                return;
            if (bll.CampoVazio(txt_horimetro))
                return;
            if (bll.CampoVazio(txt_nf_compra))
                return;
            if (bll.CampoVazio(cmb_fk_proprietario))
                return;

            dto.monobloco = txt_monobloco.Text;
            dto.motor = txt_motor.Text;
            dto.serie = txt_serie.Text;
            dto.horimetro = Convert.ToDecimal(txt_horimetro.Text);
            dto.nf_compra = txt_nf_compra.Text;
            dto.fk_proprietario = int.Parse(cmb_fk_proprietario.SelectedValue.ToString());

            var valor = dto.horimetro;

            if(valor > 0)
            {
                if (txt_id_equipamento.Text == "")
                {
                    if(txt_monobloco.TextLength == 15)
                    {
                        if(txt_motor.TextLength == 8)
                        {
                            if(txt_serie.TextLength == 10)
                            {
                                if(txt_nf_compra.TextLength == 6)
                                {
                                    bll.Inserir(dto);
                                    MessageBox.Show("Equipamento cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LimparTela();
                                    CarregarGrid();
                                    txt_monobloco.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("Digite 5 caracteres para a nota fiscal de compra!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txt_nf_compra.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Digite 10 caracteres para a série!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_serie.Focus();
                            }   
                        }
                        else
                        {
                            MessageBox.Show("Digite 8 caracteres para o motor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_motor.Focus();
                        }   
                    }
                    else
                    {
                        MessageBox.Show("Digite 15 caracteres para o monobloco!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_monobloco.Focus();
                    }
                }
                else
                {
                    dto.id_equipamento = int.Parse(txt_id_equipamento.Text);

                    if(txt_nf_compra.TextLength == 6)
                    {
                        bll.Atualizar(dto);
                        MessageBox.Show("Equipamento editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparTela();
                        CarregarGrid();
                        txt_monobloco.Enabled = true;
                        txt_motor.Enabled = true;
                        txt_serie.Enabled = true;
                        txt_horimetro.Enabled = true;
                        txt_monobloco.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Digite 5 caracteres para a nota fiscal de compra!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_nf_compra.Focus();
                    }   
                }
            }
            else
            {
                MessageBox.Show("O Horímetro deve conter pelo menos 1 hora de trabalho!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_horimetro.Clear();
                txt_horimetro.Focus();
            }
        }

        /// <summary>
        /// Evento do botão "Excluir" do formulário de cadastro do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (txt_id_equipamento.Text != "")
            {
                var resultado = MessageBox.Show("Você realmente deseja excluir o registro selecionado?", "Exclusão Equipamento?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    bll.ExcluirManut_100Horas(txt_id_equipamento.Text);
                    bll.ExcluirManut_500Horas(txt_id_equipamento.Text);
                    bll.ExcluirManut_1000Horas(txt_id_equipamento.Text);
                    bll.Excluir(txt_id_equipamento.Text);
                    MessageBox.Show("Equipamento excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTela();
                    CarregarGrid();
                    txt_monobloco.Enabled = true;
                    txt_motor.Enabled = true;
                    txt_serie.Enabled = true;
                    txt_horimetro.Enabled = true;
                    txt_monobloco.Focus();
                }
            }
        }

        /// <summary>
        /// Evento do botão "Sair" do formulário de cadastro do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento do botão "Pesquisar" do formulário de cadastro do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Grid_Equipamentos.DataSource = bll.PesquisaEquipamento(txt_pesquisar.Text);

            if(txt_pesquisar.Text == "")
            {
                MessageBox.Show("Digite o monobloco do equipamento!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Grid_Equipamentos.Columns[0].HeaderText = "Código do Equipamento";
                Grid_Equipamentos.Columns[1].HeaderText = "Monobloco";
                Grid_Equipamentos.Columns[2].HeaderText = "Motor";
                Grid_Equipamentos.Columns[3].HeaderText = "Série";
                Grid_Equipamentos.Columns[4].HeaderText = "Horímetro";
                Grid_Equipamentos.Columns[5].HeaderText = "Nota Fiscal de Compra";
                Grid_Equipamentos.Columns[6].HeaderText = "Proprietário";

                for (int i = 0; i < 7; i++)
                {
                    Grid_Equipamentos.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Grid_Equipamentos.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                Grid_Equipamentos.Columns[0].Width = 200;
                Grid_Equipamentos.Columns[1].Width = 190;
                Grid_Equipamentos.Columns[2].Width = 190;
                Grid_Equipamentos.Columns[3].Width = 190;
                Grid_Equipamentos.Columns[4].Width = 130;
                Grid_Equipamentos.Columns[5].Width = 200;
                Grid_Equipamentos.Columns[6].Width = 200;
            }
        }

        /// <summary>
        /// Evento do DataGridView do formulário de cadastro do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_Equipamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_equipamento.Text = Grid_Equipamentos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_monobloco.Text = Grid_Equipamentos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_motor.Text = Grid_Equipamentos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_serie.Text = Grid_Equipamentos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_horimetro.Text = Grid_Equipamentos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_nf_compra.Text = Grid_Equipamentos.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmb_fk_proprietario.Text = Grid_Equipamentos.Rows[e.RowIndex].Cells[6].Value.ToString();

            txt_monobloco.Enabled = false;
            txt_motor.Enabled = false;
            txt_serie.Enabled = false;
            txt_horimetro.Enabled = false;
        }

        /// <summary>
        /// Método para carregar o DataGridView do formulário de cadastro do equipamento.
        /// </summary>
        private void CarregarGrid()
        {
            Grid_Equipamentos.DataSource = bll.SelecionaTodosEquipamentos();

            Grid_Equipamentos.Columns[0].HeaderText = "Código do Equipamento";
            Grid_Equipamentos.Columns[1].HeaderText = "Monobloco";
            Grid_Equipamentos.Columns[2].HeaderText = "Motor";
            Grid_Equipamentos.Columns[3].HeaderText = "Série";
            Grid_Equipamentos.Columns[4].HeaderText = "Horímetro";
            Grid_Equipamentos.Columns[5].HeaderText = "Nota Fiscal de Compra";
            Grid_Equipamentos.Columns[6].HeaderText = "Proprietário";

            for (int i = 0; i < 7; i++)
            {
                Grid_Equipamentos.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid_Equipamentos.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Grid_Equipamentos.Columns[0].Width = 200;
            Grid_Equipamentos.Columns[1].Width = 190;
            Grid_Equipamentos.Columns[2].Width = 190;
            Grid_Equipamentos.Columns[3].Width = 190;
            Grid_Equipamentos.Columns[4].Width = 130;
            Grid_Equipamentos.Columns[5].Width = 200;
            Grid_Equipamentos.Columns[6].Width = 200;
        }

        /// <summary>
        /// Método para limpar os campos do formulário de cadastro do equipamento.
        /// </summary>
        private void LimparTela()
        {
            txt_id_equipamento.Clear();
            txt_monobloco.Clear();
            txt_motor.Clear();
            txt_serie.Clear();
            txt_horimetro.Clear();
            txt_nf_compra.Clear();
        }

        /// <summary>
        /// Evento para formatação do número da nota fiscal de compra do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_nf_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_nf_compra.TextLength)
                {
                    case 0:
                        txt_nf_compra.Text = "";
                        break;

                    case 4:
                        txt_nf_compra.Text = txt_nf_compra.Text + "-";
                        txt_nf_compra.SelectionStart = 6;
                        break;
                }
            }
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
        /// Evento para formatação do número do monobloco do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_monobloco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação do número do motor do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_motor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação do número de série do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_serie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
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
        /// Evento para validação do número do monobloco do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_monobloco_Leave(object sender, EventArgs e)
        {
            if (bll.VerificaMonobloco(txt_monobloco.Text) == false)
            {

            }
            else
            {
                MessageBox.Show("Monobloco já cadastrado para outro equipamento!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_monobloco.Clear();
                txt_monobloco.Focus();
            }
        }

        /// <summary>
        /// Evento para validação do número do motor do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_motor_Leave(object sender, EventArgs e)
        {
            if (bll.VerificaMotor(txt_motor.Text) == false)
            {

            }
            else
            {
                MessageBox.Show("Motor já cadastrado para outro equipamento!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_motor.Clear();
                txt_motor.Focus();
            }
        }

        /// <summary>
        /// Evento para validação do número de série do equipamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_serie_Leave(object sender, EventArgs e)
        {
            if (bll.VerificaSerie(txt_serie.Text) == false)
            {

            }
            else
            {
                MessageBox.Show("Série já cadastrada para outro equipamento!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_serie.Clear();
                txt_serie.Focus();
            }
        }

        /// <summary>
        /// Evento para mostrar a data e a hora no formulário de cadastro do equipamento.
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
