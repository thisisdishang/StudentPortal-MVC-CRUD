using Microsoft.AspNetCore.Mvc;
using StudentPortal_MVC_CRUD.Data;

namespace StudentPortal_MVC_CRUD.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public TeachersController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
