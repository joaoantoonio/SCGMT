using System;
using System.Windows.Forms;
using Projeto3Camadas.Código.BLL;
using Projeto3Camadas.Código.DAL;

namespace Projeto3Camadas
{
    public partial class Frm_Usuário : Form
    {
        /// <summary>
        /// Instância de outras classes do software.
        /// </summary>
        UsuárioBLL bll = new UsuárioBLL();
        UsuárioDAL dal = new UsuárioDAL();

        public bool logado = false;

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public Frm_Usuário()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para carregamento do formulário da tela de acesso ao sistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento do botão "Entrar" do formulário da tela de acesso ao sistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Entrar_Login_Click(object sender, EventArgs e)
        {
#if DEBUG
            bll.Acessar("jramos10", "08101990");
#else
            bll.Acessar(txt_usuario.Text, txt_senha.Text);
#endif
            if (bll.mensagem.Equals(""))
            {
                if (bll.Usuario_Cadastrado)
                {
                    //MessageBox.Show("Logado com sucesso!", "Entrando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_TelaPrincipal frm_tela_principal = new Frm_TelaPrincipal();
                    frm_tela_principal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Administrador não encontrado, verifique se o usuário e senha estão corretos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_usuario.Focus();
                }
            }
            else
            {
                MessageBox.Show(bll.mensagem);
            }

            LimparTela();
        }

        /// <summary>
        /// Evento do botão "Sair" do formulário da tela de acesso ao sistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sair_Login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Método para limpar os campos do formulário da tela de acesso ao sistema.
        /// </summary>
        private void LimparTela()
        {
            txt_usuario.Clear();
            txt_senha.Clear();
        }
    }
}
