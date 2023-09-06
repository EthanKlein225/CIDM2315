namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
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
