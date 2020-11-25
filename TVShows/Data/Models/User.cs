using DataAnnotationsExtensions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [Email]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password length must be more than 8.")]
        public string Password { get; set; }

        public ICollection<UserShow> UserShows { get; set; }
    }
}
