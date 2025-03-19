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
using System;
namespace number
{
    class checkNum
    {
        public static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Enter the number between 1 to 10 :");
            n = Convert.ToInt32(Console.ReadLine());
            if(n > 0 && n <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}