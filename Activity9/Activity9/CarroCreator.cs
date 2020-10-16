using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9
{
    public class CarroCreator : Creator
    {
        public override Veiculo fabricarVeiculo()
        {
            return new Carro();
        }
    }
}
