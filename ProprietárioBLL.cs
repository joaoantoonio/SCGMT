using System;
using Projeto3Camadas.Código.DTO;
using Projeto3Camadas.Código.DAL;
using System.Data;
using System.Windows.Forms;

namespace Projeto3Camadas.Código.BLL
{
    // A classe foi criada para inserirmos nela os métodos e funções do objeto Proprietário, os mesmos são usados no Frm_CadastroProprietário.

    public class ProprietárioBLL
    {
        /// <summary>
        /// Instância para acesso ao banco de dados.
        /// </summary>
        private Acesso_BD bd;

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public ProprietárioBLL()
        {
            bd = null;
        }

        /// <summary>
        /// Função para inserção dos dados do proprietário no banco de dados.
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public bool Inserir(ProprietárioDTO registro)
        {
            bool valorRetorno = false;

            try
            {
                bd = new Acesso_BD();
                string comando = string.Format("INSERT INTO proprietario(cpf_cnpj, nome_razaosocial, endereco," +
                                 "numero, bairro, cep, cidade, estado, telefone, email, nome_fazenda, municipio_fazenda," +
                                 "uf_municipio_fazenda) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')", registro.cpf_cnpj, registro.nome_razaosocial, registro.endereco, registro.numero, registro.bairro, registro.cep, registro.cidade, registro.estado, registro.telefone, registro.email, registro.nome_fazenda, registro.municipio_fazenda, registro.uf_municipio_fazenda);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar gravar o proprietário!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Função para atualização dos dados do proprietário no banco de dados.
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public bool Atualizar(ProprietárioDTO registro)
        {
            bool valorRetorno = false;

            try
            {
                bd = new Acesso_BD();
                string comando = string.Format("UPDATE proprietario SET cpf_cnpj = '{0}', nome_razaosocial = '{1}', endereco = '{2}', numero = '{3}', bairro = '{4}', cep = '{5}', cidade = '{6}', estado = '{7}', telefone = '{8}', email = '{9}', nome_fazenda = '{10}', municipio_fazenda = '{11}', uf_municipio_fazenda = '{12}' WHERE id_proprietario = {13}", registro.cpf_cnpj, registro.nome_razaosocial, registro.endereco, registro.numero, registro.bairro, registro.cep, registro.cidade, registro.estado, registro.telefone, registro.email, registro.nome_fazenda, registro.municipio_fazenda, registro.uf_municipio_fazenda, registro.id_proprietario);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar editar o proprietário!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Função para selecionar todos os dados dos proprietários cadastrados no banco de dados.
        /// </summary>
        /// <returns></returns>
        public DataTable SelecionaTodosProprietarios()
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT id_proprietario, cpf_cnpj, nome_razaosocial, endereco, numero, bairro, cep," +
                                     "cidade, estado, telefone, email, nome_fazenda, municipio_fazenda," +
                                     "uf_municipio_fazenda FROM proprietario");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar os proprietários!" + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }

        /// <summary>
        /// Função para verificar se todos os campos do formulário foram preenchidos.
        /// </summary>
        /// <param name="controle"></param>
        /// <returns></returns>
        public bool CampoVazio(Control controle)
        {
            if (controle.Text == "")
            {
                MessageBox.Show("É obrigatório o preenchimento de todos os campos do formulário!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                controle.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Função para selecionar o nome dos estados e suas siglas.
        /// </summary>
        /// <returns></returns>
        public DataTable SelecionaTodosEstadosUF()
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT nome, uf FROM estados");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar os estados e suas siglas!" + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }

        /// <summary>
        /// Função para máscara de CPF e CNPJ.
        /// </summary>
        /// <param name="CNPJ_CPF"></param>
        /// <returns></returns>
        public string MascaraCNPJCPF(string CNPJ_CPF)
        {
            string resultado = "";

            if (CNPJ_CPF.Length == 14)
            {
                resultado = CNPJ_CPF.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
            }
            if (CNPJ_CPF.Length == 11)
            {
                resultado = CNPJ_CPF.Insert(3, ".").Insert(7, ".").Insert(11, "-");
            }
            if ((CNPJ_CPF.Length != 11) && (CNPJ_CPF.Length != 14))
            {
                resultado = CNPJ_CPF;
            }

            return resultado;
        }

        /// <summary>
        /// Função para verificar se existe um determinado CPF ou CNPJ já cadastrado.
        /// </summary>
        /// <param name="CNPJ_CPF"></param>
        /// <returns></returns>
        public bool VerificarCNPJ_CPF(string CNPJ_CPF)
        {
            bd = new Acesso_BD();
            string comando = string.Format("SELECT cpf_cnpj FROM proprietario WHERE cpf_cnpj = '{0}'", CNPJ_CPF);
            var retorno = bd.RetDataTable(comando);    
            if(retorno != null && retorno.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Função para pesquisa do proprietário.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public DataTable PesquisaProprietario(string nome)
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT id_proprietario, cpf_cnpj, nome_razaosocial, endereco, numero, bairro, cep," +
                                     "cidade,estado, telefone, email, nome_fazenda, municipio_fazenda," +
                                     "uf_municipio_fazenda FROM proprietario WHERE nome_razaosocial LIKE '%" + nome + "%'");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar pesquisar o nome do proprietário!" + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }

        /// <summary>
        /// Função para validar o CNPJ do proprietário.
        /// </summary>
        /// <param name="CNPJ"></param>
        /// <returns></returns>
        public bool Validar_CNPJ(string CNPJ)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            if (CNPJ.Length == 18)
            {
                CNPJ = CNPJ.Trim();
                CNPJ = CNPJ.Replace(".", "").Replace("-", "").Replace("/", "");
                tempCnpj = CNPJ.Substring(0, 12);
                soma = 0;

                for (int i = 0; i < 12; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

                resto = (soma % 11);

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = resto.ToString();
                tempCnpj = tempCnpj + digito;
                soma = 0;

                for (int i = 0; i < 13; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

                resto = (soma % 11);

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = digito + resto.ToString();

                return CNPJ.EndsWith(digito);
            }

            return false;            
        }

        /// <summary>
        /// Função para validar o CPF do proprietário.
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public bool Validar_CPF(string CPF)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCpf;

            if (CPF.Length == 14)
            {
                CPF = CPF.Trim();
                CPF = CPF.Replace(".", "").Replace("-", "");
                tempCpf = CPF.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

                resto = (soma % 11);

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;

                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

                resto = (soma % 11);

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = digito + resto.ToString();

                return CPF.EndsWith(digito);
            }

            return false;
        }
    }
}
