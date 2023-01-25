using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rect c1 = new rect(5,6);
            c1.CalArea();
            Console.WriteLine(c1);


            /*
             
            Abstract class:

            Abstract means which does not have implementation
            If a class contains at least one abstract method, we need to declare an abstract keyword to the class. Class also becomes as an abstract class
            When any child class inherits the abstract class , must provide the definition for an abstract method
            All the abstract methods are by default virtual
            We can not create object of an abstract class
            */

        }
    }
}
