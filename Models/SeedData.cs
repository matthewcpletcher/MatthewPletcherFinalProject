using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ShowDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ShowDbContext>>()))
            {
                if (context.Shows.Any())
                {
                    return;
                }

                context.Shows.AddRange(
                    new Show
                    {
                        Title = "Attack on Titan",
                        Genre = "Action",
                        ReleaseDate = DateTime.Parse("9/9/2009")
                    },
                    new Show
                    {
                        Title = "Naruto",
                        Genre = "Adventure",
                        ReleaseDate = DateTime.Parse("9/21/1999")
                    },
                    new Show
                    {
                        Title = "House",
                        Genre = "Medical Drama",
                        ReleaseDate = DateTime.Parse("11/16/2004")
                    }
                );                                                                                                                                                                                                                                                                                                                                                                                                                                                
                context.SaveChanges();
            }
            using (var context = new ShowDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ShowDbContext>>()))
            {
                if (context.Characters.Any())
                {
                    return;
                }

                context.Characters.AddRange(
                    new Character
                    {
                        Name = "Eren Yeager",
                        Age = 19,
                        Gender = "Male",
                        ShowID = 1,
                    },
                    new Character
                    {
                        Name = "Levi Ackerman",
                        Age = 35,
                        Gender = "Male",
                        ShowID = 1,
                    },
                    new Character
                    {
                        Name = "Mikasa Ackerman",
                        Age = 19,
                        Gender = "Female",
                        ShowID = 1,
                    },
                    new Character
                    {
                        Name = "Armin Arlert",
                        Age = 19,
                        Gender = "Male",
                        ShowID = 1,
                    },   
                    new Character
                    {
                        Name = "Erwin Smith",
                        Age = 34,
                        Gender = "Male",
                        ShowID = 1,
                    },  
                    new Character
                    {
                        Name = "Jean Kirstein",
                        Age = 20,
                        Gender = "Male",
                        ShowID = 1,
                    },     
                    new Character
                    {
                        Name = "Connie Springer",
                        Age = 19,
                        Gender = "Male",
                        ShowID = 1,
                    },    
                    new Character
                    {
                        Name = "Historia Reiss",
                        Age = 19,
                        Gender = "Female",
                        ShowID = 1,
                    },
                    new Character
                    {
                        Name = "Mikasa Ackerman",
                        Age = 19,
                        Gender = "Female",
                        ShowID = 1,
                    },  
                    new Character
                    {
                        Name = "Naruto Uzumaki",
                        Age = 12,
                        Gender = "Male",
                        ShowID = 2,
                    }, 
                    new Character
                    {
                        Name = "Sauske Uchiha",
                        Age = 12,
                        Gender = "Male",
                        ShowID = 2,
                    },   
                    new Character
                    {
                        Name = "Itachi Uchiha",
                        Age = 17,
                        Gender = "Male",
                        ShowID = 2,
                    },   
                    new Character
                    {
                        Name = "Kakashi Hatake",
                        Age = 26,
                        Gender = "Male",
                        ShowID = 2,
                    },    
                    new Character
                    {
                        Name = "Hinata Hyuga",
                        Age = 12,
                        Gender = "Female",
                        ShowID = 2,
                    },  
                    new Character
                    {
                        Name = "Tsunade Senju",
                        Age = 51,
                        Gender = "Female",
                        ShowID = 2,
                    },  
                    new Character
                    {
                        Name = "Sakura Haruno",
                        Age = 12,
                        Gender = "Female",
                        ShowID = 2,
                    },  
                    new Character
                    {
                        Name = "Gaara",
                        Age = 12,
                        Gender = "Male",
                        ShowID = 2,
                    }, 
                    new Character
                    {
                        Name = "Oroichimaru",
                        Age = 51,
                        Gender = "Male",
                        ShowID = 2,
                    }, 
                    new Character
                    {
                        Name = "Gergory House",
                        Age = 45,
                        Gender = "Male",
                        ShowID = 3,
                    }, 
                    new Character
                    {
                        Name = "Lawrence Kutner",
                        Age = 28,
                        Gender = "Male",
                        ShowID = 3,
                    },
                    new Character
                    {
                        Name = "Allison Cameron",
                        Age = 33,
                        Gender = "Female",
                        ShowID = 3,
                    },         
                    new Character
                    {
                        Name = "Lisa Cuddy",
                        Age = 46,
                        Gender = "Female",
                        ShowID = 3,
                    },  
                    new Character
                    {
                        Name = "Robert Chase",
                        Age = 35,
                        Gender = "Male",
                        ShowID = 3,
                    },  
                    new Character
                    {
                        Name = "James Wilson",
                        Age = 45,
                        Gender = "Male",
                        ShowID = 3,
                    },     
                    new Character
                    {
                        Name = "Eric Foreman",
                        Age = 34,
                        Gender = "Male",
                        ShowID = 3,
                    },             
                    new Character
                    {
                        Name = "Chris Taub",
                        Age = 45,
                        Gender = "Male",
                        ShowID = 3,
                    }                          
                );
                context.SaveChanges();
            }
        }
    }
}