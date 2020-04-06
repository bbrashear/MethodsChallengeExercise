using System;

namespace MethodsChallengeExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1000;

            CountBack(a);

            int b = 3;

            AddThree(b);

            Console.WriteLine("Give me a number");
            int isEqual1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number");
            int isEqual2 = int.Parse(Console.ReadLine());

            Console.WriteLine(isEqual(isEqual1, isEqual2));

            Console.WriteLine("Give me a number");
            int evenOrOdd = int.Parse(Console.ReadLine());
            Console.WriteLine(EvenOrOdd(evenOrOdd));

            Console.WriteLine("Give me a number");
            int posOrNeg = int.Parse(Console.ReadLine());
            Console.WriteLine(PosOrNeg(posOrNeg));

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(VotingAge(age));

            Console.WriteLine("I'm thinking of a number in a range. Take a guess.");
            int range = int.Parse(Console.ReadLine());
            Console.WriteLine(Range(range));

            Console.WriteLine("What number would you like to see the multiplication table for?");
            int multi = int.Parse(Console.ReadLine());
            MultiTable(multi);

            Console.WriteLine("How many numbers long would you like your list to be?");
            int[] sumNumbers = MakeArray(int.Parse(Console.ReadLine()));
            foreach (int sumNumber in sumNumbers)
            {
                Console.WriteLine($"Here is your list of randomly generated numbers: {sumNumber}");
            }
            Console.WriteLine($"And here is the sum: {Summation(sumNumbers)}");

            Console.WriteLine("What number would you like to know the cube of?");
            Console.WriteLine(CubeANum(int.Parse(Console.ReadLine())));


        }

        public static int CountBack(int a)
        {
            do
            {
                Console.WriteLine(a--);
            } while(a >= -1000);

            return a;
        }

        public static int AddThree(int b)
        {
            while(b < 999)
            {
                b = b + 3;
                Console.WriteLine(b);
            }

            return b;
        }

        public static bool EvenOrOdd(int evenOrOdd)
        {
            return evenOrOdd % 2 == 0;
        }

        public static bool isEqual(int isEqual1, int isEqual2)
        {
            return isEqual1 == isEqual2;
        }

        public static string PosOrNeg(int posOrNeg)
        {
            if(posOrNeg > 0)
            {
                return "The number is positive";
            }
            else if (posOrNeg < 0)
            {
                return "The number is negative";
            }
            else
            {
                return "The number is 0";
            }
        }

        public static string VotingAge(int age)
        {
            
            if(age >= 18)
            {
                return "You can vote!";
            }
            else
            {
                return "You're too young :(";
            }
        }

        public static string Range(int range)
        {

            if(range >= -10 && range <= 10)
            {
                return "The number is in the range";
            }
            else
            {
                return "The number is outside of the range";
            }
        }

        public static void MultiTable(int multi)
        {
            int product = 0;
            int c = 1;
            while(c <= 12)
            {
               product = multi * c;
                c++;
                Console.WriteLine($"{multi} * {c} = {product}");
            }
        }

        public static int[] MakeArray(int arrayNum)
        {
            int[] sumNumbers = new int[arrayNum];

            Random rng = new Random();

            for(int i = 0; i < sumNumbers.Length; i++)
            {
                sumNumbers[i] = rng.Next(51);
            }

            return sumNumbers;
        }

        public static int Summation(int[] sumNumbers)
        {
            int sum = 0;

            foreach(int sumNumber in sumNumbers)
            {
                sum += sumNumber;
            }
            return sum;
        }

        public static string CubeANum(int cubeNum)
        {
            int cube = cubeNum * cubeNum * cubeNum;
            return $"Number is: {cubeNum} and the cube of {cubeNum} is: {cube}";
        }
    }
}
