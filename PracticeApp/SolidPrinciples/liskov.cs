using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PracticeApp.SolidPrinciples
{

    public interface IFruit
    {
        string GetColor();


    }
    public class Apple : IFruit
    {
        public string GetColor()
        {
            return "Red";
        }
    }

    public class Orange : IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }
}
