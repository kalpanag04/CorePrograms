class Alphabets
{
    public static void Main(string[] args)
    {
        for (char i = 'a'; i <= 'z'; i = (char)(i + 1))
        {
            if(i == 'a' || i=='e' || i=='i' || i=='o' || i=='u')
            {
                Console.WriteLine(i+ " is Vowel ");
            }
            else
            {
                Console.WriteLine(i+ " is Consonent");
            }
        }

        Console.WriteLine("----------------------------------");

        Console.WriteLine("Enter an Alphabet : ");
        char j=Convert.ToChar(Console.ReadLine());

        if (j == 'a' || j == 'e' || j == 'i' || j == 'o' || j == 'u')
        {
            Console.WriteLine(j + " is Vowel ");
        }
        else
        {
            Console.WriteLine(j + " is Consonent");
        }

    }
}