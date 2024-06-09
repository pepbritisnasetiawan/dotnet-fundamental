public class Program
{
    public void Main() // add static to make it entry point
    {
        Console.WriteLine("Hello World!");
        Console.Write("Print tanpa new line");
        Console.WriteLine();

        int number = 10; // explicit
        var num = 11; // implicit

        Console.WriteLine(number);
        Console.WriteLine(num);
        
        /*
         * Number Data Type
         * -> Integer
         *      - byte = 8bit
         *      - short = 16bit
         *      - int = 32bit
         *      - long = 64bit
         * -> Floating Point
         *      - float 32bit
         *      - double 64bit
         *      - decimal 128bit
         */
        
        /*
         * Unsiged type number / ga bisa minus
         * -> Integer Types
         *      -> ushort
         *      -> uint
         *      -> ulong
         */

        // ushort uShrt = -10; return error, cannot be negative
        // uint stockBarang = 1234; always positive, cannot negative

        // Integer
        byte bNum = 128;
        short sNum = 10000;
        int intNum = 1000000;
        long longNum = 1000000000000L;
        
        // Float
        float floatNum = 123456.6F;
        double doubleNum = 1234567712341234.6d;
        decimal decNum = 23412341234123412312345635.5m;
        
        /*
         * String 
         */

        char myChar = 'a';
        string strName = "learn c#";
        
        // escape char
        string pom = "this is \"escape\"";
        Console.WriteLine(pom);
        
        // print path or use path, ignore escape character and multi line string
        // vervatim strings
        string path = @"\\user\febri\raider";
        Console.WriteLine(path);
        
        Console.WriteLine(@"1. learn
2. practice
3. practice");
        
        // concatination
        string firsName = "febri" + "tisna";
        
        // string interpolation
        string middleName = "tisna";
        string lastName = "setiawan";

        string fullname = $"My name is {firsName} {middleName} {lastName}";
        Console.WriteLine(fullname);
    }
}