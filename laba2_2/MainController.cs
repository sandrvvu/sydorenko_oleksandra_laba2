using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace lab2_program2
{
    public class MainController
    {
        private View view = new View();
        private RoomCreator roomCreator = new RoomCreator();
        private  List<Toy> toys = new  List<Toy>();
        public void go()
        {
            Constants constants = new Constants();
            Console.WriteLine("Amount of toys: " + constants.getAmountOfToys());
            Console.WriteLine("Money: " + constants.getMoney());
        }

        private void init()
        {
            toys = roomCreator.roomCreating();
        }


        public void printAllAvailable()
        {
            Examples examples = new Examples();
             List<Toy> toyExp;
            toyExp = examples.init();
            double count = 0.0;
            foreach (Toy toy in toyExp)
            {
                view.printElement(toy.ToString());
                count += toy.getPrice();
            }
            Console.WriteLine("Count: " + Math.Round(count) + '\n');
        }

        public void printAll()
        {
            double count = 0;
            init();
            foreach (Toy toy in toys)
            {
                view.printElement(toy.ToString());
                count += toy.getPrice();
            }
            Console.WriteLine("Count: " + count + '\n');
        }

        public void sortByName()
        {
            init();
            toys=toys.OrderBy(x => x.getName()).ToList();

            foreach (Toy toy in toys)
            {
                view.printElement(toy.ToString());
            }
        }

        public void findByName()  
        {
            init();
            Console.WriteLine("Input name: ");
            string n = Console.ReadLine();
             
            foreach (Toy toy in toys)
            {
                if (n ==(toy.getName()))
                {
                    view.printElement(toy.ToString());
                }
            }

        }

        public void findByAge()
        {
            init();
            int elAge = 0;
            string str = null;
            do
            {
                Console.WriteLine("Input age: ");
                
                    str = Console.ReadLine();
                    elAge = Convert.ToInt32(str);
                    if (elAge < 0) Console.WriteLine("wrong");
                 
                 
            } while (elAge < 0);

            foreach (Toy toy in toys)
            {
                if (elAge == toy.getAge())
                {
                    view.printElement(toy.ToString());
                }
            }
        }
    }
}
