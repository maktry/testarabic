﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArabicProject.Models
{
    public class sections
    {
        [Key]
        public int Id { get; set; }
        public string  SectionName { get; set; }

        public bool ActiveZero { get; set; }
    }
}
