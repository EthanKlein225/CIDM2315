namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade: ");
        string letter = Console.ReadLine();
        if(letter=="A"){
            Console.WriteLine("GPA Point: 4");
        }
        else if(letter=="B"){
            Console.WriteLine("GPA Point: 3");
        }
        else if(letter=="C"){
            Console.WriteLine("GPA Point: 2");
        }
        else if(letter=="D"){
            Console.WriteLine("GPA Point: 1");
        }
        else if(letter=="F"){
            Console.WriteLine("GPA Point: 0");
        }
        else{
            Console.WriteLine("Wrong Letter Grade!");
        }
    }
}
