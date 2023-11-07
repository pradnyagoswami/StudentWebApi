using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentWebApi.Model
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Rollno { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Percentage { get; set; }
        [Required]
        public string? City { get; set; }
    }
}
