
using InformSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace InformSite.Models
{
    public class Project
    {

        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StartPrice { get; set; }
        public int FinalPrice { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

    }



}
