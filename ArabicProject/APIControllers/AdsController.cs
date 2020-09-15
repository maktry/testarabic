using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ArabicProject.Data;

using ArabicProject.Models;

namespace ArabicProject.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        AdsController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public List<AdEntree> GetAds()
        {
            var x = _context.AdEntree.ToList();
            return (x);
        }
        //public IEnumerable<string> Get()
        //{
        //    // var x = _context.AdEntree.ToList();
        //    return [ "dd", "dd" ];
        //}
    }

}