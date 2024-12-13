using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.Collections
{
    internal class ArrayAndList
    {
        public void ArrayAndListMethod() {
            int[] array = new int[3];
            List<int> list = new List<int>();
            array[0] = 1;
            list.Add(1);
            Console.WriteLine("this is array value:" + array[0] + list[0]);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
            }

            object[] objectArray = new object[3];
            objectArray[0] = "this is array object";
            list.Add(2);
            Console.WriteLine(objectArray[0]);
           
        }
    }
}
