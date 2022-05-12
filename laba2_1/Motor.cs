using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_program
{
   public class Motor  
    {
        private string name;
        private double power;
        private double consumption;

        public Motor(string name, double power, double consumption)
        {
            this.name = name;
            this.power = power;
            this.consumption = consumption;
        }

        public string Inf_Motor()
        {
            return $"Номер двигуна:{name} , потужнiсть:{power} , розхiд топлива: {consumption}";
        }

        public override int GetHashCode()
        {
            return  HashCode.Combine(name, power,consumption);
        }

        public double Get_Consumption()
        {
            return consumption;
        }

        public static Motor Get_Motor()
        {
            Motor obj = new Motor("", 0, 0);
            Console.WriteLine("Введiть назву двигуна: ");
            obj.name = Console.ReadLine();  
            Console.WriteLine("Введiть потужнiсть двигуна: ");
            obj.power = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть розхiд топлива: ");
            obj.consumption= Convert.ToDouble(Console.ReadLine());
            return obj;
        }
    }
 }

