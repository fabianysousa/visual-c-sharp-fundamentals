using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity8
{
    class VendedorContext : DbContext
    {
        public VendedorContext(): base("BancodeDados_Vendedores")
        {

        }
        public DbSet<Vendedor> Vendedor { get; set; }

    }
}
