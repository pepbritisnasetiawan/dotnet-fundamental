namespace FundamentalUpskilling;

public class Looping
{
    public void Main(string[] args)
    {
        /*
         * for -> counted loop -> tau kapan berenti
         * while -> uncounted loop
         * do while
         */

        for (var i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine($"{i} = Fizz Buzz");
            } else if (i % 3 == 0)
            {
                Console.WriteLine($"{i} = Fizz");
            } else if (i % 5 == 0)
            {
                Console.WriteLine($"{i} = Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

        var j = 1;
        while (j <= 10)
        {
            Console.WriteLine($"Looping while ke {j}");
            j++;
        }

        var k = 1;
        do
        {
            Console.WriteLine($"minimal jalan sekali {k}");
            k++;
        } while (k < 20);

        // Console.WriteLine("Masukkan input: ");
        // var input = Console.ReadLine();

        // var convToInt = Convert.ToInt16(input); // convert input
        // Console.WriteLine(input);
        // Console.WriteLine(convToInt.GetType());

        for (var row = 1; row < 11; row++)
        {
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The cell is ({row}, {column})");
            }
        }
        
        // palindrom
        var strings = "kodok";
        var palindrom = "";
        for (var a = strings.Length - 1; a >= 0 ; a--)
        {
           palindrom += Convert.ToString(strings[a]);
        }

        var c = palindrom.Contains(strings);
        Console.WriteLine(c);
    }
}