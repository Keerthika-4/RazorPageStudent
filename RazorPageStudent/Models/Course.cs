
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace RazorPageStudent.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string CourseName { get; set; } = string.Empty;

        public string Duration { get; set; } = string.Empty;

        public int Fees { get; set; }

        [ForeignKey("StudentId")]
        public Student? Names { get; set; }

        public int? StudentId { get; set; }

  

    }
}
