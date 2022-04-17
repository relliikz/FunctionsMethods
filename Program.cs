using System;
using System.Linq;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
/*   #1      string greeting = "a";
            while (greeting != "HELLO")
            {
                greeting = SayHello();
            } */
//   #2     string naming = Welcoming();
//   #3     int addition = AddNumbers();
//   #4     int spaces = CountWhiteSpaces();
//   #5     string tables = ArrayElements();
//   #6     int numberswap = SwapNumbers();
/*   #7     Console.WriteLine("Please input first number");
            double value1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input Exponent");
            double value2 = double.Parse(Console.ReadLine());
            double solution = Power(value1,value2);
            Console.WriteLine("The answer is: " + solution);
        }   */
/*   #8     Console.WriteLine("input length of fibonacci sequence as a numeral");
            int num = int.Parse(Console.ReadLine());
            int[] numFib = new int[num];
            numFib = Fibonacci(num);
            Console.WriteLine("fibonacci sequence of " + num + " numbers is:");
            foreach (int i in numFib)
            {
                Console.WriteLine(i);
            } */
/*  #9      Console.WriteLine("Enter a number to find out if it is a prime number");
            int num = int.Parse(Console.ReadLine());
            bool isTrue = IsPrime(num);
            if (isTrue == true)
            Console.WriteLine(num + " is a prime number");
            else
            Console.WriteLine(num +" is not a prime number");
         */
/*  #10     Console.WriteLine("Input a number");
            string num = Console.ReadLine();
            int sum = Sum(num);
            Console.WriteLine("The sum of the number statement input is " + sum);
         */
        }

/*   #1     static string SayHello(){
            string input;
            while(true)
            {
                Console.WriteLine("Hello");
                input = Console.ReadLine();
                input = input.ToUpper();
                if (input == "HELLO")
                break;
                Console.WriteLine("Invalid Input");
            }
                Console.WriteLine("Welcome Friends!");
                Console.WriteLine("Have a nice day!");
            return input;
        } */
/*  #2       static string Welcoming(){
            string input;
            while(true)
            {
                Console.WriteLine("Whats your name?");
                input = Console.ReadLine();
                break;
            }
                Console.WriteLine("Welcome " + input);
                Console.WriteLine("Have a nice day!");
            return input;
        } */
/*  #3       static int AddNumbers()
        {
            Console.WriteLine("Please enter a number");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int number2 = Int32.Parse(Console.ReadLine());
            int result = number1 + number2;
            Console.WriteLine("The sum of these 2 numbers is " + result);
            return result;
        } */
/*  #4      static int CountWhiteSpaces()
        {
            Console.WriteLine("Please enter a string");
            string spaces = Console.ReadLine();
            int countSpaces = spaces.Count(Char.IsWhiteSpace);
            Console.WriteLine("There are " + countSpaces + " blank spaces in that sentence");
            return countSpaces;
        } */
/*  #5       static string ArrayElements ()
        {
            Console.WriteLine ("Please enter 5 numbers");
        string[] nums = new string[5];

        nums[0] = Console.ReadLine();
        nums[1] = Console.ReadLine();
        nums[2] = Console.ReadLine();
        nums[3] = Console.ReadLine();
        nums[4] = Console.ReadLine();
              Console.WriteLine ("==================");

        int total = Int32.Parse(nums[0]) + Int32.Parse(nums[1]) + Int32.Parse(nums[2]) + Int32.Parse(nums[3]) + Int32.Parse(nums[4]);
        Console.WriteLine("The sum of elements is " + total);
        return total.ToString();
        } */
/*  #6       static int SwapNumbers()
        {
            Console.WriteLine("Please enter a number");
            int firstnum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int secondnum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The first Number is " + secondnum + ", The second Number is " + firstnum);
            return firstnum;
        }    */    
        
/*  #7         static double Power(double value1, double value2)
        {
            double solution = Math.Pow(value1, value2);
            return solution;
        } */

/*  #8           static int[] Fibonacci(int num)
        {
            List<int> FibonacciList = new List<int>();
            FibonacciList.Add(0);
            FibonacciList.Add(1);
            int sum;
            for (int i = 2; i < num; i++)
            {
                sum = FibonacciList[i - 2] + FibonacciList[i-1];
                FibonacciList.Add(sum);
            }
            int[] FibonacciArray = FibonacciList.ToArray();
            return FibonacciArray;
        } */
/*  #9             static bool IsPrime(int n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        } */
/*  #10     static int Sum(string num)
        {
            int sum = 0;
            List<int> numList = new List<int>();
            foreach(char c in num)
            {
                string asString = c.ToString();
                int asInteger = int.Parse(asString);
                numList.Add(asInteger);
            }
            foreach(int i in numList)
                sum += i;
                return sum;
        } */

    } // end program class
} // end namespace
