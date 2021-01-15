using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.DataAccess.Concrete.EF.Mappings;
using WordLibrary.Entities.Concrete;

namespace WordLibrary.DataAccess.Concrete.EF
{
    public class WordDBContext : DbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Favorite> Favorites { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserWords> UserWords { get; set; }
        DbSet<Word> Word { get; set; }
        DbSet<WordCategory> WordCategories { get; set; }
        public WordDBContext() { }
        public WordDBContext(DbContextOptions<WordDBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UB2I2JK\\SQLEXPRESS;Initial Catalog=WordDB;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new WordMap());
        }
    }
}
