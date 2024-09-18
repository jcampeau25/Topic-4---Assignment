namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, firstName, lastName, login;
            int age, studentNumber;
            double pay, average;


            // Name + Salary
            Console.WriteLine("Hello! What is your name?" );
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "! How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("You're " + age + "? How much do you make a year?");
            Double.TryParse(Console.ReadLine(), out pay);
            Console.WriteLine("Wow, you're doing pretty well for yourself");
            Console.WriteLine();

            // Login



        }
    }
}
