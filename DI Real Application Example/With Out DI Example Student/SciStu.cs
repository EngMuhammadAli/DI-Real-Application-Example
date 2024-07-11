using DI_Real_Application_Example.Models;

namespace DI_Real_Application_Example.With_Out_DI_Example_Student
{
    public class SciStu : IStu
    {
        private readonly List<StudentsModel> students = new List<StudentsModel>()
        {
            new StudentsModel()
            {
                Id = 1,
                Name = "John Doe",
                Age = 15,
                Grade = "10th Grade",
                Class = "Science"
            },
            new StudentsModel()
            {
                Id = 2,
                Name = "Jane Smith",
                Age = 14,
                Grade = "9th Grade",
                Class = "Science"
            },
            new StudentsModel()
            {
                Id = 3,
                Name = "Sam Brown",
                Age = 16,
                Grade = "11th Grade",
                Class = "Science"
            },
            new StudentsModel()
            {
                Id = 4,
                Name = "Lisa Johnson",
                Age = 17,
                Grade = "12th Grade",
                Class = "Science"
            }
        };

        public Task<List<StudentsModel>> GetStudentsAsync()
        {
            return Task.FromResult(students);
        }
    }
}
