using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    public class Person
    {
        public string name;
        public int age;
        public string eyeColor;
        public float beardLength;
        public Person(string Name, int Age, string EyeColor = "brown", float BeardLength = 0)
        {
            name = Name;
            age = Age;
            eyeColor = EyeColor;
            beardLength = BeardLength;
        }

        public void PrintPerson()
        { 
            Console.WriteLine("My name is " + name + ".");
            Console.WriteLine("I am " + age + " years old.");
            Console.WriteLine("I have " + eyeColor + " eyes.");
            if (beardLength == 0)
            {
                Console.WriteLine("I do not have a beard.");
            }
            else
            {
                Console.WriteLine("My beard is " + beardLength + " inch(es) long.");
            }
            
        }
    }
}
