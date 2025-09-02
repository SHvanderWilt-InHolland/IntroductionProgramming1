namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable "name" is declared here
            string name;

            // reads the name of the user and stores it in the variable "name"
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            // reads the age of the user and stores it in the variable "age"
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();

            // display name and age
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);

            //wait for the user to enter a key
            Console.ReadKey();
        }
    }
}
