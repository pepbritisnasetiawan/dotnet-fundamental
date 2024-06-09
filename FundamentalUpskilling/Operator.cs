namespace FundamentalUpskilling;

public class Operator
{
    public void Main(string[] args)
    {
        /*
         * Arithmetic Operator
         * (+ - * / %)
         */

        var a = 10 + 11;
        var b = 10 - 6;
        var c = 10 * 11;
        var d = 10 / 2;
        var e = 10 % 2;
        Console.WriteLine($"tambah: {a}");
        Console.WriteLine($"kurang: {b}");
        Console.WriteLine($"kali: {c}");
        Console.WriteLine($"bagi: {d}");
        Console.WriteLine($"sisa bagi: {e}");

        double bd = 10.0 + 20;
        var db = 10.5 + 2;
        
        /*
         * Comparasion Operator
         * <, >, <=, >=, ==, != 
         */
        var cc = db < a;
        Console.WriteLine(cc);
        
        // increment x++, x--, ++x, --x
        Console.WriteLine(c++); // akan keluar +1 di line berikutnya
        Console.WriteLine(c);

        Console.WriteLine(++a); // langsung bertambah
        Console.WriteLine(a);
        
        /*
         * Logical Operator
         * && , ||
         */

        var logic = a > b && b > d;
        Console.WriteLine(logic);
        
    }
}