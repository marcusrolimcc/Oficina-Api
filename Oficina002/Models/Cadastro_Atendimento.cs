using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina002.Models
{
    [Table("cadastro_atendimento")]
    public class Cadastro_Atendimento
    {
        [Key]
        [Column("idCadastroAtendimento")]
        public int IdCadastroAtendimento { get; set; }

        [Column("id_atendimento")]
        public int Id_atendimento { get; set; }

        [Column("id_cliente")]
        public int Id_cliente { get; set; }
    }
}
