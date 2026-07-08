using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentApi.Data;
using StudentApi.DTOs;
using StudentApi.Models;

namespace StudentApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<StudentService> _logger;

        public StudentService(
            ApplicationDbContext context,
            ILogger<StudentService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<StudentDto>> GetAllStudentsAsync()
        {
            _logger.LogInformation("Fetching all students.");

            return await _context.Students
                .Select(s => new StudentDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Age = s.Age
                })
                .ToListAsync();
        }

        public async Task<StudentDto?> GetStudentByIdAsync(int id)
        {
            _logger.LogInformation("Fetching student with ID {Id}.", id);

            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                _logger.LogWarning("Student with ID {Id} not found.", id);
                return null;
            }

            return new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age
            };
        }

        public async Task<StudentDto> AddStudentAsync(CreateStudentDto dto)
        {
            _logger.LogInformation("Adding a new student.");

            var student = new Student
            {
                Name = dto.Name,
                Age = dto.Age
            };

            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            _logger.LogInformation("Student created successfully with ID {Id}.", student.Id);

            return new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age
            };
        }

        public async Task<bool> UpdateStudentAsync(int id, UpdateStudentDto dto)
        {
            _logger.LogInformation("Updating student with ID {Id}.", id);

            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                _logger.LogWarning("Student with ID {Id} not found.", id);
                return false;
            }

            student.Name = dto.Name;
            student.Age = dto.Age;

            await _context.SaveChangesAsync();

            _logger.LogInformation("Student with ID {Id} updated successfully.", id);

            return true;
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            _logger.LogInformation("Deleting student with ID {Id}.", id);

            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                _logger.LogWarning("Student with ID {Id} not found.", id);
                return false;
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            _logger.LogInformation("Student with ID {Id} deleted successfully.", id);

            return true;
        }
    }
}