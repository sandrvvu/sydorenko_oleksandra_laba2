using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_program2
{
   public class Examples
    {
        private  List<Toy> toys = new  List<Toy>();

        public List<Toy> init()
        {
            toys.Add(new Toy("Car", 250.6, Size.SMALL.ToString(), "Plastic", 3));
            toys.Add(new Toy("Car", 1500.9, Size.BIG.ToString(), "Aluminium", 16));
            toys.Add(new Toy("Car", 166.7, Size.MEDIUM.ToString(), "Wood", 3));
            toys.Add(new Toy("Rubik's cube", 25.5, Size.SMALL.ToString(), "Plastic", 8));
            toys.Add(new Toy("Alphabets cubs", 960.1, Size.STANDARD.ToString(), "Wood", 0));
            toys.Add(new Toy("Doll", 20.6, Size.SMALL.ToString(), "Rubber", 0));
            toys.Add(new Toy("Soccer Ball", 1250.6, Size.STANDARD.ToString(), "Leather", 10));
            toys.Add(new Toy("Cubs with pictures", 250.6, Size.SMALL.ToString(), "Wood", 0));
            toys.Add(new Toy("Cubs with dots", 550.4, Size.SMALL.ToString(), "Metal", 0));
            toys.Add(new Toy("Cubs with numbers", 230.6, Size.SMALL.ToString(), "Wood", 3));

            return toys;
        }
    }
}
