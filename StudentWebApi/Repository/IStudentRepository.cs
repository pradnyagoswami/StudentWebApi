using StudentWebApi.Model;

namespace StudentWebApi.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();

        Student GetStudentById(int id);

        int AddStudent(Student student);
        int UpdateStudent(Student student);

        int DeleteStudent(int id);

    }
}
