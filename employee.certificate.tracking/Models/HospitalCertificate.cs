using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employee.certificate.tracking.Models
{
    public class HospitalCertificate
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }

        [Required]
        [ForeignKey("Certificate")]
        public int CertificateId { get; set; }
        public Certificate Certificate { get; set; }

    }
}
