using System;

namespace FinalProject.Models
{
    public class Character
    {
        public int CharacterID {get; set;}
        public string Name {get; set;}
        public int Age {get; set;}
        public string Gender {get; set;}
        public Show Show {get; set;}
        public int ShowID {get; set;}
    }
}