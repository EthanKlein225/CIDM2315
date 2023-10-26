namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);


        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        // Test Q2.1
        PrintAllOddNumber(array_2d);


        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");


        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
            foreach(int num in Q2_3){
                Console.Write(num +" ");
            }

        // Q1
        static void ArraySum(int[] int_array){
            //put your answer below
            int i;
            int sum = 0;
            for (i = 0; i < 5; i++) {
            sum += int_array[i];
            }
            Console.WriteLine($"The Sum of int_array is: {sum}");
        }


        //Q2.1
        static void PrintAllOddNumber(int[ , ] array_2d){
            foreach(int val in array_2d){
                if(val % 2 != 0){
                    Console.Write(val +" ");
                }
            }  
        }
        
        //Q2.2
        static int ElementSum(int[ , ] array_2d){
            //put your answer below
            int sum = 0;
            foreach (int i in array_2d)
                {
                    sum = sum + i;
                }
                return sum;
        }

        // Q2.3
        static int[ , ] DoubleArray(int[ , ] array_2d){
            int[,] newArray_2d = {
            {1*2, 2*2, 3*2},
            {4*2, 5*2, 6*2},
            {7*2, 8*2, 9*2}
            };
            array_2d = newArray_2d;
            return array_2d;
        }
    }
}
