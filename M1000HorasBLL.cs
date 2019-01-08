using System;
using Projeto3Camadas.Código.DAL;
using Projeto3Camadas.Código.DTO;
using System.Data;
using System.Windows.Forms;

namespace Projeto3Camadas.Código.BLL
{
    // A classe foi criada para inserirmos nela os métodos e funções do objeto Manutenção de 1000 Horas, os mesmos são usados no Frm_Manutenção1000Horas.

    public class M1000HorasBLL
    {
        /// <summary>
        /// Instância para acesso ao banco de dados.
        /// </summary>
        private Acesso_BD bd;

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public M1000HorasBLL()
        {
            bd = null;
        }

        /// <summary>
        /// Função para inserção dos dados da manutenção de 1000 horas do equipamento no banco de dados.
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public bool Inserir(M1000HorasDTO registro)
        {
            bool valorRetorno = false;

            try
            {
                bd = new Acesso_BD();
                string comando = string.Format("INSERT INTO manut_1000_horas(1000_fk_equipamento, horimetro, data_manutencao, cpf_resp_tecnico) VALUES ({0}, {1}, '{2}', '{3}')", registro.fk_equipamento, registro.horimetro, registro.data_manutencao.ToString("yyyy-MM-dd"), registro.cpf_resp_tecnico);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar gravar a manutenção de 1000 horas do equipamento!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Função para atualização dos dados da manutenção de 1000 horas do equipamento no banco de dados.
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public bool Atualizar(M1000HorasDTO registro)
        {
            bool valorRetorno = false;

            try
            {
                bd = new Acesso_BD();
                string comando = string.Format("UPDATE manut_1000_horas SET horimetro = {0}, data_manutencao = '{1}', 1000_fk_resp_tecnico = {2}, cpf_resp_tecnico = '{3}' WHERE id_manut_1000_horas = {4}", registro.horimetro, registro.data_manutencao.ToString("yyyy-MM-dd"), registro.fk_resp_tecnico, registro.cpf_resp_tecnico, registro.id_manut_1000_horas);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar editar a manutenção de 1000 horas do equipamento!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Função para exclusão dos dados da manutenção de 1000 horas do equipamento no banco de dados.
        /// </summary>
        /// <param name="idManut1000Horas"></param>
        /// <returns></returns>
        public bool Excluir(string idManut1000Horas)
        {
            bool valorRetorno = false;

            try
            {
                bd = new Acesso_BD();
                string comando = string.Format("DELETE FROM manut_1000_horas WHERE id_manut_1000_horas = {0}", idManut1000Horas);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir a manutenção de 1000 horas do equipamento!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Função para selecionar todos os dados das manutenções de 1000 horas dos equipamentos cadastrados no banco de dados.
        /// </summary>
        /// <returns></returns>
        public DataTable SelecionaTodasManutencoes1000Horas()
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT M.id_manut_1000_horas, E.id_equipamento, E.monobloco, E.serie, M.horimetro, (SELECT DATE_FORMAT(M.data_manutencao,'%d/%c/%Y')), M.cpf_resp_tecnico FROM equipamento AS E INNER JOIN manut_1000_horas AS M WHERE E.id_equipamento = M.1000_fk_equipamento");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar as manutenções de 1000 horas!" + ex.Message);
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
        /// Função para atualizar o horímetro do equipamento caso a manutenção de 1000 horas seja excluída no banco de dados.
        /// </summary>
        /// <param name="horimetro"></param>
        /// <param name="fk_equipamento"></param>
        /// <returns></returns>
        public bool AtualizarHorimetro1000Horas(decimal horimetro, int fk_equipamento)
        {
            bool valorRetorno = false;

            try
            {
                bd = new Acesso_BD();
                string comando = string.Format("UPDATE equipamento SET horimetro = '{0}' WHERE id_equipamento = '{1}'", horimetro, fk_equipamento);
                bd.ExecutarComandoSQL(comando);
                if (bd.QuantidadeRegistros == 1)
                {
                    valorRetorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar atualizar o horímetro do equipamento!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return valorRetorno;
        }
    }
}
