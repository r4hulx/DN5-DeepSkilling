using Microsoft.AspNetCore.Mvc;
using StudentApi.Interfaces;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _studentService.GetAllStudentsAsync();
            return Ok(students);
        }

        [HttpGet("above20")]
        public async Task<IActionResult> GetStudentsAbove20()
        {
            var students = await _studentService.GetStudentsAbove20Async();
            return Ok(students);
        }
        [HttpGet("orderbyage")]
        public async Task<IActionResult> GetStudentsOrderedByAge()
        {
            var students = await _studentService.GetStudentsOrderedByAgeAsync();
            return Ok(students);
        }
        [HttpGet("orderbyagedesc")]
        public async Task<IActionResult> GetStudentsOrderedByAgeDescending()
        {
            var students = await _studentService.GetStudentsOrderedByAgeDescendingAsync();
            return Ok(students);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _studentService.GetStudentByIdAsync(id);

            if (student == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }

            return Ok(student);
        }
        [HttpGet("count")]
        public async Task<IActionResult> GetStudentCount()
        {
            var count = await _studentService.GetStudentCountAsync();

            return Ok(count);
        }
        [HttpGet("hasstudentsabove23")]
        public async Task<IActionResult> HasStudentsAbove23()
        {
            var result = await _studentService.HasStudentsAbove23Async();

            return Ok(result);
        }
        [HttpGet("names")]
        public async Task<IActionResult> GetStudentNames()
        {
            var names = await _studentService.GetStudentNamesAsync();

            return Ok(names);
        }
        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            var createdStudent = await _studentService.AddStudentAsync(student);
            return Ok(createdStudent);
        }
    }
}