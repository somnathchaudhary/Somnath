﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentController.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public float fee { get; set; }
    }
}
