

using System.Collections;

namespace Exception.Domain.Entity
{
    public class Student : IComparable<Student>
    {
        public int Id { get;  } 
        private static int _id { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }



        public Student(string name, string surname, int point)
        {
            _id++;
             Id= _id;
            Name = name;
            Surname = surname;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"{Id})Student:{Name} {Surname}-- Point={Point} ";
        }
        


        public static bool operator >(Student a, Student b)
        {
            return a.Point > b.Point;
        }
        public static bool operator <(Student a, Student b)
        {
            return a.Point < b.Point;
        }


        

        public int CompareTo(Student? student)
        {
            return student.Point.CompareTo(Point);
        }
    }
}
