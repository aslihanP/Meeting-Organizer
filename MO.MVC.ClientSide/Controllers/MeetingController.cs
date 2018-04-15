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
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new mvcMeetingModel());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Meeting/"+id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcMeetingModel>().Result);
            }          
        }
        [HttpPost]
        public ActionResult AddOrEdit(mvcMeetingModel meeting)
        {
            if (meeting.MeetingID==0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Meeting", meeting).Result;
                TempData["SuccessMessage"] = "Yeni Toplantı Başarıyla Kaydedilmiştir.";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Meeting/"+meeting.MeetingID, meeting).Result;
                TempData["SuccessMessage"] = "Toplantı Başarıyla Güncellenmiştir.";
            }       
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Meeting/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Toplantı Kaydı Başarıyla Silinmiştir.";
            return RedirectToAction("Index");
        }
        #region Toplantı saatlerini ayarlamak için yapılan yer devam edilecek
        //string[] startTime = { "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00" };
        //public JsonResult GetTimes(mvcMeetingModel meeting)
        //{
        //    IEnumerable<mvcMeetingModel> meetingListbyDate;
        //    HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Meeting?MeetingDate="+meeting.MeetingDate).Result;
        //    meetingListbyDate = response.Content.ReadAsAsync<IEnumerable<mvcMeetingModel>>().Result;
        //    List<SelectListItem> lis = new List<SelectListItem>();
        //    lis.Add(new SelectListItem { Text = "- Saat Seçiniz -", Value = "0" });
        //    if (meetingListbyDate.Count<mvcMeetingModel>()==0)
        //    {
        //        foreach (var item in startTime)
        //        {
        //            lis.Add(new SelectListItem { Text = item, Value = item });
        //        }
        //    }
        //    else
        //    {
        //        foreach (var item in meetingListbyDate)
        //        {
        //            foreach (string s in startTime)
        //            {
        //                if (item.StartTime != s)
        //                {
        //                    lis.Add(new SelectListItem { Text = s, Value = s });
        //                }
        //            }
        //        }
        //    }
        //    return Json(new SelectList(lis, "Value", "Text", JsonRequestBehavior.AllowGet));

        //} 
        #endregion
    }
}