using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AlunoContext : DbContext
    {
        public AlunoContext() : base("BancodeDados_Alunos")
        {

        }
        public DbSet<Aluno> Aluno { get; set; }
    }
}
