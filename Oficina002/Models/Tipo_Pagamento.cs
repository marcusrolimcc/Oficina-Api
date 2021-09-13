using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina002.Models
{
    [Table("tipo_pagamento")]
    public class Tipo_Pagamento
    {
        [Key]
        [Column("idTipoPagamento")]
        public int IdTipoPagamento { get; set; }
        
        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("parcela")]
        public int Parcela { get; set; }

        [Column("id_atendimento")]
        public int Id_atendimento { get; set; }
    }
}
