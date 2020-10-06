using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5
{
    [Table("Cliente")]
    public class Cliente
    {   [Key]
        public int codCliente { get; set; }
        public string nomeCliente { get; set; }
        public string endereco {get; set;}
    }
}
