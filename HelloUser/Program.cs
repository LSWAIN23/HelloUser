using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a console program that takes a string (user's name) as input then prints "Hello" followed by the string

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(UserName(name));
        }

        static public string UserName(string name)
        {
            Console.Write($"Hello ");
            return name;
        }
    }
}
