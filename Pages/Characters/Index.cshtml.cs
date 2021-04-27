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
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.ShowDbContext _context;

        public IndexModel(FinalProject.Models.ShowDbContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; }

        [BindProperty(SupportsGet=true)]
        public int PageNum {get; set;}
        public int PageSize {get; set;}

        public async Task OnGetAsync()
        {
            Character = await _context.Characters.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
