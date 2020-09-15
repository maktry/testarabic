using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArabicProject.Models
{
    public class ApplicationUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string city { get; set; }
        public string country { get; set; }

        public string gender { get; set; }

    }
}
