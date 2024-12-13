using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeApp;

namespace PracticeApp.Collections
{
    public class ArrayExamples
    {
        public void ArrayListExample() { 
        ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add(101);
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add("James"); //Adding Duplicate Value
            arrayList1.Add(" "); //Adding Empty
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            arrayList1.Add(null); //Adding null
            arrayList1.Insert(0, "Keerthi");
            ArrayList arrayList2 = new ArrayList()
            {
                "Srilanka",
                "India",
                "Zimbomve"
            };
            arrayList1.InsertRange(1, arrayList2);
            arrayList1.RemoveAt(2);
            arrayList2.Clear();
            Console.WriteLine("this is array2 count" + arrayList2.Count);
            foreach(var item in arrayList1)
            {
               Console.WriteLine(item);

            }

        }
    }
}
