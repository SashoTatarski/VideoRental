using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VideoRental.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 10)]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

    }
}