using System;

namespace lab2_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carr = Car.Get_Car();

            while (true)
            {
                Console.WriteLine("Оберiть дiю:\n " +
                    "0.вихiд\n" +
                    "1.поїхати\n" +
                    "2.заправити машину\n" +
                    "3.замiнити колесо\n" +
                    "4.дiзнатись марку авто:\n" 
                    );

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                    break;
                if (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Обран неправильний пункт , повторiть: ");
                    continue;
                }

                switch (choice)
                {
                    case 1: carr.Move(); break;
                    case 2: Console.WriteLine("Введiть скiльки лiтрiв бензину ви хочете заправити: ");
                           double fuel= Convert.ToDouble(Console.ReadLine());
                            carr.Add_fuel(fuel) ; 
                            break;
                    case 3: carr.Change_Wheel(); break;
                    case 4: Console.WriteLine(carr.ToString()); break;
                     
                }
            }
        }
    }
}
