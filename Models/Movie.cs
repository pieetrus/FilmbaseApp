namespace JakubPietrusLab4Zadanie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            Reviews = new HashSet<Review>();
        }
        
        public int Id { get; set; }
        [DisplayName("Tytu³")]
        public string Title { get; set; }
        [DisplayName("Rok produkcji")]
        public int YearOfRelease { get; set; }

        public int DirectorId { get; set; }

        public int GenreId { get; set; }

        [DisplayName("Re¿yseria")]
        public virtual Director Director { get; set; }
        [DisplayName("Gatunek")]
        public virtual Genre Genre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DisplayName("Recenzje")]
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
