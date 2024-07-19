using Courses_Students.Core.Entities;

namespace Courses_Students.Infrastructure.Repositories
{
    public interface ICourseRepository
    {
        public Task<IEnumerable<Course>> GetCoursesByStudentAgeAsync();
        public Task<IEnumerable<Course>> GetAllCoursesAsync();
        public Task<Course> GetCourseByIdAsync(int id);
        public Task UpdateCourseAsync(Course course);
        public Task InsertCourseAsync(Course course);
        public Task DeleteCourseAsync(int id);
    }
}
