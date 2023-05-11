using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InformSite.Models
{
    public class Order
    {
       // public IEnumerable<Project> Projects { get; set; }
        public SelectList Categories { get; set; }
    }
}
