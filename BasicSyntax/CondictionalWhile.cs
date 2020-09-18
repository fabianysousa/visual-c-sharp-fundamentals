using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSyntax1
{
    class CondictionalWhile
    {
        static void main(string[] args)
        {
            int a = 0;
            while(a < 5)
            {
                if(a == 9)
                break;
                Console.WriteLine(a);
                a++;
            }
        }
    }
}
