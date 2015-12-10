using OOP_Project.Model;
using System;
using System.Collections.Generic;

namespace OOP_Project
{
    class Project
    {
        static void Main(string[] args)
        {
            //create a list to store the animal objects
            var animals = new List<Animals>();

            animals.Add(new Dog("Boxer", "My house", 55.2));
            animals.Add(new Dog("Yorkie", "My house", 16.7));
            animals.Add(new Cat("Calico", "Cat tower", 22.0));
            animals.Add(new Bird("Cockatiel", "Bird cage", 0.7));

            Console.WriteLine("There are " + animals.Count + " animals in this list");

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

        }

    }

}
