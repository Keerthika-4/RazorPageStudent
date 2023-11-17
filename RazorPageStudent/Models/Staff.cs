using System.ComponentModel.DataAnnotations;

namespace RazorPageStudent.Models
{
    public class Staff
    {
        public int Id { get; set; }

        public string StaffName { get; set; } = string.Empty;

        public int Salary { get; set; }

        [DataType(DataType.Date)]
        public DateTime JoiningDate {get; set; }

        public ICollection<Student>? Students { get; set; }

        public ICollection<Student>? Student { get; set; }
    }
}
