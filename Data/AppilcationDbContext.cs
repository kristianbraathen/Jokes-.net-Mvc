using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Jokes.Models;

namespace Jokes.Data
{
    public class AppilcationDbContext : DbContext
    {
        public AppilcationDbContext (DbContextOptions<AppilcationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Jokes.Models.Joke> Joke { get; set; }
    }
}
