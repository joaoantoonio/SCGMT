using System;
using Projeto3Camadas.Código.DAL;
using Projeto3Camadas.Código.DTO;
using System.Data;
using System.Windows.Forms;

namespace Projeto3Camadas.Código.BLL
{
    // A classe foi criada para inserirmos nela os métodos e funções do objeto Responsável Técnico, os mesmos são usados no Frm_CadastroResponsávelTécnico.

    public class ResponsávelTécnicoBLL
    {
        /// <summary>
        /// Instância para acesso ao banco de dados.
        /// </summary>
        private Acesso_BD bd;

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public ResponsávelTécnicoBLL()
        {
            bd = null;
        }

        /// <summary>
        /// Função para inserção dos dados do responsável técnico no banco de dados.
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public bool Inserir(ResponsávelTécnicoDTO registro)
        {
            bool valorRetorno = false;

            try
            {
                string nome_resp_tecnico = registro.nome.Replace("'", "''");
                bd = new Acesso_BD();
                string comando = string.Format("INSERT INTO responsavel_tecnico(nome, cpf) VALUES ('{0}', '{1}')", registro.nome, registro.cpf);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao tentar gravar o responsável técnico!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Função para atualização dos dados do responsável técnico no banco de dados.
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public bool Atualizar(ResponsávelTécnicoDTO registro)
        {
            bool valorRetorno = false;

            try
            {
                string nome_resp_tecnico = registro.nome.Replace("'", "''");
                bd = new Acesso_BD();
                string comando = string.Format("UPDATE responsavel_tecnico SET nome = '{0}', cpf = '{1}' WHERE id_resp_tecnico = {2}", registro.nome, registro.cpf, registro.id_resp_tecnico);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar editar o responsável técnico!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Função para selecionar todos os dados dos responsáveis técnicos cadastrados no banco de dados.
        /// </summary>
        /// <returns></returns>
        public DataTable SelecionaTodosResponsaveisTecnicos()
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT id_resp_tecnico, nome, cpf FROM responsavel_tecnico");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar os responsáveis técnicos!" + ex.Message);
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
        /// Função para verificar se existe um determinado CPF já cadastrado.
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public bool VerificarCPF(string CPF)
        {
            bd = new Acesso_BD();
            string comando = string.Format("SELECT cpf FROM responsavel_tecnico WHERE cpf = '{0}'", CPF);
            var retorno = bd.RetDataTable(comando);
            if (retorno != null && retorno.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Função para pesquisa do responsável técnico.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public DataTable PesquisaResponsavelTecnico(string nome)
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT id_resp_tecnico, nome, cpf FROM responsavel_tecnico WHERE nome LIKE '%" + nome + "%'");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar pesquisar o nome do responsável técnico!" + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }

        /// <summary>
        /// Função para validar o CPF do responsável técnico.
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
