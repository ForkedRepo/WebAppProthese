using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("dentiste")]
    public class Dentiste
    {
        [Key]
        public Guid DentisteId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(60, ErrorMessage = "Username can't be longer than 60 characters")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [StringLength(60, ErrorMessage = "Password can't be longer than 45 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(60, ErrorMessage = "Email can't be longer than 255 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Created_at is required")]
        public DateTime Created_at { get; set; }

    }
}
