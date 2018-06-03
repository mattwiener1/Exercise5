using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5- Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console.
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Please enter a few numbers seperated by a comma for us to determine the largest of: ");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            string[] seperate = input.Split(Convert.ToChar(","));


            var max = 0;
            for (var i = 0; i < seperate.Length; i++)
            {
                var num = Convert.ToInt32(seperate[i]);
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine("The biggest number you entered is " + max );
        }
    }
}
