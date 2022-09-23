using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cotacao.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cotacao.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Root> ?Roots {get; set; }
        public DbSet<MOEDAS> ?MOEDAS {get;set;}

        public DbSet<MoedaGenerica> MoedaGenericas {get; set; }
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}