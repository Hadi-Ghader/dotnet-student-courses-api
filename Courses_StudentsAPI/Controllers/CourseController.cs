using Courses_Students.Services.Models;
using Courses_Students.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace Courses_StudentsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("GetAllCourses")]
        public async Task<IActionResult> GetAllCoursesAsync()
        {
            var courses = await _courseService.GetAllCoursesAsync();
            return Ok(courses);
        }

        [HttpGet("GetCourseById")]
        public async Task<IActionResult> GetCourseByIdAsync(int id)
        {
            var course = await _courseService.GetCourseByIdAsync(id);
            return Ok(course);
        }

        [HttpGet("GetCoursesByStudentAge")]
        public async Task<IActionResult> GetCoursesByStudentAge()
        {
            var courses = await _courseService.GetCoursesByStudentAgeAsync();
            return Ok(courses);
        }

        [HttpPut("UpdateCourse")]
        public async Task<IActionResult> UpdateCourseAsync([FromBody] CourseDTO courseDTO)
        {
            await _courseService.UpdateCourseAsync(courseDTO);
            return Ok("Course updated successfully.");
        }

        [HttpPost("InsertCourse")]
        public async Task<IActionResult> InsertCourseAsync([FromBody] CourseDTO courseDTO)
        {
            await _courseService.InsertCourseAsync(courseDTO);
            return Ok("Course inserted successfully.");
        }

        [HttpDelete("DeleteCourse")]
        public async Task<IActionResult> DeleteCourseAsync(int id)
        {
            await _courseService.DeleteCourseAsync(id);
            return Ok("Course deleted successfully");
        }
    }
}
