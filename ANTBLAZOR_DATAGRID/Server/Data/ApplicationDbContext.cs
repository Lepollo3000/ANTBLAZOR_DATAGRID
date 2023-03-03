using Microsoft.EntityFrameworkCore;
using ANTBLAZOR_DATAGRID.Server.Data.Configuration;
using ANTBLAZOR_DATAGRID.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANTBLAZOR_DATAGRID.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

        public DbSet<Product> Products { get; set; }
    }
}
