using System.ComponentModel.DataAnnotations;

namespace CalendarDashboard.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        // Link to multiple family members
        public ICollection<FamilyMember> Members { get; set; } = new List<FamilyMember>();

        // Optionally, link to the user who created it
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
    }
}