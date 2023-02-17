using System;

namespace HelloWorld
{
    class Program{
        static void Main(string[] args)
        {
            Consle.WriteLine("Hello World!");
            Consle.WriteLine("What is your name?");
            string str = Consle.ReadLine();
             Consle.WriteLine("Why, hello there " + str);
        }
    }
}