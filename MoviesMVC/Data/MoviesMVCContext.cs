using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesMVC.Models;

namespace MoviesMVC.Data
{
    public class MoviesMVCContext : DbContext
    {
        public MoviesMVCContext (DbContextOptions<MoviesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
