using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Genre is required.")]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Release date is required.")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Number in stock is required.")]
        public byte NumberInStock { get; set; }
    }
}