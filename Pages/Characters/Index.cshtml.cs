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
        //List of Characters
        public IList<Character> Character { get;set; }
        public List<Show> Shows {get; set;}
        //Properties for the Page Number and Size

        [BindProperty(SupportsGet=true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} =10;
        public int CurrentPage {get; set;}

        [BindProperty(SupportsGet=true)]
        public string CurrentSort {get; set;}
        public string searchString {get; set;}
        public async Task OnGetAsync()
        {
            Shows = _context.Shows.ToList();
            var query = _context.Characters.Select(p => p);

            //sorting
            switch (CurrentSort)
            {
                case "name_asc":
                    query = query.OrderBy(p => p.Name);
                    break;
                case "name_desc":
                    query = query.OrderByDescending(p => p.Name);
                    break;
            }

            //paging
            CurrentPage = PageNum;
            Character = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();

            //Non working search functions
            IQueryable<Character> searchChar = from s in _context.Characters select s;  
            if(!String.IsNullOrEmpty(searchString)){
            searchChar = searchChar.Where(s => s.Name.Contains(searchString));
            }


        }
    }
}
