using Microsoft.AspNetCore.Mvc;

namespace StudentPortal_MVC_CRUD.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
