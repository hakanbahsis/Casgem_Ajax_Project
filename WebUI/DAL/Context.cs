using Microsoft.EntityFrameworkCore;

namespace WebUI.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-PK98KLS; initial catalog = CasgemAjaxDb; integrated security = true;");                     
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
