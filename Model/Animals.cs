using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Model
{
    class Animals
    {

        //default no arguments constructor
        public Animals()
        {
        }

        //constructor with arguments
        public Animals(string breed, string habitat, double weight)
        {
            Breed = breed;
            Habitat = habitat;
            Weight = weight;
        }

        //getters and setters (encapsulation)
        private string breed;
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        private string habitat;
        public string Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //override the ToString method
        public override string ToString()
        {
            return "| Breed: " + Breed + " " + "| Natural habitat: " + Habitat + " " + "| Weight: " + Weight + "lbs";
        }

    }

    class Dog : Animals
    {
        public Dog()
        {

        }
        public Dog(string breed, string habitat, double weight) :
            base(breed, habitat, weight)
        {

        }

        public override string ToString()
        {
            return "Species: Dog " + base.ToString();
        }
    }

    class Cat : Animals
    {
        public Cat()
        {

        }
        public Cat(string breed, string habitat, double weight) :
            base(breed, habitat, weight)
        {

        }

        public override string ToString()
        {
            return "Species: Cat " + base.ToString();
        }

    }

    class Bird : Animals
    {
        public Bird()
        {

        }
        public Bird(string breed, string habitat, double weight) :
            base(breed, habitat, weight)
        {

        }

        public override string ToString()
        {
            return "Species: Bird " + base.ToString();
        }

    }
}
