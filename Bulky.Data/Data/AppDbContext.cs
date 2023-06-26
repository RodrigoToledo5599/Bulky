using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base( options ) { }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id =1, Name = "Action", DisplayOrder=1},
                new Category { Id =2, Name = "SciFi", DisplayOrder=2},
                new Category { Id =3, Name = "History", DisplayOrder=3},
                new Category { Id =4, Name = "Adventure", DisplayOrder=4},
                new Category { Id =5, Name = "Documentary", DisplayOrder=5},
                new Category { Id =6, Name = "Horror", DisplayOrder=6},
                new Category { Id =7, Name = "Kpop", DisplayOrder=7},
                new Category { Id =8, Name = "Serie", DisplayOrder=8},
                new Category { Id =9, Name = "Drama", DisplayOrder=9},
                new Category { Id =10, Name = "Korean", DisplayOrder=10},
                new Category { Id =11, Name = "Zombie Apocalipse", DisplayOrder=11},
                new Category { Id =12, Name = "Horror", DisplayOrder=12}
                
                
                
                
                
                
                
                );
        }

    }
}
