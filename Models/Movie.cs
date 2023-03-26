﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public byte NumberInStock { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime AddedDate { get; set; } // the day where the movie is added to the Database
        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}