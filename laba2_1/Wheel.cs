using System;
using System.Collections.Generic;
using System.Text;
 
namespace lab2_program
{
    
    public class Wheel  
    {
        private string trademark_name;
        private double diameter;

        public enum Type
        {
            Winter,
            Summer
        }
        private Type type;

        public Wheel(string trademark_name, double diameter, Type type)
        {
            this.trademark_name = trademark_name;
            this.diameter = diameter;
            this.type = type;

        }

        public  string Inf_Wheel()
        {
            string inf_wheel="";
            inf_wheel += trademark_name + " " + diameter + " ";
            if (type == Type.Summer) {
                inf_wheel += "Summer";
            }
            else
            {
                inf_wheel += "Winter";
            }
            return inf_wheel;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(trademark_name, diameter,type);
        }
        public double Get_Diameter()
        {
            return diameter;
        }

        public Type Get_Type()
        {
            return type;
        }

        public static Wheel Get_Wheel()
        {
            Wheel obj = new Wheel("", 0, Type.Winter);
            Console.WriteLine("Введiть назву марки колеса: ");
            obj.trademark_name = Console.ReadLine();
            Console.WriteLine("Введiть дiаметр: ");
            obj.diameter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть тип колес (1)-зимнi , (2)-лiтнi : ");
            while (true)
            {
                int value= Convert.ToInt32(Console.ReadLine());
                if (value == 1)
                {
                    obj.type = Type.Winter;
                    break;
                }
                if (value == 2)
                {
                    obj.type = Type.Summer;
                    break;
                }
                Console.WriteLine("неправильне значення");
            }
            return obj;
        }

       
    }
}
