using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        //public string Name { get; protected set; }
        //public string Description { get; protected set; }
        public int InstitutionId { get; set; }
        public int CASL1SubinstitutionId { get; set; }
        public int CASL2SubinstitutionId { get; set; }
        public int? CASL3SubinstitutionId { get; set; }
        public int? CASL4SubinstitutionId { get; set; }
        public string CourseName { get; set; }
        public string CourseStartSession { get; set; }
        public int? CourseDurationDays { get; set; }
        public int? CourseDurationWeeks { get; set; }
        public int? CourseDurationMonths { get; set; }
        public int CourseDurationAcademicSessions { get; set; }
        public string CourseDescriptionForCareer { get; set; }
        public string CourseDescriptionForRigour { get; set; }
        public int? TargetStudentTypeLookupId { get; set; }
        public int? AttendanceTypeLookupId { get; set; }
        public string ImageUrl { get; set; }

        public IEnumerable<Course> Courses { get; set; }
    }
}
