using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MO.WebAPI.Models;

namespace MO.WebAPI.Controllers
{
    public class MeetingController : ApiController
    {
        private MeetingDB db = new MeetingDB();

        // GET: api/Meeting
        public IQueryable<tblMeeting> GettblMeetings()
        {
            return db.tblMeetings;
        }
        /// <summary>
        /// Toplantı tarihine göre toplantı listesi oluşturulması için yapılan fonksiyon saatleri bu şekilde getirebilecektik devam edilecek.
        /// </summary>
        /// <param name="MeetingDate"></param>
        /// <returns></returns>
        public IQueryable<tblMeeting> GettblMeetingByDate(DateTime MeetingDate)
        {
            return GettblMeetings().Where(x=>x.MeetingDate == MeetingDate);
        }

        // GET: api/Meeting/5
        [ResponseType(typeof(tblMeeting))]
        public IHttpActionResult GettblMeeting(int id)
        {
            tblMeeting tblMeeting = db.tblMeetings.Find(id);
            if (tblMeeting == null)
            {
                return NotFound();
            }

            return Ok(tblMeeting);
        }

        // PUT: api/Meeting/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblMeeting(int id, tblMeeting tblMeeting)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblMeeting.MeetingID)
            {
                return BadRequest();
            }

            db.Entry(tblMeeting).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblMeetingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Meeting
        [ResponseType(typeof(tblMeeting))]
        public IHttpActionResult PosttblMeeting(tblMeeting tblMeeting)
        {

            db.tblMeetings.Add(tblMeeting);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblMeeting.MeetingID }, tblMeeting);
        }

        // DELETE: api/Meeting/5
        [ResponseType(typeof(tblMeeting))]
        public IHttpActionResult DeletetblMeeting(int id)
        {
            tblMeeting tblMeeting = db.tblMeetings.Find(id);
            if (tblMeeting == null)
            {
                return NotFound();
            }

            db.tblMeetings.Remove(tblMeeting);
            db.SaveChanges();

            return Ok(tblMeeting);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblMeetingExists(int id)
        {
            return db.tblMeetings.Count(e => e.MeetingID == id) > 0;
        }
    }
}