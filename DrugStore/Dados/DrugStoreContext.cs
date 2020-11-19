using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrugStore.Models;
using Microsoft.EntityFrameworkCore;

namespace DrugStore.Dados
{
    public class DrugStoreContext : DbContext
    {
        public DrugStoreContext(DbContextOptions<DrugStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Medicamento> Medicamento { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<DrugStore.Models.Compra> Compra { get; set; }
    }
}
