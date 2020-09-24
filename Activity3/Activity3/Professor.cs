using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3
{
    class Professor
    {

        public string nome_professor;
        public int numero_carteira;
        public float salario;

        public void postarConteudo(string descricaoConteudo) 
        {
            Console.WriteLine("Professor postando o conteúdo: " + descricaoConteudo);
        }

        public void realizarChamada() 
        {
            Console.WriteLine("Professor realizando chamada");
        }

    }
}
