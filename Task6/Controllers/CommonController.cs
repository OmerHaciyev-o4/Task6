using Microsoft.AspNetCore.Mvc;

namespace Task6.Controllers
{
    public class CommonController : Controller
    {
        [Route("/error")]
        public IActionResult CanNotFind()
        {
            return View();
        }
    }
}
