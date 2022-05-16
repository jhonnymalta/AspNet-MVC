using _003_RestSharp.Models;
using _003_RestSharp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _003_RestSharp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoryProducts repositoryProducts;

        public HomeController(ILogger<HomeController> logger, IRepositoryProducts repositoryProducts)
        {
            _logger = logger;
            this.repositoryProducts = repositoryProducts;
        }



        public ActionResult<List<Product>> Index()
        {           
            var produtos = repositoryProducts.GetAllProducts().Result;            
            return View(produtos);
        }
        [HttpGet()]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("/novoproduto")]
        public  IActionResult CreateProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            repositoryProducts.PostProduct(product);
            return RedirectToAction("Index");
            
        }
       
        [HttpGet]
        public IActionResult Delete(int id)
        {
           var produto = repositoryProducts.GetByID(id).Result;
            return View(produto);

        }

        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            if(id != null)  
            {
                repositoryProducts.Delete(id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}