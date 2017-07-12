using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieCatalog.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(300, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Details url")]
        [StringLength(200, MinimumLength = 5)]
        public string UrlDetails { get; set; }

        public double? Price { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        [Display(Name = "Rating")]
        public int RatingId { get; set; }
        public virtual Rating Rating { get; set; }
    }
}