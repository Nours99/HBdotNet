// See https://aka.ms/new-console-template for more information


public class Student
{
    protected string firstName;
    protected string lastName; 
    protected int age;

    public Student(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Age
    {
        get { return age; }
        set {
            if (value > 0)
            {
                age = value;
            }
            else {
                throw new ArgumentException("l'age doit être supérieure a 0");
            } 
        }
    }   

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{firstName} {lastName}, {age} years old");
    }
}


public class GraduateStudent : Student
{
    private int graduationYear;

    public GraduateStudent(string firstName, string lastName, int age, int graduationYear) : base(firstName, lastName, age)
    {
        this.GraduationYear = graduationYear;
    }

    public int GraduationYear { get => graduationYear; set => graduationYear = value; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{firstName} {lastName}, {Age} years old, graduate in {GraduationYear}");
    }

}

public class Program
{
    public static void Main()
    { 
        List<Student> students = new List<Student>() {
            new Student("Luke", "Skywalker", 20),
            new Student("Obiwan", "Kenobi", 33),
            new GraduateStudent("Master", "Yoda", 900, 2000)
        };        

        students.ForEach(student => student.DisplayInfo());
    }
}