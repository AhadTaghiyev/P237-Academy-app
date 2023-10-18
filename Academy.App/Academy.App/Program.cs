using Academy.Core.Models;

Student[] students= { };

Console.WriteLine("1.Create student");
Console.WriteLine("2.Show students");
Console.WriteLine("0.close");
string request=Console.ReadLine();

while (request!="0")
{
    switch (request)
    {
        case "1":
            AddStudent();
            break;
        case "2":
            GetStududents();
            break;
            default:
            Console.WriteLine("please add valid option");
            break;
    }
    Console.WriteLine("1.Create student");
    Console.WriteLine("2.Show students");
    Console.WriteLine("0.close");
     request = Console.ReadLine();
}

void AddStudent()
{
    Console.WriteLine("Add name");
    string Name = ValidateString(Console.ReadLine());
    Console.WriteLine("Add surname");
    string Surname = ValidateString(Console.ReadLine());
    Console.WriteLine("Add group");
    string Group = ValidateString(Console.ReadLine());
    Console.WriteLine("Add education");
    string Education = ValidateString(Console.ReadLine());
    Student student = new Student(Name, Surname, Group, Education);
    Array.Resize(ref students, students.Length + 1);
    students[students.Length-1]=student;
    Console.WriteLine("Student created succesfuly");
}

void GetStududents()
{
    foreach (Student student in students)
    {
        Console.WriteLine(student.GetFullInfo());
    }
}
string ValidateString(string data)
{
    while (string.IsNullOrWhiteSpace(data))
    {
        Console.WriteLine("pleasa add valid value");
        data = Console.ReadLine();
    }
    return data;
}