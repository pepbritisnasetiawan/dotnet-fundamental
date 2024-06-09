namespace FundamentalUpskilling;

public class MyArray
{
    public void Main(string[] args)
    {
        // explicity declaration array
        var number = new int[6];
        number[0] = 1;
        number[1] = 2;
        number[2] = 3;
        number[3] = 4;
        number[4] = 5;
        
        // mengisi langsung
        string[] cities = { "Jakarta", "Bandung", "Surabaya" };
        for (var i = 0; i < cities.Length; i++)
        {
            Console.WriteLine($"kota : {cities[i]}");
        }

        var countries = new[] { "England", "Indonesia", "French" };
        foreach (var country in countries)
        {
            Console.WriteLine($"Country : {country}");
        }
        
        // Array multi dimension
        int[,] matrix = new int[2, 2];
        matrix[0, 0] = 1;
        matrix[0, 1] = 2;
        matrix[1, 0] = 3;
        matrix[1, 1] = 4;
        Console.WriteLine(matrix[0,1]);

        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine(matrix[i, j]);
            }
        }
    }
}