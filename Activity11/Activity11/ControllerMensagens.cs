using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity11
{
    class ControllerMensagens
    {
        public IMensagem msg;

        public ControllerMensagens(IMensagem m) {
            msg = m;
        }

        public void realizarEnvio()
        {
            msg.Enviar();
        }
    }
}
