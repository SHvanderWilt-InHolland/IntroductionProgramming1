namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks and reads the age of the user and stores it in the variable "age"
            Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine();

            //convert text to integer
            int age = int.Parse(input);

            //now we can perform some (arithmetic) operations on the (int) age
            //(Which are not possible on the string value)
            age = age + 1;

            //convert integer value to text
            string output = age.ToString();

            // display the increased age
            Console.WriteLine("Next year you will be " + output + " years old.");

            //wait for the user to enter a key
            Console.ReadKey();
        }
    }
}
