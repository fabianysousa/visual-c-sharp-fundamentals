using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.setNome("Joao");
            pf.setTelefone(99999999);
            pf.setCpf("000.000.000-00");

            PessoaJuridica pj = new PessoaJuridica();
            pj.setNome("Maria");
            pj.setTelefone(99999999);
            pj.setCnpj("000.000.000-00");

        }
    }
}
