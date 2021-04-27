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
    public class DeleteModel : PageModel
    {
        private readonly FinalProject.Models.ShowDbContext _context;

        public DeleteModel(FinalProject.Models.ShowDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Character = await _context.Characters.FindAsync(id);

            if (Character != null)
            {
                _context.Characters.Remove(Character);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
