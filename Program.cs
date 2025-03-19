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



using System;
 namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            if(hour >0  && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
        }
    }
}