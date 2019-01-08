using System;
using Projeto3Camadas.Código.DAL;
using System.Data;

namespace Projeto3Camadas.Código.BLL
{
    // A classe foi criada para inserirmos nela os métodos e funções do objeto Tela Principal, os mesmos são usados no Frm_TelaPrincipal.

    public class TelaPrincipalBLL
    {
        /// <summary>
        /// Instância para acesso ao banco de dados.
        /// </summary>
        private Acesso_BD bd;

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public TelaPrincipalBLL()
        {
            bd = null;
        }

        /// <summary>
        /// // Função para selecionar alguns dados dos equipamentos e de seus respectivos proprietários que estão cadastrados no banco de dados.
        /// </summary>
        /// <returns></returns>
        public DataTable SelecionaEquipamentos_Proprietarios()
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT E.id_equipamento,E.monobloco,E.serie,E.motor,E.horimetro,P.nome_razaosocial FROM equipamento AS E INNER JOIN proprietario AS P WHERE E.fk_proprietario = P.id_proprietario");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar as informações da tela principal!" + ex.Message);
            }
            finally
            {

            }

            return dt;
        }

        /// <summary>
        /// Função para pesquisa do monobloco do equipamento.
        /// </summary>
        /// <param name="monobloco"></param>
        /// <returns></returns>
        public DataTable PesquisaEquipamento(string monobloco)
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT E.id_equipamento, E.monobloco, E.serie, E.motor, E.horimetro, P.nome_razaosocial FROM equipamento AS E INNER JOIN proprietario AS P WHERE E.fk_proprietario = P.id_proprietario AND monobloco LIKE '%" + monobloco + "%'");
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
    }
}
