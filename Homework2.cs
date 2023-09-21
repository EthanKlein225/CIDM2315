namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //Question 1
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
        
        
        //Question 2
        Console.WriteLine("Please input the first num: ");
        string n1_str = Console.ReadLine();
        int n1 = Convert.ToInt16(n1_str);
        Console.WriteLine("Please input the second num: ");
        string n2_str = Console.ReadLine();
        int n2 = Convert.ToInt16(n2_str);
        Console.WriteLine("Please input the third num: ");
        string n3_str = Console.ReadLine();
        int n3 = Convert.ToInt16(n3_str);
        if(n1<n2){
            if(n1<n3){
                Console.WriteLine("The smallest value is: " + n1);
            }
            else{
                Console.WriteLine("The smallest value is: " + n3);
            }
        }
        else{
            if(n2<n3){
                Console.WriteLine("The smallest value is: " + n2);
            }
            else{
                Console.WriteLine("The smallest value is: " + n3);
            }
        }
    }
}
