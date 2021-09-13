using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina002.Models
{
    [Table("tipo_servico")]
    public class Tipo_Servico
    {
        [Key]
        [Column("idTipoServico")]
        public int IdTipoServico { get; set; }
        [Column("id_funcionario")]
        public int Id_funcionario { get; set; }
        [Column("id_servico")]
        public int Id_servico { get; set; }
    }
}
