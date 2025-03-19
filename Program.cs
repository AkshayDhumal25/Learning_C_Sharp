//using System;

//namespace learning
//{
//    class learn
//    {
//        public enum ShippingMethod
//        {
//            RegularAirMail =1,
//            RegisteredAirMail =2,
//            Express =3
//        }
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("Hello Akshay");
//            var firstName = "Akshay";
//            var secondName = "Dhumal";
//            //Console.WriteLine(firstName);
//            //var fullName = firstName + " " + secondName;                              // Concatenation of strings
//            //Console.WriteLine(fullName);
//            // var fullName = string.Format("My name is {0} {1}", firstName, secondName);
//            var names = new string[3] { "Akshay", "Dadapatil", "Dhumal" };
//            var formattedNames = string.Join(",", names);
//            //Console.WriteLine(formattedNames);
//            var text = @"Hi Akshay
//Look into the following paths
//c:\folder1\folder2
//c:\folder3\folder2";
//            //Console.WriteLine(text);
//            //var method = ShippingMethod.Express;
//            //Console.WriteLine((int)method);

//            //var methodId = 3;
//            //Console.WriteLine((ShippingMethod)methodId);


//            //******** Value Types and Reference Types ****************
//            var a = 10;
//            var b = a;
//            b++;
//            //Console.WriteLine("A :" + a + " " + "B :" + b);

//            var array1 = new int[3] {1,2,3} ;
//            var array2 = array1;
//            array2[0] = 0;
//            //Console.WriteLine(array1[0]);
//            //Console.WriteLine(array2[0]);

//        }
//    }
//}


//using System;

//namespace CSharpFundamentals
//{
//    public class Person
//    {
//        public int Age;
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var number = 1;
//            Increment(number);
//            Console.WriteLine(number);

//            var person = new Person() { Age = 20 };
//            MakeOld(person);
//            Console.WriteLine(person.Age);
//            Console.WriteLine("Hwllo world");
//        }
//        public static void Increment(int number)
//        {
//            number += 10;
//        }

//        public static void MakeOld(Person person)
//        {
//            person.Age += 10;
//        }
//    }
//}



//using System;
//using System.Diagnostics.Contracts;
//namespace Conditionals
//{
//    class Program
//    {
//        public enum Season
//        {
//            Spring,
//            Summer,
//            Autumn,
//            Winter
//        }
//        static void Main(string[] args)
//        {
//            //int hour = 19;
//            //if(hour >0  && hour < 12)
//            //{
//            //    Console.WriteLine("It's morning.");
//            //}else if(hour >= 12 && hour < 14)
//            //{
//            //    Console.WriteLine("It's afternoon.");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("It's a evening.");
//            //}

//            //bool isGoldCustomer = true;
//            //float price;
//            //if (isGoldCustomer)
//            //{
//            //    price = 19.95f;
//            //}
//            //else
//            //{
//            //    price = 29.95f;
//            //}
//            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
//            //Console.WriteLine(price);

//            //var season = Season.Autumn;

//            //switch (season)
//            //{
//            //    case Season.Autumn:
//            //        Console.WriteLine("It's autumn and a beautiful");
//            //        break;
//            //    case Season.Summer:
//            //        Console.WriteLine("It's perfect to go to beach.");
//            //        break;
//            //    default:
//            //        Console.WriteLine("I don't understand that season!");
//            //        break;
//            //}
//        }
//    }
//}

//********************************Exercise********************************
// Que 1.
//using System;
//namespace number
//{
//    class checkNum
//    {
//        public static void Main(string[] args)
//        {
//            int n = 0;
//            Console.WriteLine("Enter the number between 1 to 10 :");
//            n = Convert.ToInt32(Console.ReadLine());
//            if(n > 0 && n <= 10)
//            {
//                Console.WriteLine("Valid");
//            }
//            else
//            {
//                Console.WriteLine("Invalid");
//            }

//        }
//    }
//}


//**** Que 2
// 2- Write a program which takes two numbers from the console and displays the maximum of the two.
//using System;
//namespace maximum
//{
//    class MaxNum
//    {
//        public static void Main(string[] args)
//        {
//            int x, y;
//            Console.WriteLine("Enter the 1st and 2nd No to check maximum from them :");
//            x = Convert.ToInt32(Console.ReadLine());
//            y = Convert.ToInt32(Console.ReadLine());
//            if(x > y)
//            {
//                Console.WriteLine(x);
//            }
//            else
//            {
//                Console.WriteLine(y);
//            }
//        }
//    }
//}


// Que 3
//3 - Write a program and ask the user to enter the width and height of an image. 
//    Then tell if the image is landscape or portrait.
//using System;
//namespace imageCheck
//{
//    class sizeOfimage
//    {
//        public static void Main(string[] args)
//        {
//            int height, width;
//            Console.WriteLine("Enter the height of Image :");
//            height = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the width of Image :");
//            width = Convert.ToInt32(Console.ReadLine());
//            if(height > width)
//            {
//                Console.WriteLine("Portrait");
//            }
//            else
//            {
//                Console.WriteLine("Landscape");
//            }
//        }
//    }
//}


// Que 4
//using System;
//namespace Car
//{
//    class camera
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the Speed Limit :");
//            int speedLimit = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the Speed of Car :");
//            int carSpeed = Convert.ToInt32(Console.ReadLine());
//            int overSpeed = carSpeed - speedLimit; 

