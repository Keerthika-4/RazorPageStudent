using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageStudent.Data;
using RazorPageStudent.Models;

namespace RazorPageStudent.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageStudent.Data.RazorPageStudentContext _context;

        public IndexModel(RazorPageStudent.Data.RazorPageStudentContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.Include(s => s.Staff).Include(s => s.Staffs).ToListAsync();
            }
        }
    }
}
