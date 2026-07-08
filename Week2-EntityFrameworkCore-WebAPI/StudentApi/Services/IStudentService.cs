using StudentApi.DTOs;

namespace StudentApi.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetAllStudentsAsync();

        Task<StudentDto?> GetStudentByIdAsync(int id);

        Task<StudentDto> AddStudentAsync(CreateStudentDto dto);

        Task<bool> UpdateStudentAsync(int id, UpdateStudentDto dto);

        Task<bool> DeleteStudentAsync(int id);
    }
}