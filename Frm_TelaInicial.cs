using System;
using System.Windows.Forms;

namespace Projeto3Camadas
{
    public partial class Frm_TelaInicial : Form
    {
        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public Frm_TelaInicial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para validação e iniciação do software.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pgb_tela_inicial.Value < 100)
            {
                pgb_tela_inicial.Value = pgb_tela_inicial.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                Frm_Usuário frm_usuario = new Frm_Usuário();
                frm_usuario.ShowDialog();
                this.Visible = false;
            }
        }
    }
}
