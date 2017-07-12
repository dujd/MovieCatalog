
using Microsoft.AspNet.Identity.EntityFramework;

namespace MovieCatalog.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
     
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }


        public System.Data.Entity.DbSet<MovieCatalog.Models.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<MovieCatalog.Models.Rating> Ratings { get; set; }

        public System.Data.Entity.DbSet<MovieCatalog.Models.Movie> Movies { get; set; }
    }
}