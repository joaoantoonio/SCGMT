using System;
using Projeto3Camadas.Código.DTO;
using Projeto3Camadas.Código.DAL;
using System.Data;
using System.Windows.Forms;

namespace Projeto3Camadas.Código.BLL
{
    // A classe foi criada para inserirmos nela os métodos e funções do objeto Equipamento, os mesmos são usados no Frm_CadastroEquipamento.

    public class EquipamentoBLL
    {
        /// <summary>
        /// Instância para acesso ao banco de dados.
        /// </summary>
        Acesso_BD bd;

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public EquipamentoBLL()
        {
            bd = null;
        }

        /// <summary>
        /// Função para inserção dos dados do equipamento no banco de dados.
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public bool Inserir(EquipamentoDTO registro)
        {
            bool valorRetorno = false;

            try
            {
                bd = new Acesso_BD();
                string comando = string.Format("INSERT INTO equipamento(monobloco, motor, serie, horimetro, nf_compra, fk_proprietario) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5})", registro.monobloco, registro.motor, registro.serie, registro.horimetro, registro.nf_compra, registro.fk_proprietario);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao tentar gravar o equipamento!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Função para atualização dos dados do equipamento no banco de dados.
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public bool Atualizar(EquipamentoDTO registro)
        {
            bool valorRetorno = false;

            try
            {
                bd = new Acesso_BD();
                string comando = string.Format("UPDATE equipamento SET monobloco = '{0}', motor = '{1}', serie = '{2}', horimetro = '{3}', nf_compra = '{4}', fk_proprietario = {5} WHERE id_equipamento = {6} ", registro.monobloco, registro.motor, registro.serie, registro.horimetro, registro.nf_compra, registro.fk_proprietario, registro.id_equipamento);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar editar o equipamento!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Função para exclusão dos dados do equipamento no banco de dados.
        /// </summary>
        /// <param name="idEquipamento"></param>
        /// <returns></returns>
        public bool Excluir(string idEquipamento)
        {
            bool valorRetorno = false;

            try
            {
                bd = new Acesso_BD();
                string comando = string.Format("DELETE FROM equipamento WHERE id_equipamento = {0}", idEquipamento);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao tentar excluir o equipamento!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Função para selecionar todos os dados dos equipamentos cadastrados no banco de dados.
        /// </summary>
        /// <returns></returns>
        public DataTable SelecionaTodosEquipamentos()
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT E.id_equipamento, E.monobloco, E.motor, E.serie, E.horimetro, E.nf_compra, P.nome_razaosocial FROM equipamento AS E INNER JOIN proprietario AS P WHERE E.fk_proprietario = P.id_proprietario");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar os equipamentos!" + ex.Message);
            }
            finally
            {

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
        /// Função para verificar se existe um determinado Monobloco já cadastrado.
        /// </summary>
        /// <param name="monobloco"></param>
        /// <returns></returns>
        public bool VerificaMonobloco(string monobloco)
        {
            bd = new Acesso_BD();
            string comando = string.Format("SELECT monobloco FROM equipamento WHERE monobloco = '{0}'", monobloco);
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
        /// Função para verificar se existe um determinado Motor já cadastrado.
        /// </summary>
        /// <param name="motor"></param>
        /// <returns></returns>
        public bool VerificaMotor(string motor)
        {
            bd = new Acesso_BD();
            string comando = string.Format("SELECT motor FROM equipamento WHERE motor = '{0}'", motor);
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
        /// Função para verificar se existe uma determinada Série já cadastrada.
        /// </summary>
        /// <param name="serie"></param>
        /// <returns></returns>
        public bool VerificaSerie(string serie)
        {
            bd = new Acesso_BD();
            string comando = string.Format("SELECT serie FROM equipamento WHERE serie = '{0}'", serie);
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
        /// Função para pesquisa do equipamento.
        /// </summary>
        /// <param name="monobloco"></param>
        /// <returns></returns>
        public DataTable PesquisaEquipamento(string monobloco)
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT E.id_equipamento, E.monobloco, E.motor, E.serie, E.horimetro, E.nf_compra, P.nome_razaosocial FROM equipamento AS E INNER JOIN proprietario AS P WHERE E.fk_proprietario = P.id_proprietario AND monobloco LIKE '%" + monobloco + "%'");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar pesquisar o monobloco do equipamento!" + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }

        /// <summary>
        /// Função para excluir a manutenção de 100 horas do equipamento no banco de dados.
        /// </summary>
        /// <param name="idEquipamento"></param>
        /// <returns></returns>
        public bool ExcluirManut_100Horas(string idEquipamento)
        {
            bool valorRetorno = false;

            try
            {
                bd = new Acesso_BD();
                string comando = string.Format("DELETE FROM manut_100_horas WHERE 100_fk_equipamento = {0}", idEquipamento);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir a manutenção de 100 horas do equipamento!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Função para excluir a manutenção de 500 horas do equipamento no banco de dados.
        /// </summary>
        /// <param name="idEquipamento"></param>
        /// <returns></returns>
        public bool ExcluirManut_500Horas(string idEquipamento)
        {
            bool valorRetorno = false;

            try
            {
                bd = new Acesso_BD();
                string comando = string.Format("DELETE FROM manut_500_horas WHERE 500_fk_equipamento = {0}", idEquipamento);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir a manutenção de 500 horas do equipamento!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Função para excluir a manutenção de 1000 horas do equipamento no banco de dados.
        /// </summary>
        /// <param name="idEquipamento"></param>
        /// <returns></returns>
        public bool ExcluirManut_1000Horas(string idEquipamento)
        {
            bool valorRetorno = false;

            try
            {
                bd = new Acesso_BD();
                string comando = string.Format("DELETE FROM manut_1000_horas WHERE 1000_fk_equipamento = {0}", idEquipamento);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir a manutenção de 1000 horas do equipamento!!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }
    }
}
