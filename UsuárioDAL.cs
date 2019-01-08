using System;
using MySql.Data.MySqlClient;

namespace Projeto3Camadas.Código.DAL
{
    // Classe UsuárioDAL criada para estabelecer a comunicação com o banco de dados e a verificação do usuário e senha no banco de dados.

    public class UsuárioDAL
    {
        /// <summary>
        /// Instância para acesso ao banco de dados.
        /// </summary>
        Acesso_BD bd;

        /// <summary>
        /// Variável usada para retornar o resultado da função VerificarLogin.
        /// </summary>
        public bool Usuario_Cadastrado;

        /// <summary>
        /// Variável para mostrar uma mensagem ao usuário no momento do login.
        /// </summary>
        public String mensagem;

        /// <summary>
        /// Instância para realizar a leitura das linhas de um comando SQL no banco de dados.
        /// </summary>
        MySqlDataReader dr;

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public UsuárioDAL()
        {
            Usuario_Cadastrado = false;
            mensagem = "";
        }

        /// <summary>
        /// Função para verificar se o usuário e a senha estão cadastrados no banco de dados.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public bool VerificarLogin(String usuario, String senha)
        {
            try
            {
                bd = new Acesso_BD();
                string comando = ("SELECT usuario,senha FROM usuario WHERE usuario = '" + usuario + "' AND senha = '" + senha + "'");
                dr = bd.RetDataReader(comando);

                if (dr.HasRows)
                {
                    Usuario_Cadastrado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar o administrador!" + ex.Message);
            }

            return Usuario_Cadastrado;
        }
    }
}
