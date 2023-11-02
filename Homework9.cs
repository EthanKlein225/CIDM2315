namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student Alice = new Student(studentID:111, studentName:"Alice");
        Student Bob = new Student(studentID:222, studentName:"Bob");
        Student Cathy = new Student(studentID:333, studentName:"Cathy");
        Student David = new Student(studentID:444, studentName:"David");
        
        
        Dictionary<string,double> gradebook = new Dictionary<string,double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if(!gradebook.ContainsKey("Tom")){
            gradebook.Add("Tom", 3.3);
        }

        var averageGPA = gradebook.Values.Average();
        Console.WriteLine($"The average GPA is: {averageGPA}");

        Alice.PrintInfo();
        Bob.PrintInfo();
    }
}

class Student{
    public static List<Student> studentList = new List<Student>();
    private int studentID;
    private string studentName;
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public Student(int studentID, string studentName){
        this.studentID = studentID;
        this.studentName = studentName;
        studentList.Add(this);
    }
}


