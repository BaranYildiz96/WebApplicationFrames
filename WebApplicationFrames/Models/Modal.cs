namespace WebApplicationFrames
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Modal
    {
        [Key]
        [Column(Order = 0)]
        public string Images { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Text { get; set; }

        [Key]
        [Column(Order = 3)]
        public string MyModal { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Sp { get; set; }
    
        [Key]
        [Column(Order = 5)]
        public string Px { get; set; }
    }
}
