using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_program2
{
    public class MenuController
    {
        public void printMenu()
        {
            MainController mainController = new MainController();

            while (true) {
                MainMenu.menu();
                int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 0)
                break;
            if (choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid input \n Try again");
                continue;
            }
             
            switch (choice)
                { 
                    case 1:
                        mainController.printAllAvailable();
                        break;
                    case 2 :
                        mainController.printAll();
                        break;
                    case 3:
                        mainController.findByAge();
                        break;
                    case 4:
                        mainController.findByName();
                        break;
                    case 5:
                        mainController.sortByName();
                        break;
                    
                }
            }
        }
    }
}
