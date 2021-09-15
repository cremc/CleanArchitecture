using CleanArch.Domain.Commands;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var newCourse = new Course()
            {
                InstitutionId = request.InstitutionId,
                Casl1subinstitutionId = request.CASL1SubinstitutionId,
                Casl2subinstitutionId = request.CASL2SubinstitutionId,
                Casl3subinstitutionId = request.CASL3SubinstitutionId,
                Casl4subinstitutionId = request.CASL4SubinstitutionId,
                CourseName = request.CourseName,
                CourseStartSession = request.CourseStartSession,
                CourseDurationDays = request.CourseDurationDays,
                CourseDurationWeeks = request.CourseDurationWeeks,
                CourseDurationMonths = request.CourseDurationMonths,
                CourseDurationAcademicSessions = request.CourseDurationAcademicSessions,
                CourseDescriptionForCareer = request.CourseDescriptionForCareer,
                CourseDescriptionForRigour = request.CourseDescriptionForRigour,
                TargetStudentTypeLookupId = request.TargetStudentTypeLookupId
            };

            _courseRepository.AddNew(newCourse);

            return Task.FromResult(true);
        }
    }
}
