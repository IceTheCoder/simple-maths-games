using System;

namespace Math_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            string answer;

            Random random = new Random();
            num1 = random.Next(1, 11); // generates a random integer between 1 and 100
            num2 = random.Next(1, 11); // generates a random integer between 1 and 100
            num3 = random.Next(1, 11); // generates a random integer between 1 and 100

            Console.WriteLine(num1.ToString() + " * " + num2.ToString() + " + " + num3.ToString());
            answer = Console.ReadLine();

            if (Convert.ToInt32(answer) == num1 * num2 + num3) {
                Console.WriteLine("Correct!");
            } else {
                Console.WriteLine("Incorrect!");
            }
            num1 = random.Next(1, 11); // generates a random integer between 1 and 100
            num2 = random.Next(1, 11); // generates a random integer between 1 and 100
            num3 = random.Next(1, 11); // generates a random integer between 1 and 100

            Console.WriteLine(num1.ToString() + " * " + num2.ToString() + " + " + num3.ToString());
            answer = Console.ReadLine();

            if (Convert.ToInt32(answer) == num1 * num2 + num3) {
                Console.WriteLine("Correct!");
            } else {
                Console.WriteLine("Incorrect!");
            }
            num1 = random.Next(1, 11); // generates a random integer between 1 and 100
            num2 = random.Next(1, 11); // generates a random integer between 1 and 100
            num3 = random.Next(1, 11); // generates a random integer between 1 and 100

            Console.WriteLine(num1.ToString() + " * " + num2.ToString() + " + " + num3.ToString());
            answer = Console.ReadLine();

            if (Convert.ToInt32(answer) == num1 * num2 + num3) {
                Console.WriteLine("Correct!");
            } else {
                Console.WriteLine("Incorrect!");
            }

            Console.ReadKey();
        }
    }
}