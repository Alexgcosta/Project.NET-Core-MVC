using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Project.NET_Core_MVC.Models
{
    public class Context : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseSqlServer( @"Server=(localdb)\mssqlLocalDb;Database=Project.NET Core MVC;Integrated Security=True");
        }
    }
}

