using Courses_Students.Core.Entities;

namespace Courses_Students.Infrastructure.Repositories
{
    public interface IStudentRepository
    {
        public Task<IEnumerable<Student>> GetAllStudentsAsync();
        public Task<Student> GetStudentByIdAsync(int id);
        public Task AssignCourseToStudentAsync(int studentId, int courseId);
        public Task InsertStudentAsync(Student student);
        public Task UpdateStudentAsync(Student student);
        public Task DeleteStudentAsync(int id);
    }
}
