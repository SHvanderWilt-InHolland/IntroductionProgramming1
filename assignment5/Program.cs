namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a Random object to generate random numbers
            Random random = new Random();
            int[] numbers = new int[4];
            int correct = 0;


            Console.WriteLine("Add the following four numbers: ");

            // loops the random number generation 4 times
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(101, 1000);
                Console.WriteLine(numbers[i]);
                correct += numbers[i];
            }

            Console.WriteLine("Enter the sum of the four numbers: ");
            string input = Console.ReadLine();

            // Try to parse the user input to an integer
            if (int.TryParse(input, out int userSum))
            {
                if (userSum == correct)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct sum is {correct}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
        }
    }
}
