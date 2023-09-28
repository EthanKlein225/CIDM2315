namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        //Question 1
        Console.WriteLine("Please input your first integer: ");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input your second integer: ");
        int b = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {Max(a, b)}");
        

        //Question 2
        Console.WriteLine("Please input your first integer: ");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input your second integer: ");
        int b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input your third integer: ");
        int c = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input your fourth integer: ");
        int d = Convert.ToInt16(Console.ReadLine());
        
        int max1 = Max(a, b);
        int max2 = Max(c, d);
              
        Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d}");
        Console.WriteLine($"The largest number is: {Max(max1, max2)}");


        //Question 3
        createAccount();
    }

    //Used in Question 1 and Question 2
    static int Max(int num1, int num2)
    {
        if(num1 >= num2){
            return num1;
        }
        else{
            return num2;
        }
    }

    //Used for Question 3
    static bool checkAge(int birth_year)
    {
        if(2022 - birth_year >= 18){
            return true;
        }
        else{
            return false;
        }
    }

    //Used for Question 3
    static void createAccount()
    {
        Console.WriteLine("Enter Your Username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter Your Password:");
        string password1 = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again:");
        string password2 = Console.ReadLine();
        Console.WriteLine("Enter Your Birthyear:");
        int birth_year = Convert.ToInt16(Console.ReadLine());

        if(checkAge(birth_year) == true){
            if(password1 == password2){
                Console.WriteLine("Account is created successfully");
            }
            else{
                Console.WriteLine("Wrong password");
            }
        }
        else{
            Console.WriteLine("Could not create an account");
        }
    }
}
