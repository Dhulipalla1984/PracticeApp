using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.OOPS
{
    /*Polymorpism */


    class Pig : Abstract
    {
        public override void makeSound()
        {
            Console.WriteLine("Pig sounds grunt");
        }

    }

    class Dog : Abstract
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog sounds bark");
        }
        public void sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }
    }
}
