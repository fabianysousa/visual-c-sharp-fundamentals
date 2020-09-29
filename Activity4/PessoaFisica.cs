using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4
{
    class PessoaFisica : Pessoa
    {
        private string cpf;

        public void setCpf(string valorCpf)
        {
            cpf = valorCpf;
        }

        public string getCpf()
        {
            return cpf;
        }
    }
}
