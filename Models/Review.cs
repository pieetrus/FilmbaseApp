using System.ComponentModel;

namespace JakubPietrusLab4Zadanie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Review
    {
        public int Id { get; set; }
        [DisplayName("Treœæ")]
        public string Contest { get; set; }

        public int UserLoginId { get; set; }

        public int MovieId { get; set; }
        [DisplayName("Film")]
        public virtual Movie Movie { get; set; }
        [DisplayName("U¿ytkownik")]
        public virtual UserLogin UserLogin { get; set; }
    }
}
