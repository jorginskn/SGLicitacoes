using Microsoft.AspNetCore.Mvc;

namespace SGLicitacoes.Controllers
{
    public class BiddingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult EditBid()
        {
            return View();
        }

        public IActionResult DeleteBid()
        {
            return View();
        }
    }
}
