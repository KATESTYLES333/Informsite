﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InformSite.Models;
using InformSite.ViewModels;

namespace InformSite
{
    public class IndexModel : PageModel
    {
        private readonly InformSite.Models.ApplicationContext _context;

        public IndexModel(InformSite.Models.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
