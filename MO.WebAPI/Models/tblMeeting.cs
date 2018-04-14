namespace MO.WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblMeeting
    {
        [Key]
        public int MeetingID { get; set; }

        [Required]
        [StringLength(50)]
        public string MeetingTopic { get; set; }

        public DateTime MeetingDate { get; set; }

        [Required]
        [StringLength(10)]
        public string StartTime { get; set; }

        [Required]
        [StringLength(10)]
        public string EndTime { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Katılımcılar { get; set; }
    }
}
