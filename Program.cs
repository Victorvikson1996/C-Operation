// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = 23;
            age++;
            age += 10;
            age -= 10;
            string name = "ABA";
            name += " is programm";

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            Console.WriteLine(name);
            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(age);
            age /= 10;
            Console.WriteLine(age);
            Console.ReadLine();

        }
    }
}

