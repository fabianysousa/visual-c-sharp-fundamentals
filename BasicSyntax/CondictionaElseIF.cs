using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSyntax1
{
    class CondictionaElseIF
    {
        static void main(string[] args)
        {
            String clima ="Bom";
            if(clima == "Bom")
{
                Console.WriteLine("Vamos a praia!!!");
            }
            else if (clima == "Nublado")
            {
                Console.WriteLine("Vamos assistir um filme no cinema");
            }
            else
            {
                Console.WriteLine("O dia pode estar chovendo");
            }
        }
    }
}
