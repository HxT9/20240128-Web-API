using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<EArticolo> Articolo { get; set; }
        public DbSet<EDocumento> Documento { get; set; }

        //Constructor
        public ApplicationContext() {
            Init();
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Init();
        }

        private void Init()
        {
            //Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=DB/Application.db");
        }

    }
}
