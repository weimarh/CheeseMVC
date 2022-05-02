using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CheeseMVC.ViewModel
{
    public class AddCheeseViewModel
    {
        [Required(ErrorMessage ="Tiene que ingresar un nombre de queso valido")]
        [Display(Name ="Nombre del queso")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Tiene que ingresar una descripcion")]
        [Display(Name ="Descripcion")]
        [StringLength(50)]
        public string Description { get; set; }

        public CheeseType Type { get; set; }

        public List<SelectListItem> CheeseTypes { get; set; }

        public AddCheeseViewModel()
        {
            CheeseTypes = new List<SelectListItem>();

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int) CheeseType.Hard).ToString(),
                Text = CheeseType.Hard.ToString(),
            });

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.Soft).ToString(),
                Text = CheeseType.Soft.ToString(),
            });

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.Fake).ToString(),
                Text = CheeseType.Fake.ToString(),
            });
        }

    }
}
