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
            int number1, number2;
            int result;
            int exit = 0;
            Console.WriteLine("Digite um numero:");
            number1 = Convert.ToInt32(Console.ReadLine());
           
            

            Console.WriteLine("Digite outro numero:");
            number2 = Convert.ToInt32(Console.ReadLine());

            while (exit == 0 ) {
                
                result = number1 + number2;

                Console.WriteLine("Essa é a conversõa da soma de (number1 + number2) + 's' em string:)");
                Convert.ToString(result);
                result = result + 's';
                Console.WriteLine(result);
            
                Console.WriteLine("Para fechar o console digite um número diferente de 0:");
                exit = Console.Read();


            }
        }
    }
}
