using Microsoft.AspNetCore.Mvc;
using StudentPortal_MVC_CRUD.Data;
using StudentPortal_MVC_CRUD.Models;
using StudentPortal_MVC_CRUD.Models.Entities;

namespace StudentPortal_MVC_CRUD.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public AssignmentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddAssignmentViewModel viewModel)
        {
            var assignment = new Assignment
            {
                AssignmentNumber = viewModel.AssignmentNumber,
                AssignmentSem = viewModel.AssignmentSem,
                AssignmentContent = viewModel.AssignmentContent
            };

            await dbContext.Assignment.AddAsync(assignment);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("Index");

        }
    }


}
