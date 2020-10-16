using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9
{
    class  Program
    {
        static void Main(string[] args)
        {
            Creator carroCreator = new CarroCreator();

            Creator motoCreator = new MotoCreator();

            Carro carro = (Carro)carroCreator.fabricarVeiculo();

            Moto moto = (Moto)motoCreator.fabricarVeiculo();


            Console.WriteLine(carro.getTipo());

            Console.WriteLine(moto.getTipo());

            Console.ReadLine();
        }
    }
}
