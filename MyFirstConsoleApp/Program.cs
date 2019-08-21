using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{





    class Program
    {
        static void Main(string[] args)
        {
            //string myVariable = "Hello World!";
            string myStringVariable;
            myStringVariable = "steve";

            int myIntVariable;
            myIntVariable = 12341234;

            decimal myDecimalVariable;
            myDecimalVariable = 12341234.123m;
            
            bool myBool = true;

            if (myBool) 
            {
                Console.WriteLine("We'll never hit this code.");
            }

            switch (myIntVariable)
            {
                case 1:
                    Console.WriteLine("We'll never hit this code.");
                    break;
                case 12341234:
                    Console.WriteLine("We'll hit this code.");
                    break;
                default: 
                    Console.WriteLine("We'll never hit this code.");
                    break;
            }

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"we're on iteration {i}");
            }

            var myThing = new { Stuff = "steve", otherproperty = 123, };
            
            List<string> myStrings = new List<string>();
            myStrings.Add("blerg");
            myStrings.Add("blarg");
            myStrings.Insert(1,"blirg");
            myStrings.Remove("blirg");
            myStrings.RemoveAt(1);

            foreach (var myString in myStrings)
            {
                Console.WriteLine(myString);
            }

            Console.WriteLine(myThing.Stuff);
            //myStrings.Add(1);
            //myStrings.Add(true);

        }
    }
}
