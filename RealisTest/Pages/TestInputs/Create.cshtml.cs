#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealisTest.Data;
using RealisTest.Models;

namespace RealisTest.Pages.TestInputs
{
    public class CreateModel : PageModel
    {
        private readonly RealisTest.Data.RealisTestContext _context;

        public CreateModel(RealisTest.Data.RealisTestContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TestInput TestInput { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TestInput.Add(TestInput);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
