using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_program2
{
    public class View
    {
        private MenuController menuController = new MenuController();
        public void init()
        {
            menuController.printMenu();
        }

        public void printElement(string str)
        {
            Console.WriteLine(str);
        }
    }
}
