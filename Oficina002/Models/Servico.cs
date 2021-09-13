using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina002.Models
{
    [Table("servico")]
    public class Servico
    {
        [Key]
        [Column("idServico")]
        public int IdServico { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("preco")]
        public decimal Preco { get; set; }

        [Column("prazo")]
        public int Prazo { get; set; }

        [Column("id_atendimento")]
        public int Id_atendimento { get; set; }
    }
}
