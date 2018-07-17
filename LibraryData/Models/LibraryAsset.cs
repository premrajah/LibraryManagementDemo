﻿using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models
{
    public abstract class LibraryAsset
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public Status Status { get; set; }
        public decimal Cost { get; set; }
        public string ImageUrl { get; set; }
    }
    
}