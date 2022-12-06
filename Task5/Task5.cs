using System;

public class Task5
{
    public static void Main()
    {
        DateTime dt1 = new DateTime(1992, 05, 31);
        DateTime dt2 = new DateTime(2016, 06, 17);

        TimeSpan result = dt2.Subtract(dt1);
        Console.WriteLine(result);
      
    }
}