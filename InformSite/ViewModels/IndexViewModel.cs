using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformSite.Models;

namespace InformSite.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
