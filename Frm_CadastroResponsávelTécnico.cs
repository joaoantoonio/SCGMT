using System;
using System.Windows.Forms;
using Projeto3Camadas.Código.BLL;
using Projeto3Camadas.Código.DTO;

namespace Projeto3Camadas
{
    public partial class Frm_CadastroResponsávelTécnico : Form
    {
        /// <summary>
        /// Instância de outras classes do software.
        /// </summary>
        ResponsávelTécnicoBLL bll = new ResponsávelTécnicoBLL();
        ResponsávelTécnicoDTO dto = new ResponsávelTécnicoDTO();

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public Frm_CadastroResponsávelTécnico()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para carregamento do formulário de cadastro do responsável técnico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCadastro_ResponsávelTécnico_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
            CarregarGrid();
        }

        /// <summary>
        /// Evento do botão "Novo" do formulário de cadastro do responsável técnico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            LimparTela();
            txt_nome.Enabled = true;
            txt_cpf.Enabled = true;
            btn_Inserir.Enabled = true;
            txt_nome.Focus();
        }

        /// <summary>
        /// Evento do botão "Gravar" do formulário de cadastro do responsável técnico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            if (bll.CampoVazio(txt_nome))
                return;
            if (bll.CampoVazio(txt_cpf))
                return;

            dto.nome = txt_nome.Text;
            dto.cpf = txt_cpf.Text;

            string valor = dto.cpf;

            if (txt_id_resp_tecnico.Text == "")
            {
                if (bll.VerificarCPF(txt_cpf.Text) == false)
                {
                    if (txt_cpf.TextLength == 14)
                    {
                        if(txt_cpf.Text != "000.000.000-00" && txt_cpf.Text != "111.111.111-11" && txt_cpf.Text != "222.222.222-22" && txt_cpf.Text != "333.333.333-33" && txt_cpf.Text != "444.444.444-44" && txt_cpf.Text != "555.555.555-55" && txt_cpf.Text != "666.666.666-66" && txt_cpf.Text != "777.777.777-77" && txt_cpf.Text != "888.888.888-88" && txt_cpf.Text != "999.999.999-99")
                        {
                            if (bll.Validar_CPF(valor))
                            {
                                bll.Inserir(dto);
                                MessageBox.Show("Responsável Técnico cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimparTela();
                                CarregarGrid();
                                txt_nome.Focus();
                            }
                            else
                            {
                                MessageBox.Show("CPF Inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_cpf.Clear();
                                txt_cpf.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("CPF Inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_cpf.Clear();
                            txt_cpf.Focus();
                        }   
                    }
                    else
                    {
                        MessageBox.Show("Digite 11 caracteres para o CPF!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_cpf.Clear();
                        txt_cpf.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("CPF já cadastrado para outro responsável técnico!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cpf.Clear();
                    txt_cpf.Focus();
                }
            }
            else
            {
                dto.id_resp_tecnico = int.Parse(txt_id_resp_tecnico.Text);
                bll.Atualizar(dto);
                MessageBox.Show("Responsável Técnico editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTela();
                CarregarGrid();
                txt_nome.Focus();
            }
        }

        /// <summary>
        /// Evento do botão "Sair" do formulário de cadastro do responsável técnico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento do botão "Pesquisar" do formulário de cadastro do responsável técnico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Grid_ResponsáveisTécnicos.DataSource = bll.PesquisaResponsavelTecnico(txt_pesquisar.Text);

            if(txt_pesquisar.Text == "")
            {
                MessageBox.Show("Digite o nome do responsável técnico!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Grid_ResponsáveisTécnicos.Columns[0].HeaderText = "Código do Responsável Técnico";
                Grid_ResponsáveisTécnicos.Columns[1].HeaderText = "Nome";
                Grid_ResponsáveisTécnicos.Columns[2].HeaderText = "CPF";

                for (int i = 0; i < 3; i++)
                {
                    Grid_ResponsáveisTécnicos.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Grid_ResponsáveisTécnicos.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                Grid_ResponsáveisTécnicos.Columns[0].Width = 450;
                Grid_ResponsáveisTécnicos.Columns[1].Width = 450;
                Grid_ResponsáveisTécnicos.Columns[2].Width = 400;
            }
        }

        /// <summary>
        /// Evento do DataGridView do formulário de cadastro do responsável técnico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_ResponsáveisTécnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_resp_tecnico.Text = Grid_ResponsáveisTécnicos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = Grid_ResponsáveisTécnicos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_cpf.Text = Grid_ResponsáveisTécnicos.Rows[e.RowIndex].Cells[2].Value.ToString();

            txt_nome.Enabled = false;
            txt_cpf.Enabled = false;
            btn_Inserir.Enabled = false;
        }

        /// <summary>
        /// Método para carregar o DataGridView do formulário de cadastro do responsável técnico.
        /// </summary>
        private void CarregarGrid()
        {
            Grid_ResponsáveisTécnicos.DataSource = bll.SelecionaTodosResponsaveisTecnicos();

            Grid_ResponsáveisTécnicos.Columns[0].HeaderText = "Código do Responsável Técnico";
            Grid_ResponsáveisTécnicos.Columns[1].HeaderText = "Nome";
            Grid_ResponsáveisTécnicos.Columns[2].HeaderText = "CPF";

            for (int i = 0; i < 3; i++)
            {
                Grid_ResponsáveisTécnicos.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid_ResponsáveisTécnicos.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Grid_ResponsáveisTécnicos.Columns[0].Width = 450;
            Grid_ResponsáveisTécnicos.Columns[1].Width = 450;
            Grid_ResponsáveisTécnicos.Columns[2].Width = 400;
        }

        /// <summary>
        /// Método para limpar os campos do formulário de cadastro do responsável técnico.
        /// </summary>
        public void LimparTela()
        {
            txt_id_resp_tecnico.Clear();
            txt_nome.Clear();
            txt_cpf.Clear();
        }

        /// <summary>
        /// Evento para formatação do número do CPF no formulário de cadastro do responsável técnico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_cpf.TextLength)
                {
                    case 0:
                        txt_cpf.Text = "";
                        break;

                    case 3:
                        txt_cpf.Text = txt_cpf.Text + ".";
                        txt_cpf.SelectionStart = 5;
                        break;

                    case 7:
                        txt_cpf.Text = txt_cpf.Text + ".";
                        txt_cpf.SelectionStart = 9;
                        break;

                    case 11:
                        txt_cpf.Text = txt_cpf.Text + "-";
                        txt_cpf.SelectionStart = 13;
                        break;
                }
            }
        }

        /// <summary>
        /// Evento para formatação do nome no formulário de cadastro do responsável técnico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação do nome no formulário de cadastro do responsável técnico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_pesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para validação do número do CPF do responsável técnico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_cpf_Leave(object sender, EventArgs e)
        {
            if (bll.VerificarCPF(txt_cpf.Text) == false)
            {

            }
            else
            {
                MessageBox.Show("CPF já cadastrado para outro responsável técnico!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cpf.Clear();
                txt_cpf.Focus();
            }
        }

        /// <summary>
        /// Evento para mostrar a data e a hora no formulário de cadastro do responsável técnico.
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
