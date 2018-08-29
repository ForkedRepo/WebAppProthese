using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public Guid UsersId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(60, ErrorMessage = "Username can't be longer than 60 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(60, ErrorMessage = "Password can't be longer than 45 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Fonction is required")]
        [StringLength(60, ErrorMessage = "Fonction can't be longer than 45 characters")]
        public string Fonction { get; set; }


    }
}
