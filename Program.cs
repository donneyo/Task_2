namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
            // Prompt the user to enter an integer
            Console.Write("Please enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the number is even or odd
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            // Keep the console window open
            Console.ReadLine();
    }
}
