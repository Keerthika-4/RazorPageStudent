using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageStudent.Data;
using RazorPageStudent.Models;

namespace RazorPageStudent.Pages.Staffs
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageStudent.Data.RazorPageStudentContext _context;

        public DetailsModel(RazorPageStudent.Data.RazorPageStudentContext context)
        {
            _context = context;
        }

      public Staff Staff { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Staff == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff.FirstOrDefaultAsync(m => m.Id == id);
            if (staff == null)
            {
                return NotFound();
            }
            else 
            {
                Staff = staff;
            }
            return Page();
        }
    }
}
