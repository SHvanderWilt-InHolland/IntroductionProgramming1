namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read a number
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine(); 
            int number = int.Parse(input);

            // assign variable "result" based on the value of "number + number"
            int result = number + number;

            // add 10 to number
            result = result + 10;

            // divide result by 2 (use /= operator)
            result /= 2;

            // subtract original number from result (use -= operator)
            result -= number;

            Console.WriteLine($"Result is: {result}");
        }
    }
}
