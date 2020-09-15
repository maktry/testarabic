using System;
using System.Collections.Generic;
using System.Text;
using ArabicProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArabicProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ArabicProject.Models.Blog> Blog { get; set; }
        public DbSet<ArabicProject.Models.sections> Sections { get; set; }
        public DbSet<ArabicProject.Models.TypeOfAd> TypeOfAd { get; set; }
        public DbSet<ArabicProject.Models.AdEntree> AdEntree { get; set; }



    }
}
