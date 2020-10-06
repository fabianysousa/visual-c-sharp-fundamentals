using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Activity5
{
    [Table("Vendedor")]
    public class Vendedor
    {
        [Key]
        public int codVendendor { get; set; }
        [Column]
        public string nomeVendedor { get; set; }
        [Column]
        public double metaDeVenda { get; set; }
    }
}
