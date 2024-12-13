using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.OOPS
{
    public class OverLoading
    {
        public int Add(int a, int b)
        {
            int Output = a + b;
            return Output;
        }

        public double Add(double a, double b, double c)
        {
            double Output = a + b + c;
            return Output;
        }
    }
}
