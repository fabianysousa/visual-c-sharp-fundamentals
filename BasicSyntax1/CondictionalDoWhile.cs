using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSyntax1
{
    class CondictionalDoWhile
    {
        static void main(string[] args)
        {
            int a = 0;
            do
            {
                if(a == 9)
                break;
                Console.WriteLine(a);
                a++;
            }
            while(a < 5);
        }
    }
}
