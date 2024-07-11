using DI_Real_Application_Example.Models;

namespace DI_Real_Application_Example.With_Out_DI_Example_Student
{
    public interface IStu
    {
        Task<List<StudentsModel>> GetStudentsAsync();

    }
}
