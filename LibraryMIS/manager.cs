namespace LibraryMIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("manager")]
    public partial class manager
    {
        [StringLength(50)]
        public string MName { get; set; }

        [StringLength(50)]
        public string MCode { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool manage { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool work { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool query { get; set; }
    }
}
