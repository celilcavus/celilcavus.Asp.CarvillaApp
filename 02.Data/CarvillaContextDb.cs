using _01.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Data
{
    public class CarvillaContextDb : DbContext
    {
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Cars> Cars{ get; set; }
        public DbSet<Clients> Clients{ get; set; }
        public DbSet<Services> Services{ get; set; }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source =C:\\software\\asp.net core\\celilcavus.Asp.CarvillaApp\\CarvillaDb.db;");
        }
    }
}
