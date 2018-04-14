using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MO.MVC.ClientSide.Models
{
    public class mvcMeetingModel
    {

        public int MeetingID { get; set; }

        [Required(ErrorMessage ="Bu alan boş geçilemez!")]
        public string MeetingTopic { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public DateTime MeetingDate { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string StartTime { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string EndTime { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Katılımcılar { get; set; }
    }
}