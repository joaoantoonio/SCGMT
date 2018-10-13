namespace Projeto3Camadas.Código.DTO
{
    // A classe foi criada para inserirmos nela os atributos do objeto Equipamento, os atributos que criamos são os campos do Frm_CadastroEquipamento.

    public class EquipamentoDTO
    {
        /// <summary>
        /// Id para identificar um registro da tabela equipamento.
        /// </summary>
        public int id_equipamento { get; set; }

        /// <summary>
        /// Monobloco do equipamento.
        /// </summary>
        public string monobloco { get; set; }

        /// <summary>
        /// Motor do equipamento.
        /// </summary>
        public string motor { get; set; }

        /// <summary>
        /// Série do equipamento.
        /// </summary>
        public string serie { get; set; }

        /// <summary>
        /// Horas do equipamento.
        /// </summary>
        public decimal horimetro { get; set; }

        /// <summary>
        /// Nota Fiscal de Compra do equipamento.
        /// </summary>
        public string nf_compra { get; set; }

        /// <summary>
        /// Código do proprietário do equipamento.
        /// </summary>
        public int fk_proprietario { get; set; }

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public EquipamentoDTO()
        {
            id_equipamento = 0;
            monobloco = string.Empty;
            motor = string.Empty;
            serie = string.Empty;
            horimetro = 0;
            nf_compra = string.Empty;
            fk_proprietario = 0;
        }
    }
}
