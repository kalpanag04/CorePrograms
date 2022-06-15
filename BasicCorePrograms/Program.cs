class QR
{
    public static void Main(string[] args)
    {
        //int num = 117;

        Console.WriteLine("Enter a Number : ");
        int num =Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("Number is Even");
        }
        else
        {
            Console.WriteLine("Number is ODD");
        }
    }
}