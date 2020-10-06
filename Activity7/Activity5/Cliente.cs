using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Activity5
{
    [Table ("Cliente")]
    public class Cliente
    {
        [Key]
        public int codClienteId { get; set; }
        [Column]
        public string nameCliente { get; set; }
        [Column]
        public string endereco { get; set; }

    }
}
