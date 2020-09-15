using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArabicProject.Models
{
    public class AdEntree
    {
        [Key]
        public int Id { get; set; }
        public int TypeOfAd { get; set; }
        public string Title { get; set; }

        public string BodyComments { get; set; }
        public string Author { get; set; }

        public DateTime DateWritten { get; set; }
        public bool ZeroActive { get; set; }


    }
}
