using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VideoRental.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DateAdded { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 10)]
        public byte NumberInStock { get; set; }
        
    }
}