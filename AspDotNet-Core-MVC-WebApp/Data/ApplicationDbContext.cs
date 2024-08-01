
﻿using AspDotNet_Core_MVC_WebApp.Models;
using Microsoft.EntityFrameworkCore;

﻿using Microsoft.EntityFrameworkCore;


namespace AspDotNet_Core_MVC_WebApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }


        public DbSet<Category> Catogries {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = "1" },
                 new Category { Id = 2, Name = "Scifi", DisplayOrder = "1" },
                  new Category { Id = 3, Name = "History", DisplayOrder = "1" }
                );
        }

    }
}
