using Courses_Students.Services.Models;

namespace Courses_Students.Services.Services
{
    public interface ICourseService
    {
        public Task<IEnumerable<CourseDTO>> GetCoursesByStudentAgeAsync();
        public Task<IEnumerable<CourseDTO>> GetAllCoursesAsync();
        public Task<CourseDTO> GetCourseByIdAsync(int id);
        public Task UpdateCourseAsync(CourseDTO course);
        public Task InsertCourseAsync(CourseDTO course);
        public Task DeleteCourseAsync(int id);
    }
}
