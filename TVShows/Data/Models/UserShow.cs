using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Data.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        [EnumMember(Value = "Watching")]
        Watching,
        [EnumMember(Value = "Plan to watch")]
        PlanToWatch,
        [EnumMember(Value = "Dropped")]
        Dropped
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
