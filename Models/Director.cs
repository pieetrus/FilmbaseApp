using System.ComponentModel;

namespace JakubPietrusLab4Zadanie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Director
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Director()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        [DisplayName("Imiê i Nazwisko")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DisplayName("Filmy")]
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
