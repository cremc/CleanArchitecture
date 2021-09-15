using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(
            int institutionId, 
            int cASL1SubinstitutionId,
            string courseName,
            int courseDurationAcademicSessions)
        {
            institutionId = InstitutionId;
            cASL1SubinstitutionId = CASL1SubinstitutionId;
            courseName = CourseName;
            courseDurationAcademicSessions = CourseDurationAcademicSessions;

        }
    }
}
