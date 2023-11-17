using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageStudent.Data;
using RazorPageStudent.Models;

namespace RazorPageStudent.Pages.Clazzz
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageStudent.Data.RazorPageStudentContext _context;

        public IndexModel(RazorPageStudent.Data.RazorPageStudentContext context)
        {
            _context = context;
        }

        public IList<Clazz> Clazz { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Clazz != null)
            {
                Clazz = await _context.Clazz.ToListAsync();
            }
        }
    }
}
