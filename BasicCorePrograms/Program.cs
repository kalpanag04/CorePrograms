class Swap
{
    public static void Main(string[] args)
    {
        int a = 10, b = 20,temp=0;
        Console.WriteLine("Before Swaping : a=" + a + " b=" + b);
        temp = a;
        a= b;   
        b= temp;
        Console.WriteLine("After Swaping : a=" + a + " b=" + b);

        Console.WriteLine("==============================");

        int x = 5, y = 10;
        Console.WriteLine("Before swaping : x=" + x + " y=" + y);
        x = x + y;
        y = x - y;
        x = x - y;
        Console.WriteLine("After swaping : x=" + x + " y=" + y);

        Console.WriteLine("==============================");

        int m = 2, n = 4;
        Console.WriteLine("Before swaping : m=" + m + " n=" + n);
        m = m * n;
        n = m / n;
        m = m / n;
        Console.WriteLine("After swaping : m=" + m + " n=" + n);

        Console.WriteLine("==============================");

        int i = 10, j = 20;
        Console.WriteLine("Before swaping : i=" + i + " j=" + j);
        i = i ^ b;
        j = i ^ j;
        i = i ^ j;
        Console.WriteLine("After swaping : i=" + i + " j=" + j);
    }
}