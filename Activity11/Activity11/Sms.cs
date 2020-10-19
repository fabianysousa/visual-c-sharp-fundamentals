using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity11
{
    class Sms : IMensagem
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando SMS");
        }
    }
}
