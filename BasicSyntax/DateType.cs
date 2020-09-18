using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSyntax1
{
    class DateType
    {
        static void Main(string[] args)
        {

            int var_inteiro;
            long var_inteiro_longo;
            float var_ponto_flutuante;
            double var_dupla_precisao;
            decimal var_monetario;

            /* 
                var_caracter, var_boleano e var_cadeia_caracteres
                são definidas como valores constantes no próprio código 
            */

            char var_caracter;
            bool var_boleano;

            /*
                string é definido como um tipo de dado imutável
                é preciso criar uma nova string na memória para descartar a anterior
             */

            string var_cadeia_caracteres;

            var_inteiro = Console.Read();
            var_inteiro_longo = Console.Read();
            var_ponto_flutuante = Console.Read();
            var_dupla_precisao = Console.Read();
            var_monetario = Console.Read();
            var_caracter = 'm';
            var_boleano = true;
            var_cadeia_caracteres = "Exercitando o uso de variaveis";

            Console.WriteLine(var_caracter);
            Console.WriteLine(var_boleano);
            Console.WriteLine(var_cadeia_caracteres);
        }

    }
}
