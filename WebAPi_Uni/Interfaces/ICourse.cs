using WebAPi_Uni.DB.Entities;
using WebAPi_Uni.Dtoes;

namespace WebAPi_Uni.Interfaces
{
    public interface ICourse
    {
        public List<string> GetCourse();
        public List<string> PostCourse(CourseGetDto dto);
        public List<string> PutCourse(int id, CourseGetDto dto);
        public List<string> DeleteCourse(int id);
    }
}
