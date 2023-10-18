namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        Customer Alice = new Customer(cus_id:110, cus_name:"Alice", cus_age:28);
        Alice.PrintCusInfo();
        Customer Bob = new Customer(cus_id:111, cus_name:"Bob", cus_age:30);
        Bob.PrintCusInfo();
        Alice.ChangeID(220);
        Alice.PrintCusInfo();
        Bob.ChangeID(221);
        Bob.PrintCusInfo();
        Alice.CompareAge(Bob);
    }
}
class Customer{
    public int id = 0;
    public string name = string.Empty;
    public int age = 0;
    private int cus_id;
    public string cus_name;
    public int cus_age;
    public Customer(int cus_id, string cus_name, int cus_age){
        id = cus_id;
        name = cus_name;
        age = cus_age;
        this.age = age;
        this.name = name;
    }
    public void ChangeID(int new_id){
        id = new_id;
    }
    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {id}, name: {name}, age: {age}");
    }
    public void CompareAge(Customer objCustomer){
        if(this.age > objCustomer.age){
            Console.WriteLine($"{this.name} is older");
        }else{
            Console.WriteLine($"{objCustomer.name} is older");
        }
    }
}