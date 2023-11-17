
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace RazorPageStudent.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string StudentName { get; set; } = string.Empty;

        public int RollNo { get; set; }

        public string Gender { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public int? StaffId { get; set; } 

        public Staff? Staff { get; set; }

        public ICollection<Staff>? Staffs { get; set; }


    }
}
