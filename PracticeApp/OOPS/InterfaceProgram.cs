using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.OOPS
{
    /* Interface */

    interface IAnimal
    {
        void animalSound();
        void animalBreed();
    }

    class Pig1 : IAnimal
    {

        public void animalSound()
        {
            Console.WriteLine("this is pig sounds grunt");
        }
        public void animalBreed()
        {
        }
    }
    class Pig2 : IAnimal
    {
        public void animalBreed()
        {
            Console.WriteLine("this is foreign pig");
        }
        public void animalSound()
        {
            Console.WriteLine("this is wee");
        }
    }
}
