/* using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";        // определяем переменную и инициализируем ее

            Console.WriteLine(name);    // Tom

            name = "\n\"Bob\"";         // меняем значение переменной

            Console.WriteLine(name);    // Bob

            Console.Read();
        }
    }
} */

/* using System;

namespace Begginer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";
            int age = 34;
            bool isEmployed = true;
            double weight = 75.65;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Is eployed? {isEmployed}");
        }
    }
}*/


/* using System;

namespace Beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! How are you?");

            Console.ReadKey();
        }
    }
} */

/* using System;

namespace Beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your salary, $: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Name: {name} Age: {age} Height: {height} Salary: {salary}$");

        }
    }
} */

