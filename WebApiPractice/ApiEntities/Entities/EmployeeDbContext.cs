using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiEntities.Entities
{
    public partial class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {
        }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<College> College { get; set; }
        public virtual DbSet<DataView> DataView { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<LoginCredentials> LoginCredentials { get; set; }
        public virtual DbSet<SchoolTable> SchoolTable { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<University> University { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-P6OUO3K;Database=LIBRARY_MANAGEMENT;User ID=Parneet Kaur;password=Parneet@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<College>(entity =>
            {
                entity.Property(e => e.CollegeId).HasColumnName("CollegeID");

                entity.Property(e => e.CollegeLocation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CollegeName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UniversityId).HasColumnName("UniversityID");

                entity.HasOne(d => d.University)
                    .WithMany(p => p.College)
                    .HasForeignKey(d => d.UniversityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_College_University");
            });

            modelBuilder.Entity<DataView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DataView");

                entity.Property(e => e.CollegeName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.StudentFirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniversityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoginCredentials>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SchoolTable>(entity =>
            {
                entity.HasKey(e => e.SchoolId);

                entity.Property(e => e.SchoolId).HasColumnName("School_ID");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.SchoolLogo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolMoto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.CollegeId).HasColumnName("CollegeID");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentDob)
                    .HasColumnName("StudentDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.StudentFirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentGender)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudentLastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.HasOne(d => d.College)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.CollegeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_College");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.CollegeId).HasColumnName("CollegeID");

                entity.Property(e => e.Subjects)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherEmail)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherGender)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.College)
                    .WithMany(p => p.Teacher)
                    .HasForeignKey(d => d.CollegeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Teacher_College");
            });

            modelBuilder.Entity<University>(entity =>
            {
                entity.Property(e => e.UniversityId).HasColumnName("UniversityID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniversityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
