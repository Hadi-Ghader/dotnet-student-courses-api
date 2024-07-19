using AutoMapper;
using Courses_Students.Core.Entities;
using Courses_Students.Services.Models;

namespace Courses_Students.Services.Mappings
{
    public class CourseMapper : Profile
    {
        public CourseMapper()
        {
            CreateMap<Course, CourseDTO>().ReverseMap();
        }
    }
}
