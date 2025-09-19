using System.ComponentModel.DataAnnotations;

namespace Pulse.Model
{
    public class Doctor : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [StringLength(100, ErrorMessage = "The entered email is too long. Please enter a shorter name.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Specialization is required")]
        [StringLength(100, ErrorMessage = "The entered specialization is too long. Please enter a shorter specialization.")]
        public string Specialization { get; set; }

        [StringLength(15, ErrorMessage = "The entered phone number is too long. Please enter a shorter phone number.")]
        public string? PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Email address not valid.")]
        [StringLength (100, ErrorMessage = "The entered email address is too long. Please enter a shorter email address.")]
        public string? EmailAddress { get; set; }

        public ICollection<Patient> Patients { get; set; } = new List<Patient>();

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}