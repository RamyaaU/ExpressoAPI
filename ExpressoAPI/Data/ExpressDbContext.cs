using ExpressoAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressoAPI.Data
{
    public class ExpressDbContext : DbContext
    {
        public ExpressDbContext(DbContextOptions<ExpressDbContext>options):base(options)
        {

        }

        public DbSet<Menu> Menus {get; set; }

        public DbSet<Reservation> Reservation{ get; set; }
        }
}
