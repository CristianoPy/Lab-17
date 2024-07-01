using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17.Model
{
    internal class ShopDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Productor> Productors { get; set; }

        public ShopDbContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C#\Curso\C#7\Lab 17\Lab 17\Lab 17\Product.mdf"";Integrated Security=True");
             
        }

        public Category AddCategory(string name, string pictogram)
        {
            var category = new Category { Name = name, Pictogram = pictogram };
            Add(category);
            SaveChanges();
            return category;
        }
    }
}
