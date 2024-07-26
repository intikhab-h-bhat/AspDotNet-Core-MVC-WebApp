using Microsoft.EntityFrameworkCore;

namespace AspDotNet_Core_MVC_WebApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }


    }
}
