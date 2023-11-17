using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageStudent.Data;
using RazorPageStudent.Models;

namespace RazorPageStudent.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageStudent.Data.RazorPageStudentContext _context;

        public DetailsModel(RazorPageStudent.Data.RazorPageStudentContext context)
        {
            _context = context;
        }

      public Course Course { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Course == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }
            else 
            {
                Course = course;
            }
            return Page();
        }
    }
}
