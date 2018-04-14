using MO.MVC.ClientSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Mvc;

namespace MO.MVC.ClientSide.Controllers
{
    public class MeetingController : Controller
    {
        // GET: Meeting
        public ActionResult Index()
        {
            IEnumerable<mvcMeetingModel> meetingList;
            HttpResponseMessage resMessage = GlobalVariables.WebApiClient.GetAsync("Meeting").Result;
            var formatters = new List<MediaTypeFormatter>()
            {
                new JsonMediaTypeFormatter(),
                new XmlMediaTypeFormatter()
            };
            meetingList = resMessage.Content.ReadAsAsync<IEnumerable<mvcMeetingModel>>(formatters).Result;
            return View(meetingList);
        }
    }
}