using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4
{
    class PessoaJuridica : Pessoa
    {
        private string cnpj;

        public void setCnpj(string valorCnpj)
        {
            cnpj = valorCnpj;
        }

        public string getCnpj()
        {
            return cnpj;
        }
    }
}
