using InformSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformSite.ViewModels
{
    public class ProjectViewModel
    {

            public int CategoryId { get; set; }
            public string Title { get; set; }

            public IEnumerable<Project> Projects { get; set; }

     

            public int ProjectId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int StartPrice { get; set; }
            public int FinalPrice { get; set; }

  
            public Category Category { get; set; }

            public string UserId { get; set; }
            public User User { get; set; }


        
    }
}
