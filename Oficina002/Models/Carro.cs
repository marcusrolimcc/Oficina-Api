using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina002.Models
{
    [Table("carro")]
    public class Carro
    {
        [Key]
        [Column("idCarro")]
        public int IdCarro { get; set; }

        [Column("placa")]
        public string Placa { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("id_cliente")]
        public int Id_Cliente { get; set; }
        public int Id_Marca { get; set; }
    }
}
