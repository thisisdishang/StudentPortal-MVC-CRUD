using Microsoft.AspNetCore.Mvc;

namespace StudentPortal_MVC_CRUD.Controllers
{
    public class AssignmentController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
