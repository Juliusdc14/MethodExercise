using System;

namespace MethodExercise
{
    class Program

    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        static void Main(string[] args)
        {
            var amountOfParts = Sum(2, 6);



            //---------------Exercise 1---------------------------------
            Console.WriteLine($"Hello! What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}  Where are your from?");
            var location = Console.ReadLine();

            Console.WriteLine($"{location} is a wonderful place! How old are you?");
            var userAge = Console.ReadLine();

            Console.WriteLine($"Awesome! What is your favorite food?");
            var food = Console.ReadLine();

            Console.WriteLine($"Sounds Delicious! What is your favorite hobby?");
            var hobby = Console.ReadLine();

            Console.WriteLine($"That sounds cool!");

            Console.WriteLine($"Thanks,  {userName}! Here is your profile.");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Location: {location}");
            Console.WriteLine($"Age:{userAge}");
            Console.WriteLine($"Favorite food: {food}");
            Console.WriteLine($"Hobby: {hobby}");


            //---------------Exercise 2---------------------------------



        }
    }
}
