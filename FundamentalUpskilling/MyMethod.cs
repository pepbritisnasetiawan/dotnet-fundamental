namespace FundamentalUpskilling;

public class MyMethod
{
    public void Main(string[] args)
    {
        SayHello();
        Hello("Febrian");
        var sum = Sum(10, 8);
        Console.WriteLine(sum);
        Console.WriteLine(Sum(7, 6));
        
        // anonymous method => only use in local
        var Print = delegate(string any)
        {
            Console.WriteLine($"Ini {any} anon method");
        };
        
        // lamda, in js like arrow function
        var lamdaNi = () =>
        {
            Console.WriteLine("Ini lambda");
        };

        lamdaNi();
        
        Print("oke ini anon method/function");
    }
    
    /*
     * structure method in c#
     * access modifier static/non-static  returnType(void/tipe data) MethodName(param)
     * {
     *      body method
     * }
     * 
     * static method only accessible for another static method
     * another method only can access via create it object
     */

    static void SayHello()
    {
        Console.WriteLine("Hello World!");
    }

    static void Hello(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    static int Sum(int a, int b)
    {
        var result = a + b;
        return result;
    }
}