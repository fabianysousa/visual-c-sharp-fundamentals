using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity8
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente
            {
                Id = 123,
                nomeCliente = "Leticia",
                endereco = "rua 1, numero 11",

            };

            ClienteContext dbCli = new ClienteContext();
            dbCli.Cliente.Add(cliente1);
            dbCli.SaveChanges();

            Console.WriteLine("Valores de cliente inseridos com sucesso!");
            Console.ReadKey();

            Vendedor vendedor1 = new Vendedor
            {
                Id = 345,
                nomeVendendor = "Gabriela",
                metaDeVenda = 5.000
            };

            VendedorContext dbVend = new VendedorContext();
            dbVend.Vendedor.Add(vendedor1);
            dbVend.SaveChanges();

            Console.WriteLine("Valores de vendedor inseridos com sucesso!");
            Console.ReadKey();

        }
    }
}
