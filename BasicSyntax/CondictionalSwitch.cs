using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSyntax1
{
    class CondictionalSwitch
    {
        static void main(string[] args)
        {
            string clima = Console.ReadLine();
            switch (clima)
            {
                case "Bom":
                    Console.WriteLine("Vamos à praia!!!");
                    break;
                case "Nublado":
                    Console.WriteLine("Vamos assistir a um filme no cinema");
                    break;
                default:
                    Console.WriteLine("O dia pode estar nublado");
                    break;
            }
        }
    }
}
