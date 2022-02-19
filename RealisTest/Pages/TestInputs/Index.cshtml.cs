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
    public class IndexModel : PageModel
    {
        private readonly RealisTest.Data.RealisTestContext _context;

        public IndexModel(RealisTest.Data.RealisTestContext context)
        {
            _context = context;
        }

        public IList<TestInput> TestInput { get;set; }

        public async Task OnGetAsync()
        {
            TestInput = await _context.TestInput.ToListAsync();
        }
    }
}
