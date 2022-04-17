﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PraktikaCar.Entities
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Year { get; set; }

        [Required]
        public bool isDeleted { get; set; }
    }
}
