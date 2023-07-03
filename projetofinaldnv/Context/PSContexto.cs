using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetofinaldnv.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace projetofinaldnv.Context
{


    public class MeuContexto : DbContext
    {
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Candidato> Candidatura { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<ProcessoSeletivo> Processos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=dob;user=root;password=",
                                         new MySqlServerVersion("10.4.28-MariaDB")); // versão
        }
    }
}
