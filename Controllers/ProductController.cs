using ClothesShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClothesShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details(int id)
        {
            var product = new Product
            {
                Id = id,
                Name = "Santa Claus",
                Description = "Праздничная картина деда мороза с подарком и звездами.",
                Price = 199.99m,
                ImageUrl = "https://png.pngtree.com/png-vector/20240918/ourlarge/pngtree-festive-santa-claus-painting-with-gift-and-stars-png-image_13696795.png"
            };

            return View("ProductDetails", product);
        }

        public IActionResult AddReview(string userName, string reviewText)
        {
            Console.WriteLine($"Отзыв от {userName}: {reviewText}");

            return RedirectToAction("Details", new { id = 1 });
        }
    }
}
