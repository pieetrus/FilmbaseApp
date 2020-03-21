using System.ComponentModel;

namespace JakubPietrusLab4Zadanie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserLogin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserLogin()
        {
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }
        [DisplayName("Nazwa")]
        public string UserName { get; set; }
        [DisplayName("Has³o")]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DisplayName("Recenzje")]
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
