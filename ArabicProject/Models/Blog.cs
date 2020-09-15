using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArabicProject.Models
{
    public class Blog
    {
        [Key]
        public int id { get; set; }
        public string  Title { get; set; }
        public string BodyText { get; set; }

        public string Author { get; set; }
        [ForeignKey("sections")]
        public int SectionId { get; set; }

        public DateTime DateWriten { get; set; }

        public bool  ZeroActive { get; set; }


    }
}
