using System.ComponentModel.DataAnnotations;

namespace StudentApi.DTOs
{
    public class UpdateStudentDto
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        [Range(18, 60)]
        public int Age { get; set; }
    }
}