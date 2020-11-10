using System.Collections.Generic;

namespace Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        // public List<UserShow> Shows { get; set; }
        public ICollection<UserShow> UserShows { get; set; }
    }
}
