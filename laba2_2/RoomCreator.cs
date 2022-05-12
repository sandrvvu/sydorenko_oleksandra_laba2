using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_program2
{
    class RoomCreator
    { 
            private List<Toy> toys = new List<Toy>();

            public List<Toy> roomCreating()
            {
                List<Toy> available = new List<Toy>();
                Constants constants = new Constants();
                Examples examples = new Examples();

              List<Toy> toys = examples.init();
                int countOfToys = 0;
                double cash = 0;
                foreach (Toy toy in toys)
                {
                    if (countOfToys < constants.getAmountOfToys())
                    {
                        cash += toy.getPrice();
                        if (cash > constants.getMoney())
                        {
                            cash -= toy.getPrice();
                            continue;
                        }
                        countOfToys++;
                        available.Add(toy);
                    }
                    else
                    {
                        break;
                    }
                }
                return available;
            }
        }
    
}
