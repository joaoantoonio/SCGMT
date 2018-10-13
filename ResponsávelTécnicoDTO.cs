namespace Projeto3Camadas.Código.DTO
{
    // A classe foi criada para inserirmos nela os atributos do objeto Responsável Técnico, os atributos que criamos são os campos do Frm_CadastroResponsávelTécnico.

    public class ResponsávelTécnicoDTO
    {
        /// <summary>
        /// Id para identificar um registro da tabela responsável técnico.
        /// </summary>
        public int id_resp_tecnico { get; set; }

        /// <summary>
        /// CPF do responsável técnico.
        /// </summary>
        public string cpf { get; set; }

        /// <summary>
        /// Nome do responsável técnico.
        /// </summary>
        public  string nome { get; set; }

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public ResponsávelTécnicoDTO()
        {
            id_resp_tecnico = 0;
            cpf = string.Empty;
            nome = string.Empty;
        }
    }
}
