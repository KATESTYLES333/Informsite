using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace InformSite.Models
{
        public class User : IdentityUser
        {
            public string Fio { get; set; }

    }
    }

