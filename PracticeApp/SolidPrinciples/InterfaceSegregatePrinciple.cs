using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    interface InterfaceSegregatePrinciple
    {
        void PrintContent(string content);
        void PrintFooter(string footer);
        void PrintHeader(string header);

    }

    class PrintContents : InterfaceSegregatePrinciple
    {
        public void PrintContent(string content)
        {
            try
            {
                Console.WriteLine(content);
            }
            catch
            {

                throw new NotImplementedException();
            }
        }

        public void PrintFooter(string footer)
        {
            try
            {
                Console.WriteLine("this is print footer");
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public void PrintHeader(string header)
        {
            try
            {
                Console.WriteLine("this is print header");
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }
    }
}
