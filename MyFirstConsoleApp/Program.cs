using System;
using System.Collections.Generic;
using MyFirstConsoleApp.Examples;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your full name...");
            var input = Console.ReadLine();

            var name = new Name
            {
                FullName = input,
                FirstName = "steve"
            };
            
            var anotherName = new Name
            {
                FullName = "bob",
                FirstName = "bobby"
            };

            //var differentKindsOfThings = new List<object>();

            //differentKindsOfThings.Add(anotherName);

            //differentKindsOfThings.Add(123);

            //var theRealNumber = (int) differentKindsOfThings[1];
            
            /*var pointer = originalPerson;

            //if (originalPerson == anotherOriginalPerson)
            //{
            //    Console.WriteLine("This will never happen");
            //}

            //if (originalPerson == pointer)
            //{
            //    originalPerson.Name = "Bob The Conqueror";
            //    Console.WriteLine("The things are the same");
            //}

            //anotherOriginalPerson = pointer;

            //if (originalPerson == anotherOriginalPerson && anotherOriginalPerson == pointer)
            //{
            //    Console.WriteLine("The things are all the same");
            //}

            //if (originalPerson.Name == anotherOriginalPerson.Name)
            //{

            }*/
            
            var originalPerson = new Person(input,17,200);
            
            var anotherOriginalPerson = new Person("Someone Else",17,200);

            originalPerson.Walk();

            var stuffToEat = new Food {Name = "Anchovie Pizza", Calories = 1100};

            originalPerson.Eat(stuffToEat);
            originalPerson.Eat("taco", 300);

            anotherOriginalPerson.Walk();

            Console.WriteLine(name.FullName);



            var myCar = new Car(5);

            myCar.Color = CarColor.Aqua;

            myCar.Start(originalPerson);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);


            var people = new List<Person>();
            people.Add(originalPerson);
            people.Add(anotherOriginalPerson);

            foreach (var person in people)
            {
                person.Eat("taco",300);
            }


            Console.ReadLine();


        }
    }
}
