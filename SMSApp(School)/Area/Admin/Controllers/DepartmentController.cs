using Microsoft.AspNetCore.Mvc;
using SMSApp_School_.Area.Admin.Interface;

namespace SMSApp_School_.Area.Admin.Controllers
{
    [Area("Admin")]
    public class DepartmentController : Controller
    {
        private readonly IDepartment _department = null;
        public DepartmentController(IDepartment DepartmentRepository)
        {
            _department = DepartmentRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
