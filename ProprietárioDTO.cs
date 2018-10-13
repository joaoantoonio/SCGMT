namespace Projeto3Camadas.Código.DTO
{
    // A classe foi criada para inserirmos nela os atributos do objeto Proprietário, os atributos que criamos são os campos do Frm_CadastroProprietário.

    public class ProprietárioDTO
    {   
        /// <summary>
        /// Id para identificar um registro da tabela proprietário.
        /// </summary>
        public int id_proprietario { get; set; }

        /// <summary>
        /// CPF ou CNPJ do proprietário.
        /// </summary>
        public string cpf_cnpj { get; set; }

        /// <summary>
        /// Nome ou Razão Social do proprietário.
        /// </summary>
        public string nome_razaosocial { get; set; }

        /// <summary>
        /// Endereço do proprietário.
        /// </summary>
        public string endereco { get; set; }

        /// <summary>
        /// Número da residência do proprietário.
        /// </summary>
        public string numero { get; set; }

        /// <summary>
        /// Bairro do endereço do proprietário.
        /// </summary>
        public string bairro { get; set; }

        /// <summary>
        /// CEP do endereço do proprietário.
        /// </summary>
        public string cep { get; set; }

        /// <summary>
        /// Cidade do proprietário.
        /// </summary>
        public string cidade { get; set; }

        /// <summary>
        /// Estado da cidade do proprietário.
        /// </summary>
        public string estado { get; set; }

        /// <summary>
        /// Telefone do proprietário.
        /// </summary>
        public string telefone { get; set; }

        /// <summary>
        /// Email do proprietário.
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Nome da fazenda/sítio do proprietário.
        /// </summary>
        public string nome_fazenda { get; set; }

        /// <summary>
        /// Município da fazenda/sítio do proprietário.
        /// </summary>
        public string municipio_fazenda { get; set; }

        /// <summary>
        /// UF do munícípio da fazenda/sítio do proprietário.
        /// </summary>
        public string uf_municipio_fazenda { get; set; }

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public ProprietárioDTO()
        {
            id_proprietario = 0;
            cpf_cnpj = string.Empty;
            nome_razaosocial = string.Empty;
            endereco = string.Empty;
            numero = string.Empty;
            bairro = string.Empty;
            cep = string.Empty;
            cidade = string.Empty;
            estado = string.Empty;
            telefone = string.Empty;
            email = string.Empty;
            nome_fazenda = string.Empty;
            municipio_fazenda = string.Empty;
            uf_municipio_fazenda = string.Empty;
        }
    }
}
