namespace MO.WebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MeetingDB : DbContext
    {
        public MeetingDB()
            : base("name=MeetingDB")
        {
        }

        public virtual DbSet<tblMeeting> tblMeetings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblMeeting>()
                .Property(e => e.StartTime)
                .IsFixedLength();

            modelBuilder.Entity<tblMeeting>()
                .Property(e => e.EndTime)
                .IsFixedLength();
        }
    }
}
