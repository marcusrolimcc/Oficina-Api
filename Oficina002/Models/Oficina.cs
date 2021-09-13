using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina002.Models
{
    [Table("oficina")]
    public class Oficina
    {
        [Key]
        [Column("idOficina")]
        public int IdOficina { get; set; }

        [Column("nome")]
        public string Nome { get; set; }
    }
}