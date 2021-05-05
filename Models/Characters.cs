using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FinalProject.Models
{
    public class Character
    {
        public int CharacterID {get; set;}
        [BindProperty]
        [Required]
        public string Name {get; set;}
        [BindProperty]
        [Required]
        public int Age {get; set;}
        [BindProperty]
        [Required]
        public string Gender {get; set;}
        [BindProperty]
        [Required]
        public Show Show {get; set;}
        public int ShowID {get; set;}
        
    }
}