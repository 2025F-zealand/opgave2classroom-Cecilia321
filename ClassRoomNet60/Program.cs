// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

internal class Program
{
    private static void Main(string[] args)
    {
        //instalisier et nyt instans af klassen Classroom
        ClassRoom classRoom = new ClassRoom(); 
        classRoom.ClassName = "3Q";
        classRoom.SemesterStart = new DateTime(2019, 8, 26);
        classRoom.StudentList = new List<Student>();

        classRoom.StudentList.Add(new Student("Cecilia", 03, 14));
        classRoom.StudentList.Add(new Student("rebekka", 04, 13));
        classRoom.StudentList.Add(new Student("Sarah", 01, 07));

        Console.WriteLine($"Class Name: {classRoom.ClassName}");
        Console.WriteLine($"Semester Start: {classRoom.SemesterStart.ToShortDateString()}");
        Console.WriteLine("Students:");

        foreach (var student in classRoom.StudentList)
        {
            Console.WriteLine($"- {student.Name}");
        }

    }
}