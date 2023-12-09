using Microsoft.AspNetCore.Mvc;
using WebAPi_Uni.Dtoes;
using WebAPi_Uni.Interfaces;
using WebAPi_Uni.Services;

namespace WebAPi_Uni.Controllers
{
    public class CourseController : ControllerBase
    {
        private readonly ICourse _course;

        public CourseController(ICourse course)
        {
            _course = course;
        }

        [HttpGet]
        public List<string> GetCourse()
        {
            var response = _course.GetCourse();
            return response;
        }

        [HttpPost]
        public List<string> PostCourse([FromBody] CourseGetDto dto)
        {
            var response = _course.PostCourse(dto);
            return response;
        }

        [HttpPut]
        public List<string> PutCourse([FromBody] int id, [FromBody] CourseGetDto dto)
        {
            var response = _course.PutCourse(id,dto);
            return response;
        }

        [HttpDelete]
        public List<string> DeleteCourse(int id)
        {
            var response = _course.DeleteCourse(id);
            return response;
        }

    }
}
