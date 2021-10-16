using System;
using UI;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window();
            while (true)
            {
                Console.WriteLine("Enter 1 to change Navbar Header");
                var read = Console.ReadLine();
                if (read == "1")
                {
                    window.Navbar.Header = "TEST";
                }
            }
        }
    }
}