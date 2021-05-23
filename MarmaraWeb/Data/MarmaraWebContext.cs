using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MarmaraWeb.Models;

namespace MarmaraWeb.Data
{
    public class MarmaraWebContext : DbContext
    {
        public MarmaraWebContext (DbContextOptions<MarmaraWebContext> options)
            : base(options)
        {
        }

        public DbSet<MarmaraWeb.Models.Users> Users { get; set; }
    }
}
