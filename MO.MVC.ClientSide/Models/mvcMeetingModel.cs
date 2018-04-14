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

        public string MeetingTopic { get; set; }

        public DateTime MeetingDate { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Katılımcılar { get; set; }
    }
}