using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Account> Accounts { get; set; }
    }

    public class YourDbContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankingDbContext>();
            optionsBuilder.UseSqlServer("Server=CYANIDE;Database=BankingDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

            return new BankingDbContext(optionsBuilder.Options);
        }
    }
}
