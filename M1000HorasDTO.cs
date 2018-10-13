using System;

namespace Projeto3Camadas.Código.DTO
{
    // A classe foi criada para inserirmos nela os atributos do objeto Manutenção de 1000 Horas, os atributos que criamos são os campos do Frm_Manutenção1000Horas.

    public class M1000HorasDTO
    {
        /// <summary>
        /// Id para identificar um registro da tabela de manutenção de 1000 horas.
        /// </summary>
        public int id_manut_1000_horas { get; set; }

        /// <summary>
        /// Código do equipamento.
        /// </summary>
        public int fk_equipamento { get; set; }

        /// <summary>
        /// Código do responsável técnico.
        /// </summary>
        public int fk_resp_tecnico { get; set; }

        /// <summary>
        /// Horas do equipamento.
        /// </summary>
        public decimal horimetro { get; set; }

        /// <summary>
        /// Data em que a manutenção foi executada.
        /// </summary>
        public DateTime data_manutencao { get; set; }

        /// <summary>
        /// CPF do responsável técnico.
        /// </summary>
        public string cpf_resp_tecnico { get; set; }

        /// <summary>
        /// Construtora padrão.
        /// </summary>
        public M1000HorasDTO()
        {
            id_manut_1000_horas = 0;
            fk_equipamento = 0;
            fk_resp_tecnico = 0;
            horimetro = 0;
            data_manutencao = DateTime.MinValue;
            cpf_resp_tecnico = string.Empty;
        }
    }
}
