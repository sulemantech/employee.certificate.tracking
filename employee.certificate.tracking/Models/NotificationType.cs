using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employee.certificate.tracking.Models
{
    public class NotificationType
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotificationTypeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
        public string Description { get; set; }
        public Notification Notification{get;set;}
    }
}
