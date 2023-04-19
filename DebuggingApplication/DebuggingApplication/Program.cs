namespace DebuggingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:c");
            string userResponse = Console.ReadLine();
            int userIntResponse;
            if (int.TryParse(userResponse, out userIntResponse))
            {
                Console.WriteLine($"The entered value is integer: {userIntResponse}");
            }
            else
            {
                Console.WriteLine("The entered value is invalid, only integers are allowed");
            }

            Console.ReadKey();
        }
    }
}