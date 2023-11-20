using Microsoft.AspNetCore.Mvc;

namespace SGLicitacoes.Controllers
{
    public class BiddingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