//            if(carSpeed < speedLimit)
//            {
//                Console.WriteLine("OK");
//            }
//            else
//            {
//                int demeritPoints = overSpeed / 5;
//                if(demeritPoints < 12)
//                {
//                    Console.WriteLine("Demerits points : " + demeritPoints);
//                }
//                else
//                {
//                    Console.WriteLine("Lincense Cancelled");
//                }
//            }
//        }
//    }
//}


//**************Iteration Statements****************
//using System;
//namespace conditionals
//{
//    class statements
//    {
//        public static void Main(string[] args)
//        {
//            //int n = Convert.ToInt32(Console.ReadLine());
//            //for(int i = 0; i < n; i++)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            //string name = Console.ReadLine();
//            //foreach(var character in name)
//            //{
//            //    Console.WriteLine(character);
//            //}

//            //int n = 1;
//            //while (n < 11)
//            //{
//            //    Console.WriteLine(n);
//            //    n++;
//            //}
//        }
//    }
//}

//******************** Random Class
//using System;
//namespace CSharpFundamentals
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //var random = new Random();
//            //for(var i = 0; i < 10; i++)
//            //{
//            //    Console.WriteLine(random.Next(1, 10));  // need more practice
//            //}

//            Console.WriteLine((int)'a');
//        }
//    }
//}


//************ Exercise Iteration Statements**********
// Que 1
//using System;
//namespace count
//{
//    class divide
//    {
//        public static void Main(string[] args)
//        {
//            int n = 100;
//            int count = 0;
//            for(int i = 1; i <= n; i++)
//            {
//                if(i % 3 == 0)
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine(count);
//        }
//    }
//}

// Que 2
//using System;
//namespace add
//{
//    class consistency
//    {
//        public static void Main(string[] args)
//        {
//            int totalSum = 0;
//            while (true)
//            {
//                Console.WriteLine("Enter the number : ");
//                string input = Console.ReadLine();
//                if (input.ToLower() == "ok")
//                {
//                    break;
//                }
//                totalSum += Convert.ToInt32(input);
//            }
//            Console.WriteLine(totalSum);
//        }
//    }
//}

// que 3
//using System;
//namespace factoral
//{
//    class numbers
//    {
//        public static void Main(string[] args)
//        {
//            int num = 0;
//            num = Convert.ToInt32(Console.ReadLine());
//            int multiplication = 1;
//            for(int i = num; i > 0; i--)
//            {
//                multiplication *= i;
//            }
//            Console.WriteLine(multiplication);

//        }
//    }
//}

// Que 4
//using System;
//namespace game
//{
//    class predict
//    {
//        public static void Main(string[] args)
//        {
//            var number = new Random().Next(1, 10);
//            Console.WriteLine("Secret Number :" + number);
//            for(var i = 0; i < 3; i++)
//            {
//                Console.WriteLine("Guess the secret number :");
//                var guess = Convert.ToInt32(Console.ReadLine());
//                if(guess == number)
//                {
//                    Console.WriteLine("You Won!!!");

//                }
//                else
//                {
//                    Console.WriteLine("You Lost !");
//                }

//            }

//        }
//    }
//}
//using System;

//namespace Game
//{
//    class Predict
//    {
//        public static void Main(string[] args)
//        {
//            Random random = new Random();
//            int secretNumber = random.Next(1, 10); // Generate a random number between 1 and 10
//            int attempts = 3; // Max number of attempts

//            Console.WriteLine("Welcome to the Number Guessing Game!");
//            Console.WriteLine($"You have {attempts} attempts to guess the correct number.");

//            for (int i = 1; i <= attempts; i++)
//            {
//                Console.Write($"Attempt {i}/{attempts} - Enter your guess (1-10): ");

//                // Validate user input
//                if (!int.TryParse(Console.ReadLine(), out int guess) || guess < 1 || guess > 10)
//                {
//                    Console.WriteLine("Invalid input! Please enter a number between 1 and 10.");
//                    i--; // Do not count this attempt
//                    continue;
//                }

//                if (guess == secretNumber)
//                {
//                    Console.WriteLine("🎉 Congratulations! You guessed the secret number correctly. You Won! 🎉");
//                    return; // Exit the game
//                }
//                else
//                {
//                    Console.WriteLine("❌ Wrong guess! Try again.");
//                }
//            }

//            // If the user fails all attempts, reveal the secret number
//            Console.WriteLine($"Game Over! The correct number was {secretNumber}. Better luck next time!");
//        }
//    }
//}

// Que 4
//using System;

//namespace getinput
//{
//    class commaSeparated
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter comma-separated values:"); // Removed extra '{'

//            var input = Console.ReadLine();
//            var number = input.Split(',');

//            var max = Convert.ToInt32(number[0].Trim()); // Trim spaces before conversion

//            foreach (var num in number)
//            {
//                var num1 = Convert.ToInt32(num.Trim()); // Trim spaces
//                if (num1 > max)
//                {
//                    max = num1;
//                }
//            }

//            Console.WriteLine("Maximum number: " + max);
//        }
//    }
//}


//************************************* Arrays and Lists ****************
using System;
namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 10, 4, 5, 9 };
            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index =Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //clear()
            Array.Clear(numbers, 0, 2);
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }


            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach(var m in another)
            {
                Console.WriteLine(m);
            }

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach(var i in numbers) {
                Console.WriteLine(i);
            }


            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }


        }
    }
}