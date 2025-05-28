using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEFCore_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
    }
}
