using ArabicProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArabicProject.ViewModels
{
    public class BlogModel
    {
        public int id { get; set; }
        public List<sections> _section { get; set; }
      //  public Blog _blog { get; set; }
        public string  Title { get; set; }
        public string BodyText { get; set; }

        public string Author { get; set; }
      
        public int selected { get; set; }
    }
}
