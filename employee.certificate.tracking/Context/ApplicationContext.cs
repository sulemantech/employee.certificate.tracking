using employee.certificate.tracking.Models;
using Microsoft.EntityFrameworkCore;

namespace employee.certificate.tracking.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<NotificationStatus> NotificationStatuses { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }

        public DbSet<EmployeeCertificate> EmployeeCertificates { get; set; }
        public DbSet<HospitalCertificate> HospitalCertificates { get; set; }
        public DbSet<EmployeeNotification> EmployeeNotifications { get; set; }
        public DbSet<HospitalEmployee> HospitalEmployees { get; set; }
        public DbSet<Log> Logs { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {

            //builder.Entity<Notification>().HasOne(t => t.NotificationType).WithOne(n => n.Notification);
            builder.Entity<Notification>()
       .HasOne(a => a.NotificationType)
       .WithOne(b => b.Notification)
       .HasForeignKey<NotificationType>(b => b.NotificationTypeId);

            builder.Entity<Notification>()
    .HasOne(a => a.NotificationStatus)
    .WithOne(b => b.Notification)
    .HasForeignKey<NotificationStatus>(b => b.NotificationStatusId);
            //
            //builder.Entity<BookCategory>()
            builder.Entity<EmployeeCertificate>()
        .HasKey(ec => new { ec.EmployeeId, ec.CertificateId });

            builder.Entity<EmployeeCertificate>()
                .HasOne(ec => ec.Employee)
                .WithMany(b => b.EmployeeCertificates)
                .HasForeignKey(bc => bc.EmployeeId);

            builder.Entity<EmployeeCertificate>()
                .HasOne(bc => bc.Certificate)
                .WithMany(c => c.EmployeeCertificates)
                .HasForeignKey(bc => bc.CertificateId);

            builder.Entity<HospitalCertificate>()
       .HasKey(ec => new { ec.HospitalId, ec.CertificateId });

            builder.Entity<HospitalCertificate>()
                .HasOne(ec => ec.Hospital)
                .WithMany(b => b.HospitalCertificates)
                .HasForeignKey(bc => bc.CertificateId);

            builder.Entity<HospitalCertificate>()
                .HasOne(bc => bc.Certificate)
                .WithMany(c => c.HospitalCertificates)
                .HasForeignKey(bc => bc.CertificateId);
            //
            builder.Entity<EmployeeNotification>()
       .HasKey(ec => new { ec.EmployeeId, ec.NotificationId });

            builder.Entity<EmployeeNotification>()
                .HasOne(ec => ec.Employee)
                .WithMany(b => b.EmployeeNotifications)
                .HasForeignKey(bc => bc.EmployeeId);

            builder.Entity<EmployeeNotification>()
               .HasOne(bc => bc.Employee)
               .WithMany(c => c.EmployeeNotifications)
               .HasForeignKey(bc => bc.NotificationId);

            //
            builder.Entity<HospitalEmployee>()
       .HasKey(ec => new { ec.HospitalId, ec.EmployeeId });

            builder.Entity<HospitalEmployee>()
                .HasOne(ec => ec.Hospital)
                .WithMany(b => b.HospitalEmployees)
                .HasForeignKey(bc => bc.HospitalId);

            builder.Entity<HospitalEmployee>()
               .HasOne(bc => bc.Employee)
               .WithMany(c => c.HospitalEmployees)
               .HasForeignKey(bc => bc.EmployeeId);
        }
    }
}
