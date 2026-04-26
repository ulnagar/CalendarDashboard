namespace CalendarDashboard.Models;

using System.ComponentModel.DataAnnotations;

public sealed class AppointmentMember
{
    [Key]
    public int Id { get; set; }

    // Foreign Key to the Appointment
    public int AppointmentId { get; set; }
    public virtual Appointment Appointment { get; set; }

    // Foreign Key to the FamilyMember
    public int FamilyMemberId { get; set; }
    public virtual FamilyMember FamilyMember { get; set; }
}