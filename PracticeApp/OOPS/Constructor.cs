using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.OOPS
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Base Constructor Called");
        }
        public virtual void Method()
        {
            Console.WriteLine("Base method");
        }
    }

    #region dervied class
    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived Constructor Called");

        }
        public override void Method()
        {
            Console.WriteLine("Derived method");
        }
    }
    #endregion

    #region derived2 class
    class Derived2 : Derived
    {
        public Derived2()
        {
            Console.WriteLine("Derived2 Constructor Called");

        }
        public void Method()
        {
            Console.WriteLine("Derived2 method");
        }
    }
    #endregion

}
