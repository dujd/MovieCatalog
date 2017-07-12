using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieCatalog.Models
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }

        [Display(Name = "Rating")]
        [StringLength(10)]
        public string RatingValue { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}