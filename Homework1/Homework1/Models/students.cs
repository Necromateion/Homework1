﻿using System.ComponentModel.DataAnnotations;


namespace Homework1.Models
{
    public class students 
    { 
        [Key]
        public int id { get; set; }

        public string grade { get; set; }
    }
}