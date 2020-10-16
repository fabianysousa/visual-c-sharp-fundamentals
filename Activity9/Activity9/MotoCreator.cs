using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9
{
    public class MotoCreator : Creator
    {
        public override Veiculo fabricarVeiculo()
        {
            return new Moto();
        }
    }
}
