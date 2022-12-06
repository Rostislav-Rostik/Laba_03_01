static void Main ()
{
    int n = int.Parse(Console.ReadLine());
    int [] arr = new int[n];

    for (int i = 0; i < n; i++)
    {
        arr[i]= int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = i+1; j < n; j++)
        {
            if (i<j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
