using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_program2
{
    public class Toy
    {
        private string name;
        private double price;
        private string size;
        private string material;
        private int age;

        public Toy(string name, double price, string size, string material, int age)
        {
            this.name = name;
            this.price = price;
            this.size = size;
            this.material = material;
            this.age = age;
        }

        public string getSize()
        {
            return size;
        }

        public void setSize(string size)
        {
            this.size = size;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public string getMaterial()
        {
            return material;
        }

        public void setMaterial(string material)
        {
            this.material = material;
        }

        public override string ToString()
        {
            string inf = " ";
            inf += "\n Name: " + name + "\n Price: " + price + "\n Size: " + size
                + "\n Material: " + material + "\n Age: " + age;

            return inf.ToString();
        }
    }
}
