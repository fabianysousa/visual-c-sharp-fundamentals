using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSyntax1
{
    class ContatenateString
    {
        static void main(string[] args)
        {
            string endereco = "1015";

            endereco = "Rua – Pres.Getulio Vargas," + endereco;
            endereco += "-Bairro: Brasilia";

            Console.WriteLine(endereco);
        }
    }
}
