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
            int cASL2SubinstitutionId,
            string courseName,
            int courseDurationAcademicSessions)
        {
            InstitutionId = institutionId;
            CASL1SubinstitutionId = cASL1SubinstitutionId;
            CASL2SubinstitutionId = cASL2SubinstitutionId;
            CourseName = courseName;
            CourseDurationAcademicSessions = courseDurationAcademicSessions;

        }
    }
}
