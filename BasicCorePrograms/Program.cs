class Largest
{
    public static void Main(string[] args)
    {
        int a = 10, b = 20, c = 30;

        Console.WriteLine("a=" + a + " b=" + b + " c=" + c);

        if(a>b && a > c)
        {
            Console.WriteLine("a is greater ");
        }
        else if(b>a && b > c)
        {
            Console.WriteLine("b is Greater ");
        }
        else //else if(c>a && c>b)
        {
            Console.WriteLine("c is greater ");
        }

        Console.WriteLine("__________________________________");

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("a is greater ");
            }
            else
            {
                Console.WriteLine("b is greater");
            }
        }
        else if(b > c)
        {
            Console.WriteLine("b is greater ");
        }
        else
        {
            Console.WriteLine("c is greater ");
        }
    }
}