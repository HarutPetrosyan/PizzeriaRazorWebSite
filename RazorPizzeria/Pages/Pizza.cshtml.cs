using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> FakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle = "Hawaiian",
                PizzaName = "Hawaiian", 
                BasePrice = 2, 
                Cheese = true, 
                TomatoSouse = true, 
                FinalPrice = 4
            },
            new PizzasModel()
            {
                ImageTitle = "Bolognese",
                PizzaName = "Bolognese",
                BasePrice = 2,
                Cheese = true,
                TomatoSouse = true,
                Beef = true,
                FinalPrice = 5
            },
            new PizzasModel()
            {
                ImageTitle = "Carbonara",
                PizzaName = "Carbonara",
                BasePrice = 3,
                Ham = true,
                TomatoSouse = true,
                FinalPrice = 5
            },
            new PizzasModel()
            {
                ImageTitle = "Margethite",
                PizzaName = "Margethite",
                BasePrice = 4,
                Cheese = true,
                TomatoSouse = true,
                Mashroom = true,
                FinalPrice = 7
            },
            new PizzasModel()
            {
                ImageTitle = "MeatFeast",
                PizzaName = "MeatFeast",
                BasePrice = 5,
                Ham = true,
                Mashroom = true,
                Tuna = true,
                TomatoSouse = true,
                FinalPrice = 9
            },
            new PizzasModel()
            {
                ImageTitle = "MushRoom",
                PizzaName = "MushRoom",
                BasePrice = 2,
                Mashroom = true,
                Tuna = true,
                Cheese = true,
                TomatoSouse = true,
                FinalPrice = 6
            },
            new PizzasModel()
            {
                ImageTitle = "Pepperoni",
                PizzaName = "Pepperoni",
                BasePrice = 2,
                Peperoni = true,
                Beef = true,
                Cheese = true,
                TomatoSouse = true,
                FinalPrice = 6
            },
            new PizzasModel()
            {
                ImageTitle = "SeaFood",
                PizzaName = "SeaFood",
                BasePrice = 10,
                Cheese = true,
                TomatoSouse = true,
                Pineapple = true,
                Ham = true,
                Tuna = true,
                FinalPrice = 23
            },
            new PizzasModel()
            {
                ImageTitle = "Vegetarian",
                PizzaName = "Vegetarian",
                BasePrice = 4,
                Tuna = true,
                TomatoSouse = true,
                FinalPrice = 4
            }

        };

        public void OnGet()
        {
        }
    }
}
