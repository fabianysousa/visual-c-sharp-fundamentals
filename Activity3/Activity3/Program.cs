using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno1 = new Aluno();
            aluno1.nome_aluno = "Fabiany";
            aluno1.matricula = 999999;
            aluno1.email = "nomealuno1@gmail.com";

            Aluno aluno2 = new Aluno();
            aluno2.nome_aluno = "Leticia";
            aluno2.matricula = 000000;
            aluno2.email = "nomeluno2@gmail.com";

            Professor professor1 = new Professor();
            professor1.nome_professor = "Lucas";
            professor1.numero_carteira = 888888;
            professor1.salario = 3.500f;

            Professor professor2 = new Professor();
            professor2.nome_professor = "Nara";
            professor2.numero_carteira = 222222;
            professor2.salario = 2.100f;

        }
    }
}
