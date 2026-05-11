using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JogosMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace JogosMVC.Contexts
{
    public class JogosDBContext : DbContext
    {
        public JogosDBContext(DbContextOptions<JogosDBContext> options) : base(options) {}

        public DbSet<Jogos> Jogos{ get; set; }
    }
}