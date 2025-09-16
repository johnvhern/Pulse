using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pulse.Model
{
    public class Appointment : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Patient is required to schedule an appointment.")]
        public int PatientId { get; set; }

        [Required(ErrorMessage = "Doctor is required.")]
        public int DoctorId { get; set; }

        [Required(ErrorMessage = "Date for the appointment is required.")]
        public DateTime Date { get; set; }

        [StringLength(100, ErrorMessage = "Notes is too long. Please enter a shorter one.")]
        public string Notes { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }


    }
}