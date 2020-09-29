using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4
{
    class Pessoa
    {
        private string nome;
        private int telefone;

        public void setNome(String valorNome)
        {
            nome = valorNome;
        }

        public string getNome()
        {
            return nome;
        }

        public void setTelefone(int valorTelefone)
        {
            telefone = valorTelefone;
        }

        public int getTelefone()
        {
            return telefone;
        }
    }
}
