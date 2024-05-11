using Microsoft.AspNetCore.Identity;

namespace Fullcalendar_5._8.Models
{
    public class User : IdentityUser
    {
        public virtual ICollection<Event> Events { get; set; }
    }
}
