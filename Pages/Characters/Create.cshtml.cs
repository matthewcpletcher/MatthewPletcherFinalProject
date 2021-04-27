using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalProject.Models;

namespace MatthewPletcherFinalProject.Characters
{
    public class CreateModel : PageModel
    {
        private readonly FinalProject.Models.ShowDbContext _context;

        public CreateModel(FinalProject.Models.ShowDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ShowID"] = new SelectList(_context.Shows, "ShowID", "Genre");
            return Page();
        }

        [BindProperty]
        public Character Character { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Characters.Add(Character);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
