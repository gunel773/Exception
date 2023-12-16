

using Exception.Domain.Entity;

namespace Exception.Domain.Interface
{
    public interface IGroup
    {
        public List<Student> AddStudent(Student student);
        public void GetAllStudents();
        public void SortPoint();
    }
}
