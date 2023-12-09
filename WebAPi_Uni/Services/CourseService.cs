using WebAPi_Uni.DB;
using WebAPi_Uni.DB.Entities;
using WebAPi_Uni.Dtoes;
using WebAPi_Uni.Interfaces;

namespace WebAPi_Uni.Services
{
    public class CourseService : ICourse
    {
        private UniversityContext _db;
        public CourseService()
        {
            _db = new();
        }

        public List<string> DeleteCourse(int id)
        {
            var datas = _db.Courses.ToList();

            foreach (var item in datas)
            {
                if (item.Id == id)
                    datas.Remove(item);
            }
            _db.SaveChanges();
            return GetCourse();
        }

        public List<string> GetCourse()
        {
            var datas = _db.Courses.ToList();
            List<string> response = new();
            foreach (var item in datas)
            {
                response.Add(item.Name);
            }
            return response;
        }

        public List<string> PostCourse(CourseGetDto dto)
        {
            var datas = _db.Courses.ToList();
            List<string> checks = new();
            foreach (var item in datas)
            {
                checks.Add(item.Name);
            }

            if(!checks.Contains(dto.Name))
            {
                var request = new Course() { Name =dto.Name };
                datas.Add(request);
                _db.SaveChanges();
            }

            return GetCourse();
        }

        public List<string> PutCourse(int id, CourseGetDto dto)
        {
            var datas = _db.Courses.ToList();
            foreach (var item in datas)
            {
                if(item.Id==id)
                {
                    item.Name = dto.Name;
                    _db.SaveChanges();
                }
            }
            return GetCourse();
        }
    }
}
