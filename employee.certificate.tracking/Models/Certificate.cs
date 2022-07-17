using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employee.certificate.tracking.Models
{
    public class Certificate
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CertificateId { get; set; }  
        [Required]
        [MaxLength(100)]
        public string CertificateName { get; set; }
        public string? Code { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int ExpirationDate { get; set; }
        public string? Description { get; set; }
        public IList<EmployeeCertificate> EmployeeCertificates { get; set; }
        public IList<HospitalCertificate> HospitalCertificates { get; set; }


    }
}
