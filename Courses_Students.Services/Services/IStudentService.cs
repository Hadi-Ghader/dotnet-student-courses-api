using Courses_Students.Services.Models;

namespace Courses_Students.Services.Services
{
    public interface IStudentService
    {
        public Task<IEnumerable<StudentDTO>> GetAllStudentsAsync();
        public Task<StudentDTO> GetStudentByIdAsync(int id);
        public Task AssignCourseToStudentAsync(int studentId, int courseId);
        public Task InsertStudentAsync(StudentDTO student);
        public Task UpdateStudentAsync(StudentDTO student);
        public Task DeleteStudentAsync(int id);
    }
}
