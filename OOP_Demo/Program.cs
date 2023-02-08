using OOP_Demo;
internal class Program
{
    private static void Main(string[] args)
    {
        Student students = new Student();
        students.Id = 1;
        students.Name = "Tuan";
        Console.WriteLine(students.ToString());

        Student student = new Student(2, "ok");
        Console.WriteLine(student.ToString());
    }
}