using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class Course
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("InstitutionID")]
        public int InstitutionId { get; set; }
        [Column("CASL1SubinstitutionID")]
        public int Casl1subinstitutionId { get; set; }
        [Column("CASL2SubinstitutionID")]
        public int Casl2subinstitutionId { get; set; }
        [Column("CASL3SubinstitutionID")]
        public int? Casl3subinstitutionId { get; set; }
        [Column("CASL4SubinstitutionID")]
        public int? Casl4subinstitutionId { get; set; }

        //public string Name { get; set; }
        //public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string CourseName { get; set; }
        public string CourseStartSession { get; set; }
        public int? CourseDurationDays { get; set; }
        public int? CourseDurationWeeks { get; set; }
        public int? CourseDurationMonths { get; set; }
        public int CourseDurationAcademicSessions { get; set; }
        [Column(TypeName = "ntext")]
        public string CourseDescriptionForCareer { get; set; }
        [Column(TypeName = "ntext")]
        public string CourseDescriptionForRigour { get; set; }
        [Column("TargetStudentTypeLookupID")]
        public int? TargetStudentTypeLookupId { get; set; }
        [Column("AttendanceTypeLookupID")]
        public int? AttendanceTypeLookupId { get; set; }
        public string ImageUrl { get; set; }

    }

}
