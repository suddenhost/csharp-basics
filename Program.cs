using System;


class Program
{
    static void PrintHello() {
        String message = "Hello, World!";
        int x = 15;
        decimal y = 123.45m;
        bool z = true;
        Console.WriteLine("{0}, {1}, {2}, {3}", message, x, y, z);   

        int minimumAge = 21;
        int actualAge = 20;

        if (actualAge > minimumAge)
        {
            Console.WriteLine("Age is greater than the minimum age.");
        } else if (actualAge == minimumAge)
        {
            Console.WriteLine("Age is equal to minimum age.");
        } else
        {
            Console.WriteLine("Age is smaller than the minimum age.");
        }
    }

}


