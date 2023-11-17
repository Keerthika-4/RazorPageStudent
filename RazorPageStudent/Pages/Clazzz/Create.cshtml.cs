using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageStudent.Data;
using RazorPageStudent.Models;

namespace RazorPageStudent.Pages.Clazzz
{
    public class CreateModel : PageModel
    {
        private readonly RazorPageStudent.Data.RazorPageStudentContext _context;

        public CreateModel(RazorPageStudent.Data.RazorPageStudentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Clazz Clazz { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Clazz == null || Clazz == null)
            {
                return Page();
            }

            _context.Clazz.Add(Clazz);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
