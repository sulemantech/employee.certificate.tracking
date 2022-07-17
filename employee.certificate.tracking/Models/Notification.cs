using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employee.certificate.tracking.Models
{
    public class Notification
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotificationId { get; set; }
        public int NotificationTypeId { get; set; }
        public NotificationType NotificationType { get; set; }
        public int NotificationStatusId { get; set; }

        public NotificationStatus NotificationStatus { get; set; }

        //public NotificationType NotificationType { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public IList<EmployeeNotification> EmployeeNotifications { get; set; }



}
}
