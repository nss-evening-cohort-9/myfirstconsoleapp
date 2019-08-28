using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp.Examples
{
    class Person
    {
        //string _name;

        //public string Name
        //{
        //    get { return $"{_name} is not as cool as steve"; }
        //    set { _name = value; }
        //}

        public string Name { get; }

        public int Age { get; }
        
        readonly int _speed;
        List<string> _foodInMyBelly = new List<string>();
        int _caloricIntake;
        const int MaxWalkingSpeed = 10;
        

        public Person(string name, int age, int speed)
        {
            Name = name;
            Age = age;
            _speed = speed;
        }

        public void Walk()
        {
            if (_speed <= MaxWalkingSpeed)
            {
                Console.WriteLine($"{Name} is walking at {_speed} feet per second.");
            }
            else
            {
                Console.WriteLine("Slow down you hooligan!!!");
            }
        }

        public void Eat(string name, int calories)
        {
            if (_caloricIntake > 2500)
            {
                Console.WriteLine("You many not eat more food.");
                return;
            }

            _foodInMyBelly.Add(name);
            _caloricIntake += calories;
        }

        public void Eat(Food stuffToEat)
        {
            Eat(stuffToEat.Name, stuffToEat.Calories);
        }
    }

    
}
