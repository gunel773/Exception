
using Exception.Domain.Entity;
using System.Drawing;

List<Student> Studentslist = new();
Student student1 = new("name1", "surname1", 86);

Student student2 = new("name2", "surname2", 67);

Student student3 = new("name3", "surname3", 79);
Student student4 = new("name4", "surname4", 93);
//Pointleri muqayise etmek
Console.WriteLine($"Point Compare:{student1>student2}");
Console.WriteLine($"Point Compare:{student2 < student3}");
Console.WriteLine($"Point Compare:{student2 < student3}");
Console.WriteLine("------------------------------------------------------------------");

Studentslist.Add(student1);
Studentslist.Add(student2);
Studentslist.Add(student3);
Studentslist.Add(student4);

student1.ShowInfo();
student2.ShowInfo();
student3.ShowInfo();
student4.ShowInfo();

Console.WriteLine("=====================================================================");

Group group1 = new(4);
group1.AddStudent(student1);
group1.AddStudent(student3);
group1.AddStudent(student4);
group1.GetAllStudents();
Console.WriteLine($"Bu qrupun nomresi:{group1.No}");
Console.WriteLine("-------------------");
Console.WriteLine("Qrupun point ucun sort olunmus versiyasi");
group1.SortPoint();


Console.WriteLine("=======================================================================");
//qrup nomresi artdi
Group group2 = new(5);
Console.WriteLine($"Bu qrupun nomresi:{group2.No}");


