using System.Security.Cryptography;

namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        p1.GetSalary();
        p1.PrintInfoProf();

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        p2.GetSalary();
        p2.PrintInfoProf();

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        s1.GetGrade();
        s1.PrintInfoStudent();

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        s2.GetGrade();
        s2.PrintInfoStudent();

        Console.WriteLine($"The salary difference between Alice and Bob is: {p1.GetSalary() - p2.GetSalary()}");
        Console.WriteLine($"The total grade of Lisa and Tom is: {s1.GetGrade() + s2.GetGrade()}");
    }
        class Student{
            public string studentName;
            public string classEnroll;
            private double studentGrade;
            public void PrintInfoStudent(){
                Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {studentGrade}");
            }
            public void SetGrade(double newGrade){
            studentGrade = newGrade;
            }
            public double GetGrade(){
                return studentGrade;
            }
        }

        class Professor{
            public string profName;
            public string classTeach;
            private double salary;
            public void PrintInfoProf(){
                Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {salary}");
            }
            public void SetSalary(double salary_amount){
            salary = salary_amount;
            }
            public double GetSalary(){
                return salary;
            }
        }
}