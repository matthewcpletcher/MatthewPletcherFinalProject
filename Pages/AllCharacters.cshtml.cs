using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace MatthewPletcherFinalProject.Pages
{
    public class AllCharacterModel : PageModel
    {
        private readonly ShowDbContext _context;
        private readonly ILogger<AllCharacterModel> _logger;
        public List<Show> Shows {get; set;}
        public List<Character> Characters {get; set;}

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} =1;
        public int PageSize {get; set;} = 10;

        public AllCharacterModel(ShowDbContext context, ILogger<AllCharacterModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            Characters = await _context.Characters.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            Shows = _context.Shows.ToList();
            Characters = _context.Characters.ToList();
        }
    }
}
