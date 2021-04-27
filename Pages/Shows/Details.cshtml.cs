using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace MatthewPletcherFinalProject._Pages.Shows
{
    public class DetailsModel : PageModel
    {
        private readonly FinalProject.Models.ShowDbContext _context;

        public DetailsModel(FinalProject.Models.ShowDbContext context)
        {
            _context = context;
        }

        public Show Show { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Show = await _context.Shows.FirstOrDefaultAsync(m => m.ShowID == id);

            if (Show == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
