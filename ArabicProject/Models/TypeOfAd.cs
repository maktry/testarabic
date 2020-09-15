using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArabicProject.Models
{
    public class TypeOfAd
    {
        [Key]
        public int Id { get; set; }
      [Required]
        [StringLength(50,ErrorMessage ="Name Should NOT exceed 50 characters")]
        public string Name { get; set; }

        public bool ZeroActive { get; set; }
    }
}
