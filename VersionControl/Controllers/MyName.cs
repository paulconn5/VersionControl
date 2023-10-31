using Microsoft.AspNetCore.Mvc;

namespace VersionControl.Controllers
{
    public class MyName : Controller
    {
        public IActionResult Index()
        {
            string name = "Paul Connolly";
            return Json(name);
        }
    }
}
