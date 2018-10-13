using System;
using System.Windows.Forms;
using Projeto3Camadas.Código.BLL;
using Projeto3Camadas.Código.DTO;

namespace Projeto3Camadas
{
    public partial class Frm_CadastroProprietário : Form
    {
        /// <summary>
        /// Instância de outras classes do software.
        /// </summary>
        ProprietárioBLL bll = new ProprietárioBLL();
        ProprietárioDTO dto = new ProprietárioDTO();

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public Frm_CadastroProprietário()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para carregamento do formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCadastro_Proprietário_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
            cmb_estado.DataSource = bll.SelecionaTodosEstadosUF();
            cmb_uf_municipio_fazenda.DataSource = bll.SelecionaTodosEstadosUF();
            cmb_estado.DisplayMember = "nome";
            cmb_uf_municipio_fazenda.DisplayMember = "uf";
            CarregarGrid();
        }

        /// <summary>
        /// Evento do botão "Novo" do formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            LimparTela();
            txt_cpf_cnpj.Enabled = true;
            txt_cpf_cnpj.Focus();
        }

        /// <summary>
        /// Evento do botão "Gravar" do formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            if (bll.CampoVazio(txt_cpf_cnpj))
                return;
            if (bll.CampoVazio(txt_nome_razaosocial))
                return;
            if (bll.CampoVazio(txt_endereco))
                return;
            if (bll.CampoVazio(txt_numero))
                return;
            if (bll.CampoVazio(txt_bairro))
                return;
            if (bll.CampoVazio(txt_cep))
                return;
            if (bll.CampoVazio(txt_cidade))
                return;
            if (bll.CampoVazio(cmb_estado))
                return;
            if (bll.CampoVazio(txt_telefone))
                return;
            if (bll.CampoVazio(txt_email))
                return;
            if (bll.CampoVazio(txt_nome_fazenda))
                return;
            if (bll.CampoVazio(txt_municipio_fazenda))
                return;
            if (bll.CampoVazio(cmb_uf_municipio_fazenda))
                return;

            dto.cpf_cnpj = txt_cpf_cnpj.Text;
            dto.nome_razaosocial = txt_nome_razaosocial.Text;
            dto.endereco = txt_endereco.Text;
            dto.numero = txt_numero.Text;
            dto.bairro = txt_bairro.Text;
            dto.cep = txt_cep.Text;
            dto.cidade = txt_cidade.Text;
            dto.estado = cmb_estado.Text;
            dto.telefone = txt_telefone.Text;
            dto.email = txt_email.Text;
            dto.nome_fazenda = txt_nome_fazenda.Text;
            dto.municipio_fazenda = txt_municipio_fazenda.Text;
            dto.uf_municipio_fazenda = cmb_uf_municipio_fazenda.Text;

            string valor = dto.cpf_cnpj;

            if (txt_id_proprietario.Text == "")
            {
                if (bll.VerificarCNPJ_CPF(txt_cpf_cnpj.Text) == false)
                {
                    if (txt_cpf_cnpj.TextLength == 14 || txt_cpf_cnpj.TextLength == 18)
                    {
                        if (txt_cep.TextLength == 9)
                        {
                            if(txt_telefone.TextLength == 13)
                            {
                                if(txt_cpf_cnpj.Text != "000.000.000-00" && txt_cpf_cnpj.Text != "111.111.111-11" && txt_cpf_cnpj.Text != "222.222.222-22" && txt_cpf_cnpj.Text != "333.333.333-33" && txt_cpf_cnpj.Text != "444.444.444-44" && txt_cpf_cnpj.Text != "555.555.555-55" && txt_cpf_cnpj.Text != "666.666.666-66" && txt_cpf_cnpj.Text != "777.777.777-77" && txt_cpf_cnpj.Text != "888.888.888-88" && txt_cpf_cnpj.Text != "999.999.999-99")
                                {
                                    if (bll.Validar_CPF(valor) || bll.Validar_CNPJ(valor))
                                    {
                                        bll.Inserir(dto);
                                        MessageBox.Show("Proprietário cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        LimparTela();
                                        CarregarGrid();
                                        txt_cpf_cnpj.Focus();
                                    }
                                    else
                                    {
                                        MessageBox.Show("CPF ou CNPJ Inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txt_cpf_cnpj.Clear();
                                        txt_cpf_cnpj.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("CPF ou CNPJ Inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txt_cpf_cnpj.Clear();
                                    txt_cpf_cnpj.Focus();
                                }      
                            }
                            else
                            {
                                MessageBox.Show("Digite 11 caracteres para o número do telefone celular!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_telefone.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite 8 caracteres para o CEP!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_cep.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite 11 caracteres para o CPF ou 14 para o CNPJ!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_cpf_cnpj.Clear();
                        txt_cpf_cnpj.Focus();
                    }                   
                }
                else
                {
                    MessageBox.Show("CPF ou CNPJ já cadastrado para outro proprietário!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cpf_cnpj.Clear();
                    txt_cpf_cnpj.Focus();
                }
            }
            else
            {
                dto.id_proprietario = int.Parse(txt_id_proprietario.Text);

                if (txt_cep.TextLength == 9)
                {
                    if(txt_telefone.TextLength == 13)
                    {
                        bll.Atualizar(dto);
                        MessageBox.Show("Proprietário editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparTela();
                        CarregarGrid();
                        txt_cpf_cnpj.Enabled = true;
                        txt_cpf_cnpj.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Digite 11 caracteres para o número do telefone celular!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_telefone.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Digite 8 caracteres para o CEP!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cep.Focus();
                }
            }
        }

        /// <summary>
        /// Evento do botão "Sair" do formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento do botão "Cadastrar Equipamento" do formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cadastrar_equipamento_Click(object sender, EventArgs e)
        {
            Frm_CadastroEquipamento frm_cadastro_equipamento = new Frm_CadastroEquipamento();
            frm_cadastro_equipamento.ShowDialog();
        }

        /// <summary>
        /// Evento do botão "Pesquisar" do formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Grid_Proprietários.DataSource = bll.PesquisaProprietario(txt_pesquisar.Text);

            if(txt_pesquisar.Text == "")
            {
                MessageBox.Show("Digite o nome do proprietário!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Grid_Proprietários.Columns[0].HeaderText = "Código do Proprietário";
                Grid_Proprietários.Columns[1].HeaderText = "CPF/CNPJ";
                Grid_Proprietários.Columns[2].HeaderText = "Nome/Razão Social";
                Grid_Proprietários.Columns[3].HeaderText = "Endereço";
                Grid_Proprietários.Columns[4].HeaderText = "Número";
                Grid_Proprietários.Columns[5].HeaderText = "Bairro";
                Grid_Proprietários.Columns[6].HeaderText = "CEP";
                Grid_Proprietários.Columns[7].HeaderText = "Cidade";
                Grid_Proprietários.Columns[8].HeaderText = "Estado";
                Grid_Proprietários.Columns[9].HeaderText = "Telefone";
                Grid_Proprietários.Columns[10].HeaderText = "E-mail";
                Grid_Proprietários.Columns[11].HeaderText = "Nome da Propriedade";
                Grid_Proprietários.Columns[12].HeaderText = "Município";
                Grid_Proprietários.Columns[13].HeaderText = "UF";

                for (int i = 0; i < 14; i++)
                {
                    Grid_Proprietários.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Grid_Proprietários.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                Grid_Proprietários.Columns[0].Width = 70;
                Grid_Proprietários.Columns[4].Width = 70;
                Grid_Proprietários.Columns[6].Width = 70;
                Grid_Proprietários.Columns[8].Width = 70;
                Grid_Proprietários.Columns[11].Width = 150;
                Grid_Proprietários.Columns[13].Width = 65;
            }   
        }

        /// <summary>
        /// Evento do DataGridView do formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_Proprietários_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_proprietario.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_cpf_cnpj.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_nome_razaosocial.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_endereco.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_numero.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_bairro.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_cep.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_cidade.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmb_estado.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_telefone.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_email.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_nome_fazenda.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[11].Value.ToString();
            txt_municipio_fazenda.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[12].Value.ToString();
            cmb_uf_municipio_fazenda.Text = Grid_Proprietários.Rows[e.RowIndex].Cells[13].Value.ToString();

            txt_cpf_cnpj.Enabled = false;
        }

        /// <summary>
        /// Método para carregar o DataGridView do formulário de cadastro do proprietário.
        /// </summary>
        private void CarregarGrid()
        {
            Grid_Proprietários.DataSource = bll.SelecionaTodosProprietarios();

            Grid_Proprietários.Columns[0].HeaderText = "Código do Proprietário";
            Grid_Proprietários.Columns[1].HeaderText = "CPF/CNPJ";
            Grid_Proprietários.Columns[2].HeaderText = "Nome/Razão Social";
            Grid_Proprietários.Columns[3].HeaderText = "Endereço";
            Grid_Proprietários.Columns[4].HeaderText = "Número";
            Grid_Proprietários.Columns[5].HeaderText = "Bairro";
            Grid_Proprietários.Columns[6].HeaderText = "CEP";
            Grid_Proprietários.Columns[7].HeaderText = "Cidade";
            Grid_Proprietários.Columns[8].HeaderText = "Estado";
            Grid_Proprietários.Columns[9].HeaderText = "Telefone";
            Grid_Proprietários.Columns[10].HeaderText = "E-mail";
            Grid_Proprietários.Columns[11].HeaderText = "Nome da Propriedade";
            Grid_Proprietários.Columns[12].HeaderText = "Município";
            Grid_Proprietários.Columns[13].HeaderText = "UF";

           for (int i = 0; i < 14; i++)
           {
                Grid_Proprietários.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid_Proprietários.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           }

            Grid_Proprietários.Columns[0].Width = 70;
            Grid_Proprietários.Columns[4].Width = 70;
            Grid_Proprietários.Columns[6].Width = 70;
            Grid_Proprietários.Columns[8].Width = 70;
            Grid_Proprietários.Columns[11].Width = 150;
            Grid_Proprietários.Columns[13].Width = 65;    
        }

        /// <summary>
        /// Método para limpar os campos do formulário de cadastro do proprietário.
        /// </summary>
        private void LimparTela()
        {
            txt_id_proprietario.Clear();
            txt_cpf_cnpj.Clear();
            txt_nome_razaosocial.Clear();
            txt_endereco.Clear();
            txt_numero.Clear();
            txt_bairro.Clear();
            txt_cep.Clear();
            txt_cidade.Clear();
            txt_telefone.Clear();
            txt_email.Clear();
            txt_nome_fazenda.Clear();
            txt_municipio_fazenda.Clear();
        }

        /// <summary>
        /// Evento para formatação do número do CEP no formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_cep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_cep.TextLength)
                {
                    case 0:
                        txt_cep.Text = "";
                        break;

                    case 5:
                        txt_cep.Text = txt_cep.Text + "-";
                        txt_cep.SelectionStart = 7;
                        break;
                }
            }
        }

        /// <summary>
        /// Evento para formatação do número do telefone celular no formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_telefone.TextLength)
                {
                    case 0:
                        txt_telefone.Text = "";
                        break;

                    case 2:
                        txt_telefone.Text = txt_telefone.Text + " ";
                        txt_telefone.SelectionStart = 4;
                        break;

                    case 8:
                        txt_telefone.Text = txt_telefone.Text + "-";
                        txt_telefone.SelectionStart = 10;
                        break;
                }
            }
        }

        /// <summary>
        /// Evento para formatação do número do CPF/CNPJ no formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_cpf_cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação do nome/razão social no formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_nome_razaosocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação do endereço no formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_endereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação do número da residência no formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação do nome do bairro no formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_bairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação do nome da cidade no formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_cidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação do nome da propriedade no formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_nome_fazenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação do nome do municipio da propriedade no formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_municipio_fazenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação do email no formulário de cadastro do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento para formatação do nome/razão social no formulário de cadastro do proprietário.
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
        /// Evento para validação do número do CPF/CNPJ do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_cpf_cnpj_Leave(object sender, EventArgs e)
        {
            if (bll.VerificarCNPJ_CPF(txt_cpf_cnpj.Text) == false)
            {

            }
            else
            {
                MessageBox.Show("CPF ou CNPJ já cadastrado para outro proprietário!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cpf_cnpj.Clear();
                txt_cpf_cnpj.Focus();
            }
        }

        /// <summary>
        /// Evento para validação e formatação do número do CPF/CNPJ do proprietário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_cpf_cnpj_Validated(object sender, EventArgs e)
        {
            txt_cpf_cnpj.Text = bll.MascaraCNPJCPF(txt_cpf_cnpj.Text);

            if (bll.VerificarCNPJ_CPF(txt_cpf_cnpj.Text) == false)
            {

            }
            else
            {
                MessageBox.Show("CPF ou CNPJ já cadastrado para outro proprietário!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cpf_cnpj.Clear();
                txt_cpf_cnpj.Focus();
            }
        }

        /// <summary>
        /// Evento para mostrar a data e a hora no formulário de cadastro do proprietário.
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
