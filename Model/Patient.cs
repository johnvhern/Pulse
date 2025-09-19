using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pulse.Model
{
    public class Patient : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [StringLength(100, ErrorMessage = "The entered email is too long. Please enter a shorter name.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(15, ErrorMessage = "The entered phone number is too long. Please enter a shorter phone number.")]
        public string? PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Email address not valid.")]
        [StringLength(100, ErrorMessage = "The entered email address is too long. Please enter a shorter email address.")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Assigned Doctor is required")]
        public int DoctorId { get; set; }

        [StringLength(100, ErrorMessage = "The entered address is too long. Please enter a shorter address.")]
        public string? Address { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}