using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSyntax1
{
    class CondictionaElse
    {
        static void main(string[] args)
        {
            String clima = "Bom";
            if (clima == "Bom")
            {
                Console.WriteLine("Vamos à praia!!!");
            }
            else
            {
                Console.WriteLine("O dia pode estar nublado");
            }
        }
    }
}
