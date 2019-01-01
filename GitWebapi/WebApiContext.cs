using Microsoft.EntityFrameworkCore;
using GitWebApi.Models;

namespace GitWebApi
{
    public class WebApiContext : DbContext
    {
        public DbSet<Product> Products{get;set;}
        public DbSet<User> Users{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Data Source=KDPL36\SQLEXPRESS16,1433;Initial Catalog=MyeCommerce;User ID=ecmusr;Password=Sql#2703;Connection Timeout=60");
        }
    }
}