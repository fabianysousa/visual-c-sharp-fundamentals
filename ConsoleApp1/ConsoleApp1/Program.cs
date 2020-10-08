using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alu = new Aluno
            {
                Matricula = 2100,
                NomeAluno = "Mateus",
                DataNascimento = "04/06/2011",
            };

            AlunoContext db = new AlunoContext();
            db.Aluno.Add(alu);
            db.SaveChanges();

            Console.WriteLine("Valores inseridos com sucesso!");
            Console.ReadKey();
        }
    }
}
