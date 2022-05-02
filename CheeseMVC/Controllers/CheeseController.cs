using CheeseMVC.Data;
using CheeseMVC.Models;
using CheeseMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {        
        public IActionResult Index()
        {

            ViewBag.title = "My Cheeses";
            List<Cheese> cheeses = CheeseData.GetAll();            ;

            return View(cheeses);
        }

        public IActionResult Add()
        {
            AddCheeseViewModel addCheeseViewModel = new AddCheeseViewModel();
            ViewBag.title = "Add Cheese";
            return View(addCheeseViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCheeseViewModel addCheeseViewModel)
        {
            if (ModelState.IsValid)
            {
                Cheese newCheese = new Cheese
                {
                    Name = addCheeseViewModel.Name,
                    Description = addCheeseViewModel.Description,
                    Type = addCheeseViewModel.Type
                };
                CheeseData.Add(newCheese);
                return RedirectToAction("Index");
            }

            
            return View(addCheeseViewModel);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Cheeses";
            ViewBag.Cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] cheeseIds)
        {
            foreach (int item in cheeseIds)
            {
                CheeseData.Remove(item);
            }

            return RedirectToAction("Index");
        }
    }
}
