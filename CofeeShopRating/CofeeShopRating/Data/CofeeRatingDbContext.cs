using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CofeeShopRating.Models;
using Microsoft.EntityFrameworkCore;

namespace CofeeShopRating.Data
{
    public class CofeeRatingDbContext : DbContext
    {

        public CofeeRatingDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Cofee> Cofees { get; set; }
    }
}
