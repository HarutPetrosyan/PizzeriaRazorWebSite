using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Models;

namespace RazorPizzeria.Data
{
    public class AplicationDBContext:DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options):base(options)
        {
            
        }
    }
}
