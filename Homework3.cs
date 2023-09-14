namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Question 1
        int num1;
        bool prime = true;

        Console.WriteLine("Input an integer:");
        num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 <= 1)
        {
            Console.WriteLine("N is non-prime");
        }
        else
        {
            for (int i = 2; i <= num1 / 2; i++)
            {
                if (num1 % i == 0)
                {
                    prime = false;
                    break;
                }
            }
        }
        if(prime)
        {
            Console.WriteLine("N is prime");
        }
        else
        {
            Console.WriteLine("N is non-prime");
        }


        //Question 2
        int num2;

        Console.WriteLine("Assign an int value to N:");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        for(int row = 0; row<num2; row++)
        {
            for(int col = 0; col<num2; col++)
            {
                Console.Write('*');
            }
            Console.WriteLine("");
        }


        //Question 3
        int num3;

        Console.WriteLine("Assign an int value to N: ");
        num3 = Convert.ToInt32(Console.ReadLine());   
        
        for(int row = 0; row < num3; row++){
            for(int col = 0; col < num3; col++)
            {
            if(row>=col)
                Console.Write('*');
            }
            Console.WriteLine("");
        }


        //Bonus
        int x, y, z, num4;
    
        Console.WriteLine ("Assign an int value to N:");
        num4 = Convert.ToInt32 (Console.ReadLine ());
        
        for (x = 1; x <= num4; x++) {
            for (y = 0; y < num4 - x; y++)
            {
                Console.Write(" ");
            }
                for (z = 1; z <= x; z++)
                {
                    Console.Write(x);
                }
            Console.WriteLine();
        }
    }
}
