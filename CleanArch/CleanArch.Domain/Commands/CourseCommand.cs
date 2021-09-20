using CleanArch.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Commands
{
    public abstract class CourseCommand : Command
    {
        public int Id { get; protected set; }
        //public string Name { get; protected set; }
        //public string Description { get; protected set; }
        public int InstitutionId { get; protected set; }
        public int CASL1SubinstitutionId { get; protected set; }
        public int CASL2SubinstitutionId { get; protected set; }
        public int? CASL3SubinstitutionId { get; protected set; }
        public int? CASL4SubinstitutionId { get; protected set; }
        public string CourseName { get; protected set; }
        public string CourseStartSession { get; protected set; }
        public int? CourseDurationDays { get; protected set; }
        public int? CourseDurationWeeks { get; protected set; }
        public int? CourseDurationMonths { get; protected set; }
        public int CourseDurationAcademicSessions { get; protected set; }
        public string CourseDescriptionForCareer { get; protected set; }
        public string CourseDescriptionForRigour { get; protected set; }
        public int? TargetStudentTypeLookupId { get; protected set; }
        public int? AttendanceTypeLookupId { get; protected set; }
        public string ImageUrl { get; protected set; }

    }
}
