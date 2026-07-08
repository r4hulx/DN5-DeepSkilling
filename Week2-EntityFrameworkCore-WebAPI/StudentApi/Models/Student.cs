using System.ComponentModel.DataAnnotations;

namespace StudentApi.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; } = string.Empty;

        [Range(18, 60,
            ErrorMessage = "Age must be between 18 and 60.")]
        public int Age { get; set; }
    }
}