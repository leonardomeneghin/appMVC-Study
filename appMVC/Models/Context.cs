using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appMVC.Models
{
    public class Context : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            //Método que configura o EntityFramework
            //Aqui dizemos qual DB será usado

            optionsBuilder.UseSqlServer(@"Data Source=SALPC0062\DB01LOCAL;Initial Catalog=BItest;Integrated Security=True");
            

        }

    }
}
