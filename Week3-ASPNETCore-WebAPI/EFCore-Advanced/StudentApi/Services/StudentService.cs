using Microsoft.EntityFrameworkCore;
using StudentApi.Data;
using StudentApi.Interfaces;
using StudentApi.Models;

namespace StudentApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            _context.Students.Add(student);

            await _context.SaveChangesAsync();

            return student;
        }
        public async Task<List<Student>> GetStudentsOrderedByAgeAsync()
        {
            return await _context.Students
                .OrderBy(student => student.Age)
                .ToListAsync();
        }
        public async Task<List<Student>> GetStudentsOrderedByAgeDescendingAsync()
        {
            return await _context.Students
                .OrderByDescending(student => student.Age)
                .ToListAsync();
        }
        public async Task<Student?> GetStudentByIdAsync(int id)
        {
            return await _context.Students
                .FirstOrDefaultAsync(student => student.Id == id);
        }
        public async Task<int> GetStudentCountAsync()
        {
            return await _context.Students.CountAsync();
        }
        public async Task<bool> HasStudentsAbove23Async()
        {
            return await _context.Students.AnyAsync(student => student.Age > 23);
        }
        public async Task<List<string>> GetStudentNamesAsync()
        {
            return await _context.Students
                .Select(student => student.Name)
                .ToListAsync();
        }
        public async Task<List<Student>> GetStudentsAbove20Async()
        {
            return await _context.Students
                .Where(student => student.Age > 20)
                .ToListAsync();
        }
    }
}