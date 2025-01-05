using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                AssignmentContent = viewModel.AssignmentContent,
                Subject = viewModel.Subject
            };

            await dbContext.Assignment.AddAsync(assignment);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List", "Assignment");

        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var assignment = await dbContext.Assignment.ToListAsync();
            return View(assignment);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var assignment = await dbContext.Assignment.FindAsync(id);
            return View(assignment);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Assignment viewModel)
        {
            var assignment = await dbContext.Assignment.FindAsync(viewModel.AssignmentId);

            if (assignment != null)
            {
                assignment.AssignmentNumber = viewModel.AssignmentNumber;
                assignment.AssignmentSem = viewModel.AssignmentSem;
                assignment.AssignmentContent = viewModel.AssignmentContent;
                assignment.Subject = viewModel.Subject;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Assignment");
        }

    }


}
