namespace Data.Models
{
    public enum Status
    {
        Watching, PlanToWatch, Dropped
    }

    public class UserShow
    {
        public int UserId { get; set; }
        public int ShowId { get; set; }
        public Status? ShowStatus { get; set; }
        public User User { get; set; }
        public Show Show { get; set; }
    }
}
