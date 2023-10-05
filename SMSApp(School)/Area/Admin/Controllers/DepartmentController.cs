using Microsoft.AspNetCore.Mvc;

namespace SMSApp_School_.Area.Admin.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
