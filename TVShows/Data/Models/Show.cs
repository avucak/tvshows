using System.Collections.Generic;

namespace Data.Models
{
    public class Show
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Synopsis { get; set; }

        public double EpisodeLength { get; set; }

        public ICollection<UserShow> UserShows { get; set; }
    }
}
