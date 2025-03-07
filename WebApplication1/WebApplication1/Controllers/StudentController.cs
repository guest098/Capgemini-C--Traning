using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetStudents()
        {
            return _context.Students.ToList();
        }

        [HttpPost]
        public ActionResult<Student> AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Ok(student);
        }
    }
}
