using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Contexto
{
    public class LojaContext : DbContext
    {
        public LojaContext()
        {}
        public LojaContext(DbContextOptions<LojaContext> options) : base (options) { }
        public DbSet<Produto> Products { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
