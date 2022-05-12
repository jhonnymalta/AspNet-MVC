using _002_Portfolio.Models;

namespace _002_Portfolio.Repositories
{
    public interface IRepositoryCourses
    {
        List<Course> GetCourses();
    }
    public class RepositoryCourses : IRepositoryCourses
    {
        public List<Course> GetCourses()
        {
            return new List<Course>()
            {
                new Course()
                {
                    Title = "TESTE",
                    Emitent = "Balta IO",
                    EmitedDate = new DateTime(2022,04,05),
                    urlimage = "https://balta.io/certificados/f1c199b0-24a1-4f55-9a17-bc83a6056330"

                },
                new Course()
                {
                    Title = "TESTE 2",
                    Emitent = "Balta IO",
                    EmitedDate = new DateTime(2021,01,15),
                    urlimage = "https://balta.io/certificados/f1c199b0-24a1-4f55-9a17-bc83a6056330"

                },
                 new Course()
                {
                    Title = "TESTE 3",
                    Emitent = "Balta IO",
                    EmitedDate = new DateTime(2020,12,20),
                    urlimage = "https://balta.io/certificados/f1c199b0-24a1-4f55-9a17-bc83a6056330"

                },
            };

        }

    }
}
