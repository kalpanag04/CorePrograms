class QR
{
    public static void Main(string[] args)
    {
        //t a = 14,b = 5,quotient=0,reminder=0;
        int quotient = 0, remainder = 0;
        Random random = new Random();
        int a = random.Next(0, 100);
        int b=random.Next(1,10);

        quotient = a / b;
        remainder= a % b;
        Console.WriteLine("Quotient is :" + quotient + " Reminder is : " + remainder);
    }
}