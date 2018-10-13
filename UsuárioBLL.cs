using System;
using Projeto3Camadas.Código.DAL;

namespace Projeto3Camadas.Código.BLL
{
    // A classe foi criada para inserirmos nela os métodos e funções do objeto Usuário, os mesmos são usados no Frm_Usuário.

    public class UsuárioBLL
    {
        /// <summary>
        /// Variável usada para retornar o resultado da função VerificarLogin.
        /// </summary>
        public bool Usuario_Cadastrado;

        /// <summary>
        /// Variável para mostrar uma mensagem ao usuário no momento do login.
        /// </summary>
        public String mensagem;

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public UsuárioBLL()
        {
            mensagem = "";
        }

        /// <summary>
        /// Função para acesso ao banco de dados.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public bool Acessar(String usuario, String senha)
        {
            UsuárioDAL usu_dal = new UsuárioDAL();

            Usuario_Cadastrado = usu_dal.VerificarLogin(usuario, senha);

            if (!usu_dal.mensagem.Equals(""))
            {
                this.mensagem = usu_dal.mensagem;
            } 

            return Usuario_Cadastrado;
        }
    }
}
