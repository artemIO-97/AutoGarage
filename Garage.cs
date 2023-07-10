using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarage
{
    internal class Garage:StartMenu
    {
       
        public string AutoName { get; set; }
        public string EngineType { get; set; }
        public double ValueEngine { get; set; }
        public int YearAuto { get; set; }
        public string InputAuto()
        {
            var printGraphMenu = new Garage().PrintGraphMenu;
            Console.Write("Введите марку и модель авто ");
            AutoName = Console.ReadLine();
            printGraphMenu();
            Console.Write("Введите тип двигателя ");
            EngineType = Console.ReadLine();
            printGraphMenu();
            Console.Write("Введите объем двигателя ");
            ValueEngine = Convert.ToDouble(Console.ReadLine()) ;
            printGraphMenu();
            Console.Write("Введите год авто ");
            YearAuto = Convert.ToInt32(Console.ReadLine());
            printGraphMenu();
            return $"{AutoName},{EngineType},{ValueEngine},{YearAuto}"; // Заготовка для вывода в xml (пока не придумал как)
        } // метод для ввода данных и вывода в xml файл
        public void PrintGarageMenu()
        {
            var printGraphMenu = new Garage().PrintGraphMenu;
            Console.WriteLine("Ваш гараж");
            printGraphMenu();
            var garage = new Garage();
            garage.InputAuto();
            
        }
    }
}
