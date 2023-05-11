using InformSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformSite.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }

        public IEnumerable<Project> Projects { get; set; }

        public Category()
        {
            Projects = new List<Project>();
        }

    }
}
