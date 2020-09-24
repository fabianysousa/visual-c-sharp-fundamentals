using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3
{
    class Aluno
    {

        public string nome_aluno;
        public int matricula;
        public string email;

        public void inserirDisciplina() 
        {
            Console.WriteLine("Aluno inserindo disciplina");
        }
        public void removerDisciplina() 
        {
            Console.WriteLine("Aluno removendo disciplina");
        }
        public void realizarMatricula() 
        {
            Console.WriteLine("Aluno realizando matricula");
        }
    }
}
