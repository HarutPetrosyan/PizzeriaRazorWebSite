using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Orders
{
    public class OrdersModel : PageModel
    {
        private readonly AplicationDBContext _context;
        public List<PizzaOrder> PizzaOrders =new List<PizzaOrder>();

        public OrdersModel(AplicationDBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            PizzaOrders=_context.PizzaOrders.ToList();
        }
    }
}
