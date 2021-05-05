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
        public string SearchTerm {get; set;}

        public IList<Character> Character { get;set; }
        public List<Show> Shows {get; set;}

        [BindProperty(SupportsGet=true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} =10;
        public int CurrentPage {get; set;}

        [BindProperty(SupportsGet=true)]
        public string CurrentSort {get; set;}
        public async Task OnGetAsync()
        {
            Shows = _context.Shows.ToList();
            var query = _context.Characters.Select(p => p);

            switch (CurrentSort)
            {
                case "name_asc":
                    query = query.OrderBy(p => p.Name);
                    break;
                case "name_desc":
                    query = query.OrderByDescending(p => p.Name);
                    break;
            }
            CurrentPage = PageNum;
            Character = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
