using System;
class TestFullName
{
    public static void Main()
    {
        Type t = typeof(123123);
        Console.WriteLine (t.FullName);
    }
}