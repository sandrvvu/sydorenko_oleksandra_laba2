using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_program
{
    public class Car  
    { 
        private Motor motor;
        private Wheel[] wheels=new Wheel[4];
        private string brand; 
        private double fuel_level;
        public Car(string brand, double fuel_level, Wheel[] wheels, Motor motor)
        {
            this.brand = brand;
            this.fuel_level = fuel_level;
            this.wheels = wheels;
            this.motor = motor;
        }
        public static Car Get_Car()
        {
            Car obj = new Car("", 0, new Wheel[4], new Motor("", 0, 0));
            Console.WriteLine("Введiть марку автомобiля:");
            obj.brand = Console.ReadLine();
            Console.WriteLine("Введiть рiвень топлива автомобiля:");
            obj.fuel_level = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введiть iнформацiю про колеса автомобiля:");
           for (int i = 0; i < 4; ++i) {
                Console.WriteLine("колесо #" + i);
                obj.wheels[i] = Wheel.Get_Wheel(); }

            Console.WriteLine("Введiть iнформацiю про мотор автомобiля:");
            obj.motor = Motor.Get_Motor();
            return obj;
        }
        public void Move()
        {
            if (fuel_level <= 0)
            {
                Console.WriteLine("Машина не може рухатися - вона незаправлена");
                return;
            }
            for (int i = 1; i < 4; ++i)
            {
                if (wheels[i].Get_Diameter() != wheels[i - 1].Get_Diameter() && wheels[i].Get_Type() != wheels[i - 1].Get_Type())
                {
                    Console.WriteLine("Машина не може рухатися- колеса рiзнi ");
                    return;
                }
            }
            double distance = fuel_level / motor.Get_Consumption();
            Console.WriteLine("машина проїхала " + distance * 100 + "км.");
            fuel_level = 0;
        }


        public void Add_fuel(double value)
        {
            fuel_level += value;
            Console.WriteLine($"Машина заправлена на {value} лiтрiв топлива ");
        }

        
        public override string ToString()
        {
            return ($"Марка машини:{brand}");
        }

       
        public void Change_Wheel()
        {
            Console.WriteLine("Введiть номер колеса [0-3] , яке треба змiнити:");
            int number;
            while (true)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0 && number <= 3)
                    break;
                Console.WriteLine("неправильний номер");

            }

            wheels[number] = Wheel.Get_Wheel();
        }
    }
}
