﻿using System.ComponentModel.DataAnnotations;

namespace WebAPI_2._1.Models
{
    public class Ailment
    {
        [Key]
        public string Name { get; set; }
    }
}
