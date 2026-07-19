using StudentApi.Models;

namespace StudentApi.Interfaces
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudentsAsync();

        Task<Student> AddStudentAsync(Student student);

        Task<List<Student>> GetStudentsAbove20Async();

        Task<List<Student>> GetStudentsOrderedByAgeAsync();

        Task<List<Student>> GetStudentsOrderedByAgeDescendingAsync();

        Task<Student?> GetStudentByIdAsync(int id);

        Task<int> GetStudentCountAsync();

        Task<bool> HasStudentsAbove23Async();

        Task<List<string>> GetStudentNamesAsync();
    }
}