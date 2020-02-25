using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamousBeanPortal.Models;
using Microsoft.EntityFrameworkCore;


namespace FamousBeanPortal.Data
{
    public class FamousContext: DbContext
    {
        public FamousContext(DbContextOptions<FamousContext> Options) : base(Options) 
        {
        }

        public DbSet<Meal> Meal { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<User> User{ get; set; }
        public DbSet<Order> Order { get; set; }

    }
}
