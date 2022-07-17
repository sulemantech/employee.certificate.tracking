using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employee.certificate.tracking.Models
{
    public class NotificationStatus
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotificationStatusId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Status { get; set; }
        public Notification Notification { get; set; }

    }
}
