using System;
using System.Linq;
using System.Web.Mvc;
using RedWillow.MvcToastrFlash;
using SpecialityDrinks.DAL.NewSpecialityDrinkDBTableAdapters;
using SpecialityDrinks.ViewModel;

namespace SpecialityDrinks.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductsTableAdapter _context;

        public ProductController()
        {
            _context = new ProductsTableAdapter();
        }

        // GET: Product
        public ActionResult Index()
        {


            return View();
        }
        public ActionResult ProductBasket()
        {
            return View();
        }


        public ActionResult Products()
        {

            return View();
        }

        public ActionResult Edit(int id)
        {

            var dt = _context.GetAllProducts().SingleOrDefault(p => p.ProductID == id);

            var test = _context.GetAllProducts().GroupBy(p => p.Size, (groupkey) => new { key = groupkey });
             
                                                                          

            if (dt == null)
                return HttpNotFound();

            var viewModel = new ProductFormViewModel
            {
                Name = dt.Name,
                Brand = dt.Brand,
                Size = dt.Size,
                Strength = dt.Strength,
                Price = dt.Price,
                Created = dt.Created
            };

            return View("ProductForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(ProductFormViewModel product)
        {
            if (!ModelState.IsValid)
            {
                var viewModal = new ProductFormViewModel
                {
                    Name = product.Name,
                    Brand = product.Brand,
                    Size = product.Size,
                    Strength = product.Strength,
                    Price = product.Price,
                };
                this.Flash(Toastr.ERROR, " Product Failed");

                return View("ProductForm", viewModal);
            }

            if (product.Id == 0)
            {

                _context.InsertProduct(product.Name,
                    product.Brand,
                    product.Size,
                    product.Strength,
                    product.Price, DateTime.Now, DateTime.Now
                    );

                this.Flash(Toastr.SUCCESS, "You Successfully Created A Product");
            }
            else
            {
                _context.UpdateProduct(
                    product.Name,
                    product.Brand,
                    product.Size,
                    product.Strength,
                    product.Price,
                    product.Created, DateTime.Now, product.Id

                    );
                this.Flash(Toastr.SUCCESS, "You Successfully Updated " + product.Name);
            }

            return RedirectToAction("Index", "Home");

        }

        public ActionResult AddProduct()
        {
            var viewModal = new ProductFormViewModel();


            return View("ProductForm", viewModal);
        }
    }
}