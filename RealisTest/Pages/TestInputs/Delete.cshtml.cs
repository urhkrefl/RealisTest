#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealisTest.Data;
using RealisTest.Models;

namespace RealisTest.Pages.TestInputs
{
    public class DeleteModel : PageModel
    {
        private readonly RealisTest.Data.RealisTestContext _context;

        public DeleteModel(RealisTest.Data.RealisTestContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TestInput TestInput { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TestInput = await _context.TestInput.FirstOrDefaultAsync(m => m.Id == id);

            if (TestInput == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TestInput = await _context.TestInput.FindAsync(id);

            if (TestInput != null)
            {
                _context.TestInput.Remove(TestInput);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
