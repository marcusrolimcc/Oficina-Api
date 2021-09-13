using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina002.Models
{
    [Table("funcionario")]
    public class Funcionario
    {
        [Key]
        [Column("idFuncionario")]
        public int IdFuncionario { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("id_oficina")]
        public int Id_oficina { get; set; }
    }
}
