using System;

enum HeirColor
{
    Red,
    Green,
    Blue,
    Grey,
    Yellow,
    Black
}

class Student
{
    public string firstname;
    public string lastname;
    public string middlename;
    public int age;
    public string birthday;
    public string sex;
    public string english_level;
    public string group;
    public HeirColor color;
    public HeirColor body;


    public void Funcshn()
    {
        Console.WriteLine($"{firstname} {lastname} пропустив пару.");
        Console.WriteLine($"{firstname} {lastname} вивчає матеріал за одну ніч.");
        Console.WriteLine($"{firstname} {lastname} йде в армію після нездачі сесії.");
    }


    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();
            student.firstname = "Georgiy";
            student.middlename = "Victorovich";
            student.lastname = "Shevchenko";
            student.age = 25;
            student.birthday = "19.03.2000";
            student.sex = "male";
            student.color = HeirColor.Grey;
            student.body = HeirColor.Black;
            student.english_level = "B2";
            student.group = "3-B";
            return student;
        }
        static public void Info(Student student)
        {

            Console.WriteLine($"Ім'я: {student.firstname} {student.middlename} {student.lastname}");
            Console.WriteLine($"Вік: {student.age}");
            Console.WriteLine($"День народження: {student.birthday}");
            Console.WriteLine($"Група: {student.group}");
            Console.WriteLine($"Рівень англійської: {student.english_level}");
            Console.WriteLine($"Колір волосся: {student.color}");
            Console.WriteLine($"Колір тіла: {student.body}");

        }



        static void Main(string[] args)
        {
            Student student = GetStudent();
            Info(student);
            student.Funcshn();
        }
    }
}
