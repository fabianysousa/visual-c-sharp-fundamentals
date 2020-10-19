using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity11
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerMensagens mensagemE = new ControllerMensagens(new Email());
            ControllerMensagens mensagemS = new ControllerMensagens(new Sms());

            mensagemE.realizarEnvio();
            mensagemS.realizarEnvio();
        }
    }
}
