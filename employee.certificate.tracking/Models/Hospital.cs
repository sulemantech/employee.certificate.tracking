using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employee.certificate.tracking.Models
{
    public class Hospital
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HospitalId { get; set; }
        [Required]
        [MaxLength(100)]
        public string HospitalName { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public IList<HospitalCertificate> HospitalCertificates { get; set; }
        public IList<HospitalEmployee> HospitalEmployees { get; set; }

    }
}
