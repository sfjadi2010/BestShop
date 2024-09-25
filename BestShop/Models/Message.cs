using System.ComponentModel.DataAnnotations;

namespace BestShop.Models;

public partial class Message : AuditEntity
{
    [Key]
    public Guid Id { get; set; }

    [Display(Name = "First Name")]
    public required string FirstName { get; set; }

    [Display(Name = "Last Name")]
    public required string LastName { get; set; }

    [Display(Name = "Email")]
    public required string Email { get; set; }

    [Display(Name = "Phone")]
    public required string Phone { get; set; }

    [Display(Name = "Subject")]
    public required string Subject { get; set; }

    [Display(Name = "Message")]
    public required string Body { get; set; }
}
