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
    public class IndexModel : PageModel
    {
        private readonly ShowDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        public List<Show> Shows {get; set;}
        public List<Character> Characters {get; set;}

        public IndexModel(ShowDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Shows = _context.Shows.ToList();
            Characters = _context.Characters.ToList();
        }
    }
}
