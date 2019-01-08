using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto3Camadas.Código.DAL
{
    // Classe para acesso ao banco de dados.

    public class Acesso_BD
    {
        /// <summary>
        /// Indica a quantidade de registros retornados de uma consulta ao banco de dados.
        /// </summary>
        public int QuantidadeRegistros { get; set; }

        /// <summary>
        /// Descritor da conexão com o banco de dados.
        /// </summary>
        private MySqlConnection conn;

        /// <summary>
        /// dataTable auxiliar para consultas ao banco de dados.
        /// </summary>
        private DataTable dataTable;

        /// <summary>
        /// Responsável pela construção das instruções SQL.
        /// </summary>
        private MySqlCommandBuilder commandBuilder;

        /// <summary>
        /// dataReader auxiliar para consultas ao banco de dados.
        /// </summary>
        private MySqlDataReader dataReader;

        /// <summary>
        /// Endereço do servidor do banco de dados.
        /// </summary>
        private string server = "localhost";

        /// <summary>
        /// Usuário para acesso ao banco de dados.
        /// </summary>
        private string user = "root";

        /// <summary>
        /// Senha para acesso ao banco de dados.
        /// </summary>
        private string password = "";

        /// <summary>
        /// Nome do banco de dados.
        /// </summary>
        private string database = "bd_scgmt";

        /// <summary>
        /// Guarda qualquer eventual mensagem de erro.
        /// </summary>
        public string Erro { get; set; }

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public Acesso_BD()
        {
            QuantidadeRegistros = 0;
            Erro = string.Empty;
        }

        /// <summary>
        /// Cria uma conexão com o banco de dados.
        /// </summary>
        private bool Conectar()
        {
            bool valorRetorno = false;

            if (conn != null)
            conn.Close();

            string connStr = String.Format("server = {0}; user id = {1}; password = {2}; database = {3}; pooling = false", server, user, password, database);

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                valorRetorno = true;
            }
            catch(MySqlException ex)
            {
                Erro = ex.Message;
                throw new Exception(ex.Message);
            }

            return valorRetorno;
        }

        /// <summary>
        /// Método para execução dos comandos SQL no banco de dados.
        /// </summary>
        /// <param name="comandoSql"></param>
        public void ExecutarComandoSQL(string comandoSql)
        {
            if (Conectar())
            {
                MySqlCommand comando = new MySqlCommand(comandoSql, conn);
                QuantidadeRegistros = comando.ExecuteNonQuery();
                conn.Close();
                if (QuantidadeRegistros < 1)
                {
                    Erro = "Nenhum registro foi afetado!";
                }
            }
            else
            {
                QuantidadeRegistros = 0;
            }
        }

        /// <summary>
        /// Executa uma consulta ao banco de dados.
        /// </summary>
        /// <param name="comandoSql">Instrução SQL a ser executada</param>
        /// <returns></returns>
        public DataTable ExecutarConsulta(string comandoSql)
        {
            dataTable = null;

            if (Conectar())
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(comandoSql, conn);
                    MySqlDataReader dataReader = comando.ExecuteReader();
                    dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    QuantidadeRegistros = dataTable.Rows.Count;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Erro = ex.Message;
                    conn.Close();
                }
            }
            else
            {
                QuantidadeRegistros = 0;
            }

            return dataTable;
        }

        /// <summary>
        /// Executa uma consulta no banco de dados, muito usado para preencher os datagridsviews.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable RetDataTable(string sql)
        {
            if (Conectar())
            {
                dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
                commandBuilder = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Função para retornar um DataReader, muito usado para leitura de linhas do banco de dados.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public MySqlDataReader RetDataReader(string sql)
        {
            if (Conectar())
            {
                MySqlCommand comando = new MySqlCommand(sql, conn);
                dataReader = comando.ExecuteReader();
                dataReader.Read();
            }

            return dataReader;
        }
    }
}
