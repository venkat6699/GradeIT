using System;
namespace Schedule.Models
{
    public class Schedule
    {
        public Schedule()
        {
        }

        public int Id { get; set; }
        public int CourseId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
