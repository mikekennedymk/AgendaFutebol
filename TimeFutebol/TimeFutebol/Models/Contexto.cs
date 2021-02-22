using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeFutebol.Models;

namespace TimeFutebol.Models
{
    public class Contexto : DbContext
    {

        public DbSet<Jogador> Jogadores { get; set; }
       
        //método de acesso ao banco
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TimeFutebol;Data Source=DESKTOP-HGJ15MT\SQLEXPRESS");

}

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { 
   
        }

       


    }
}
