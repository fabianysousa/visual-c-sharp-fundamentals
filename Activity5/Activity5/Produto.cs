using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Activity5
{
    [Table ("Produto")]
    public class Produto
    {
        [Key]
        public int codPorduto { get; set; }
        [Column]
        public string descricao { get; set; }
        [Column]
        public double valorUnitario { get; set; }
    }
}
