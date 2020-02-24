using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal            // 1.1 เพิ่ม class ชื่อ  Animal
    {
        public void Eat()   // 1.2 เพิ่มเมธอด Eat()
        {
            Console.WriteLine("eating...");
        }
    }

    class Cat : Animal      // 2.1 เพิ่ม class ชื่อ  Animal
    {
        public void Meow()  // 2.2 เพิ่มเมธอด Eat()
        {
            Console.WriteLine("meowing...");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");    
        }
    }

    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("weeping...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Eat();

        }
    }
}
