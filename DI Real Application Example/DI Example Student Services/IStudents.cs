using DI_Real_Application_Example.Models;

namespace DI_Real_Application_Example.StudentServices
{
    public interface IStudents
    {
        Task<List<StudentsModel>> GetStudentsAsync();

    }
}
