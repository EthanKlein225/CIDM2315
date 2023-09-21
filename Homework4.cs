namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Question 1
        Console.WriteLine("Please input your first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please input your second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double greater = HighVal(num1, num2);
        
        Console.WriteLine($"a = {num1}; b = {num2}");
        Console.WriteLine("The larger number is: " + greater);
        
    
        //Question 2
        int num3;

        Console.WriteLine("Assign an int value to N: ");
        num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Left or right?: ");
        string direction = Console.ReadLine();

        Console.WriteLine($"N is: {num3}; shape is {direction}");
        TriLR(num3, direction);
    }

    
    
    //Goes with Question 1
    static double HighVal(double num1, double num2)
    {
        if(num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }

    
    //Goes with Question 2
    static void TriLR(int num3, string direction)
    {
        if(direction == "left")
        {
            for(int row = 0; row < num3; row++){
                for(int col = 0; col < num3; col++)
                {
                if(row>=col)
                    Console.Write("*");
                }
                Console.WriteLine("");
                }
        }
        else
        {
            int x, y, z;
            for (x = 1; x <= num3; x++) {
                for (y = 0; y < num3 - x; y++)
                {
                    Console.Write(" ");
                }
                for (z = 1; z <= x; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}


