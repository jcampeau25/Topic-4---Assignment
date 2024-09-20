using System.Numerics;

namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // Name + Salary
            string name;
            int age;
            double pay;

            Console.WriteLine("Hello! What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "! How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("You're " + age + "? How much do you make a year?");
            Double.TryParse(Console.ReadLine(), out pay);
            Console.WriteLine("Wow, you're doing pretty well for yourself");
            Console.WriteLine();

            //// Login
            string firstName, lastName, login;
            int studentNumber, grade;
            double average;

            Console.WriteLine("Please enter the following information");
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Grade (9-12): ");
            Int32.TryParse(Console.ReadLine(), out grade);
            Console.Write("Student ID: ");
            Int32.TryParse(Console.ReadLine(), out studentNumber);
            Console.Write("Login: ");
            login = Console.ReadLine();
            Console.Write("Average: ");
            Double.TryParse(Console.ReadLine(), out average);

            Console.WriteLine();
            Console.WriteLine("Your Information:");
            Console.WriteLine("Login:   " + login);
            Console.WriteLine("ID:      " + studentNumber);
            Console.WriteLine("Name:    " + firstName + ", " + lastName);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Grade:   " + grade);
            Console.WriteLine();

            // Age in 5 Years
            string yourName;
            int yourAge, ageInFive;
            Console.WriteLine("Hello, what is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello " + yourName + " How old are you?");
            Int32.TryParse(Console.ReadLine(), out yourAge);
            ageInFive = yourAge + 5;
            Console.WriteLine("Your age in 5 years will be " + ageInFive);
            Console.WriteLine();

            // Dumb Calculator
            double num1, num2, num3, sum, numTotal;

            Console.WriteLine("Please enter a number");
            double.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Please enter another number");
            double.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("Please enter a third number");
            double.TryParse(Console.ReadLine(), out num3);
            sum = num1 + num2 + num3;
            numTotal = sum / 2;
            Console.WriteLine("Those numbers added together and divided by two is " + numTotal);
            Console.WriteLine();

            // Receipt
            string item1, item2;
            double price1, price2, discount, total, tax, subtotal, finalAmount;

            Console.WriteLine("Please enter the first item you bought");
            item1 = Console.ReadLine();
            Console.WriteLine("Please enter the price of that item");
            double.TryParse(Console.ReadLine(), out  price1);
            Console.WriteLine("Please enter the second item you bought");
            item2 = Console.ReadLine();
            Console.WriteLine("Please enter the price of that item");
            double.TryParse(Console.ReadLine(), out price2);
            
            total = price1 + price2;
            discount = total * 0.2;
            subtotal = total - discount;
            tax = subtotal * 0.13;
            finalAmount = subtotal - tax;

            Console.WriteLine("Sales Receipt");
            Console.WriteLine();
            Console.WriteLine("Item 1: " + item1);
            Console.WriteLine("Price: " + Math.Round(price1, 2));
            Console.WriteLine("Item 2: " + item2);
            Console.WriteLine("Price: " + Math.Round(price2, 2));
            Console.WriteLine("===================");
            Console.WriteLine("Total: " + Math.Round(total, 2));
            Console.WriteLine("Discount (20%): " + Math.Round(discount, 2));
            Console.WriteLine("Subtotal: " + Math.Round(subtotal, 2));
            Console.WriteLine("Tax (13%): " + Math.Round(tax, 2));
            Console.WriteLine("Total owed: " + Math.Round(finalAmount, 2));


















        }
    }
}
