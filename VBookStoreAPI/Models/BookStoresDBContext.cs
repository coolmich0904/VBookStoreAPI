using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VBookStoreAPI.Models
{
    public class BookStoresDBContext :DbContext
    {
        public DbSet<Publisher> Publishers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder
                .UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=BookStoresDB;Integrated Security=True");
        }


    }
}
