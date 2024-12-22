using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal_MVC_CRUD.Data;
using StudentPortal_MVC_CRUD.Models;
using StudentPortal_MVC_CRUD.Models.Entities;

namespace StudentPortal_MVC_CRUD.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public TeachersController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddTeacherViewModel viewModel)
        {
            var teacher = new Teacher
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone
            };

            await dbContext.Teachers.AddAsync(teacher);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List", "Teachers");
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var teachers = await dbContext.Teachers.ToListAsync();
            return View(teachers);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var teacher = await dbContext.Teachers.FindAsync(id);
            return View(teacher);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Teacher viewModel)
        {
            var teacher = await dbContext.Teachers.FindAsync(viewModel.TeacherId);

            if (teacher != null)
            {
                teacher.Name = viewModel.Name;
                teacher.Email = viewModel.Email;
                teacher.Phone = viewModel.Phone;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Teachers");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Teacher viewModel)
        {
            var teacher = await dbContext.Teachers.AsNoTracking().FirstOrDefaultAsync(x => x.TeacherId == viewModel.TeacherId);

            if (teacher != null)
            {
                dbContext.Teachers.Remove(viewModel);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Teachers");

        }
    }
}
