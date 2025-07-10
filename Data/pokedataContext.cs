using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pokedata.Model;

namespace pokedata.Data
{
    public class pokedataContext : DbContext
    {
        public pokedataContext (DbContextOptions<pokedataContext> options)
            : base(options)
        {
        }

        public DbSet<pokedata.Model.Sim> Sim { get; set; } = default!;
    }
}
