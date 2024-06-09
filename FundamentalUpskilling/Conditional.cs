namespace FundamentalUpskilling;

public class Conditional
{
    public void Main(string[] args)
    {
        /*
         * if (condition - bool)
         * {
         *      statement
         * }
         */

        var a = 10.3;
        var b = 50;

        if (a < b)
        {
            Console.WriteLine($"a: {a} kurang dari b: {b}");
        } else if (a != b)
        {
            Console.WriteLine($"a {a} not equal b {b}");
        }
        else
        {
            Console.WriteLine($"a {a} > b {b}");
        }
        
        // simplify if else
        var grade = "E";
        switch (grade)
        {
            case "A":
                Console.WriteLine("Excellent");
                break;
            case "B":
                Console.WriteLine("Good");
                break;
            case "C":
                Console.WriteLine("Bad");
                break;
            default:
                Console.WriteLine("Invalid grade");
                break;
        }
    }
}