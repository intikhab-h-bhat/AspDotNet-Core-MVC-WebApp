
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


    }
}
