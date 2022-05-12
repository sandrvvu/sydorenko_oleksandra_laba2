using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_program2
{
    public abstract class MainMenu
    {
        public static void menu()
        {
            Console.WriteLine("1) Print all available toys;");
            Console.WriteLine("2) Print toys in the room;");
            Console.WriteLine("3) Find by age;");
            Console.WriteLine("4) Find by name;");
            Console.WriteLine("5) Sort toys by name;");
            Console.WriteLine("0) Exit");
            Console.WriteLine("Input one of the following keys> ");
        }
    }
}
