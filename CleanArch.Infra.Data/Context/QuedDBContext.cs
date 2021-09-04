using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Context
{
    public class QuedDBContext : DbContext
    {
        public QuedDBContext (DbContextOptions options) : base(options)
        {
           
            
        }

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public DbSet<Course> Courses { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                    .LogTo(Console.WriteLine)
                    .UseLoggerFactory(MyLoggerFactory);
    }
}
