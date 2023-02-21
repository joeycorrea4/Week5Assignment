namespace week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProblemTwo();
            ProblemOne();
            ProblemFive();
        }

       

void ProblemTwo()
{
            var sum = 0;
            while (true)
            {
                Console.Write("Enter any number (or type'ok' to exit): ");
                var input = Console.ReadLine();
                int newVariable = 0;
                if (input.ToLower() != "ok")
                {
                    newVariable = Convert.ToInt32(input);
                }

                input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                    sum += newVariable;
                }
            }
            Console.WriteLine("Sum of all entered numbers is: " + sum);
        }

void ProblemOne()
{
            Console.WriteLine("Please enter a number and get the factorial of it");

            int number = int.Parse(Console.ReadLine());
            int factorial = 1;



            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("{0}! : {1}", number, factorial);
 }

void ProblemFive()
{
            Console.Write("Enter a series of numbers, make sure they are seperated by commas(,) : ");

            var userInput = Console.ReadLine();

            var numbers = userInput.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("The max from these series of numbers is " + max);

        }
    }
}