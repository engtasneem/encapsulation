using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Firstname = "Noor";
            p.Lastname = "Ali";
            p.Emaill = "should contain @ and end with .com";
            p.GetFullName();
            p.print();




        }
    }
}
