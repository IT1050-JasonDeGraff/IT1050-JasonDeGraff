using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * a. The main method
             * b. An integer is a whole number and a double precision floating variable can go to 16 decimal places
             * c. GetName Method - Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
             * d. get, set
             * e. A class or classes are what an object is made up of. There can only be one instance of a class because it's part of what creates an object.  
             */

            // declare a
            int a;
            int b;
            int sum;

            // assign a value
            a = 45;
            b = 72;

            //arithmetic operators: + - * / %
            sum = a * b;

            Console.WriteLine(sum);
            Console.Write("\nHello World!\tFrom Jason DeGraff");
    
        }
    }
}
