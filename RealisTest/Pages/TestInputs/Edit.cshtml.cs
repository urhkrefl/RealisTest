#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealisTest.Data;
using RealisTest.Models;

namespace RealisTest.Pages.TestInputs
{
    public class EditModel : PageModel
    {
        private readonly RealisTest.Data.RealisTestContext _context;

        public EditModel(RealisTest.Data.RealisTestContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TestInput).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestInputExists(TestInput.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TestInputExists(int id)
        {
            return _context.TestInput.Any(e => e.Id == id);
        }
    }
}
