using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            int result, number;
            string name;

            name = Console.ReadLine();
            number = Console.Read();

            for( int i = 1; i < 3; i++ )
            {
                number += i;
            }

            Console.WriteLine(number);
            result = number + Convert.ToInt32(name);
            Console.WriteLine(result);


        }
    }
}
