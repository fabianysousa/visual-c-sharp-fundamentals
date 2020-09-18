using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSyntax1
{
    class ConvertDataType
    {
        static void main(string[] args)
        {
            int valor1, valortotal;
            valor1 = 100;
            string valor2;
            valor2 = "50";

            /*
             Para converter:
                - System.Convert
                - ToInt32(value)
                - ToString(value)
                - ToDouble(value)
                    (...)
             */

            valortotal = valor1 + Convert.ToInt32(valor2); // O resultado deve ser 150
        }
    }
}
