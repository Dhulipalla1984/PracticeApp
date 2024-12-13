using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    public partial class  Partial
    {
        private string AuthorName;
        private int AuthorAge;
        public Partial(string a,  int b) { 
        this.AuthorName = a;
            this.AuthorAge = b;
        }
    }
}
