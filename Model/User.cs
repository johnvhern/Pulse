using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulse.Model
{
    public class User : BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name is too long. Please enter a shorter one.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username is too long. Please enter a shorter one.")]
        public string Username { get; set; }
        [Required]
        // Store the password hash in Base64 encoded format
        public string PasswordHash { get; set; }
        [Required]
        // Salt used for hashing the password
        public byte[] PasswordSalt { get; set; }

    }
}
