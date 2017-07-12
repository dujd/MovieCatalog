using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieCatalog.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Display(Name = "Genre")]
        [StringLength(50, MinimumLength = 3)]
        public string GenreValue { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}