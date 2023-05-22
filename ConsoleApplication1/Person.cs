using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Emaill { get; set; }
        public string FullName;
       public void  GetFullName()
        {
            FullName = Firstname + " " + Lastname;
            
        }
        public void print()
        {
            Console.WriteLine("The FullName is: "+ FullName);
            Console.WriteLine("The Emaill is :"+Emaill);
            
        }


    }
}
