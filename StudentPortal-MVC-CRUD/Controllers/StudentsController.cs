using Microsoft.AspNetCore.Mvc;
using StudentPortal_MVC_CRUD.Data;
using StudentPortal_MVC_CRUD.Models;
using StudentPortal_MVC_CRUD.Models.Entities;

namespace StudentPortal_MVC_CRUD.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbContex;

        public StudentsController(ApplicationDbContext dbContex)
        {
            this.dbContex = dbContex;
        }

        public ApplicationDbContext DbContext { get; }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed
            };

            await dbContex.Students.AddAsync(student);
            await dbContex.SaveChangesAsync();


            return View();
        }
    }
}
