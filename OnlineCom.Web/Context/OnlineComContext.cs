using Microsoft.EntityFrameworkCore;
using OnlineCom.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCom.Web.Context
{
    public class OnlineComContext : DbContext
    {
        public OnlineComContext(DbContextOptions<OnlineComContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins {get;set;}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
