
using Exception.Domain.Interface;
using Exception.Helper.Messages;

namespace Exception.Domain.Entity
{
    public class Group : IGroup
    {
        public int ID { get; }
        private static int _id;
        private static int _groupNo = 99;
        public int GroupLimit { get; set; }
        public string No { get; }
        private List<Student> Students = new();
        public Group(int grouplimit)
        {
            _id++;
            ID = _id;
            _groupNo++;
            No = $"AB{_groupNo}";
            Students = new();
            GroupLimit = grouplimit;
        }



        public List<Student> AddStudent(Student student)
        {
            if (GroupLimit < Students.Count) { Console.WriteLine(InfoMessage.LimitMessage); }
            else { Students.Add(student); }
            return Students;

        }

        public void GetAllStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public void SortPoint()
        {

            Students.Sort();
            Students.Reverse();


            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }
    }
    
}
