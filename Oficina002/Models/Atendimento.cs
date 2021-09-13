using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina002.Models
{
    [Table("atendimento")]
    public class Atendimento
    {
        [Key]
        [Column("idAtendimento")]
        public int IdAtendimento { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }
    }
}
