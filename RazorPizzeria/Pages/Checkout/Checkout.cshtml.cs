using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        private readonly AplicationDBContext _context;
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string  ImageTitle { get; set; }

        public CheckoutModel(AplicationDBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }

            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
            PizzaOrder order = new PizzaOrder();
            order.PizzaName = PizzaName;
            order.BasePrice = PizzaPrice;
            _context.PizzaOrders.Add(order);
            _context.SaveChanges();
        }
        


    }
}
