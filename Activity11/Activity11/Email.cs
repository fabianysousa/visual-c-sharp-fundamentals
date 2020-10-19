using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity11
{
    class Email : IMensagem
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando E-Mail");
        }
    }
}
