using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace FinalProject.Models
{
    public class Show
    {
        public int ShowID {get; set;}
        [BindProperty]
        [Required]
        public string Title {get; set;}
        [BindProperty]
        [Required]
        public string Genre {get; set;}
        [BindProperty]
        [Required]
        public DateTime ReleaseDate {get; set;}
        public List<Character> Characters {get; set;}
    }
}