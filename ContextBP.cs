using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API
{
    public class ContextBP : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    {
        //        optionsBuilder.UseSqlServer(
        //            @"Server=YANDRY-PC;Database=Banco;Trusted_Connection=True");
        //    }

        public ContextBP(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Intere> Interes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Cuenta> TipoCuenta { get; set; }


    }
}
