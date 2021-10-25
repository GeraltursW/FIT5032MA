namespace FIT5032MA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Event
    {
        public int EventId { get; set; }

        [Required]
        public string Subject { get; set; }

        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        [StringLength(10)]
        public string Description { get; set; }

        [StringLength(10)]
        public string ThemeColor { get; set; }
    }
}
