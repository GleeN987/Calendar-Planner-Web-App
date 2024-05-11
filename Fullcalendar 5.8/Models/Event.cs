using System.ComponentModel.DataAnnotations;

namespace Fullcalendar_5._8.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


        //Relations
        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
    }
}
