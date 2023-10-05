using Microsoft.AspNetCore.Mvc;

namespace SMSApp_School_.Area.Admin.Controllers
{
    public class SchoolManagementCommitteeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
