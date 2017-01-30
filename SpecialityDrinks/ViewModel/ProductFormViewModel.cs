using System;
using System.ComponentModel.DataAnnotations;

namespace SpecialityDrinks.ViewModel
{
    public class ProductFormViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "The product name is too long")]
        public string Name { get; set; }

        public string Brand { get; set; }
        [Required]
        public double Size { get; set; }

        [Required(ErrorMessage = "The strength percentage must be between 0 and 100")]
        [Range(0, 100)]
        public double Strength { get; set; }

        public decimal Price { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Updated { get; set; }

        public string Title => Id != 0 ? "Update Product Details" : "New Product";
    }
}