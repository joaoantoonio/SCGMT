using System;
using Projeto3Camadas.Código.DAL;
using System.Data;

namespace Projeto3Camadas.Código.BLL
{
    // A classe foi criada para inserirmos nela os métodos e funções do objeto Relatórios, os mesmos são usados no Frm_Relatórios.

    public class RelatóriosBLL
    {
        /// <summary>
        /// Instância para acesso ao banco de dados.
        /// </summary>
        private Acesso_BD bd;

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public RelatóriosBLL()
        {
            bd = null;
        }

        /// <summary>
        /// Função para selecionar todas as manutenções de 100 horas que já foram realizadas.
        /// </summary>
        /// <returns></returns>
        public DataTable SelecionaManutencao100Horas()
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT E.monobloco, (SELECT nome_razaosocial FROM proprietario WHERE id_proprietario = E.fk_proprietario), M.horimetro, M.data_manutencao, M.cpf_resp_tecnico FROM equipamento AS E INNER JOIN manut_100_horas AS M WHERE E.id_equipamento = M.100_fk_equipamento");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar as informações das manutenções de 100 horas dos equipamentos!" + ex.Message);
            }
            finally
            {

            }

            return dt;
        }

        /// <summary>
        /// Função para selecionar todas as manutenções de 500 horas que já foram realizadas.
        /// </summary>
        /// <returns></returns>
        public DataTable SelecionaManutencao500Horas()
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT E.monobloco, (SELECT nome_razaosocial FROM proprietario WHERE id_proprietario = E.fk_proprietario), M.horimetro, M.data_manutencao, M.cpf_resp_tecnico FROM equipamento AS E INNER JOIN manut_500_horas AS M WHERE E.id_equipamento = M.500_fk_equipamento");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar as informações das manutenções de 500 horas dos equipamentos!" + ex.Message);
            }
            finally
            {

            }

            return dt;
        }

        /// <summary>
        /// Função para selecionar todas as manutenções de 1000 horas que já foram realizadas.
        /// </summary>
        /// <returns></returns>
        public DataTable SelecionaManutencao1000Horas()
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new Acesso_BD();
                dt = bd.RetDataTable("SELECT E.monobloco, (SELECT nome_razaosocial FROM proprietario WHERE id_proprietario = E.fk_proprietario), M.horimetro, M.data_manutencao, M.cpf_resp_tecnico FROM equipamento AS E INNER JOIN manut_1000_horas AS M WHERE E.id_equipamento = M.1000_fk_equipamento");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar as informações das manutenções de 1000 horas dos equipamentos!" + ex.Message);
            }
            finally
            {

            }

            return dt;
        }
    }
}
