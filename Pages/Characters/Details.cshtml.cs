using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace MatthewPletcherFinalProject.Characters
{
    public class DetailsModel : PageModel
    {
        private readonly FinalProject.Models.ShowDbContext _context;

        public DetailsModel(FinalProject.Models.ShowDbContext context)
        {
            _context = context;
        }

        public Character Character { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Character = await _context.Characters
                .Include(c => c.Show).FirstOrDefaultAsync(m => m.CharacterID == id);

            if (Character == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
