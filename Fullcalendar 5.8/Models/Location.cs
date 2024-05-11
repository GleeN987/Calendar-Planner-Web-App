namespace Fullcalendar_5._8.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //Relations
        public virtual ICollection<Event> Events { get; set; }
    }
}
