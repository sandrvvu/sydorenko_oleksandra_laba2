using System;

namespace lab2_program2
{
    class Program
    {
        static void Main(string[] args)
        {
            new MainController().go();
            new View().init();
        }
    }
}
