using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeApp.OOPS
{
    abstract class Abstract
    {
        public abstract void makeSound();

        public void sleep()
        {
            //Console.WriteLine("This is animal Sound");
        }
    }

    enum Level
    {
        Medium,
        Low,
        High
    }
}
