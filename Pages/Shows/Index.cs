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
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.ShowDbContext _context;

        public IndexModel(FinalProject.Models.ShowDbContext context)
        {
            _context = context;
        }

        public IList<Show> Show { get;set; }

        public async Task OnGetAsync()
        {
            Show = await _context.Shows.ToListAsync();
        }
    }
}
