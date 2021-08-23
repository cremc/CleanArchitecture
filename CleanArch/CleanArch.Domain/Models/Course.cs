using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class Course
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }
        public int InstitutionID { get; set; }
        public int CASL1SubinstitutionID { get; set; }
        public int CASL2SubinstitutionID { get; set; }
        public int CASL3SubinstitutionID { get; set; }
        public int CASL4SubinstitutionID { get; set; }
        public string CourseName { get; set; }
        public string CourseStartSession { get; set; }
        public int CourseDurationDays { get; set; }
        public int CourseDurationWeeks { get; set; }
        public int CourseDurationMonths { get; set; }
        public int CourseDurationAcademicSessions { get; set; }
        public string CourseDescriptionForCareer { get; set; }
        public string CourseDescriptionForRigour { get; set; }
        public int TargetStudentTypeLookupID { get; set; }
        public int AttendanceTypeLookupID { get; set; }

    }

}
