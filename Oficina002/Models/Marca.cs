using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina002.Models
{
    [Table("marca")]
    public class Marca
    {
        [Key]
        [Column("idMarca")]
        public int IdMarca { get; set; }

        [Column("nome")]
        public string Nome { get; set; }
    }
}
