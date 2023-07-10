using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarage
{
    internal class StartMenu
    {
        public int InpytStartMenu { get; set; }
        public bool InputStartHistory = false;
        public bool InputStartMenuGarage = false;
        public bool returnBool = false;


        public bool GoToNextScreen(int inpytStartMenu)
        {

            if (InpytStartMenu == (int)InputStartMenu.Garage)
            {
               InputStartMenuGarage = true;
                Console.Clear();
                var garage = new Garage();
                garage.PrintGarageMenu();             // тут запихиваем логику перехода на другой экран (гараж)
            }
            if (InpytStartMenu == (int)InputStartMenu.History)
            {
                InputStartHistory = true;
                Console.WriteLine("Жди  свою историю, я не знаю когда она будет допилена");// тут запихиваем логику перехода на другой экран (история)
            }
        bool returnBool =  (InputStartHistory || InputStartMenuGarage);
            if (!returnBool)
            {
            Console.Write("Проверь ввод  и повтори его");
                
            }
            return returnBool;

        } 
        public void PrintStartMenu()
        {
            var printGraphMenu = new StartMenu().PrintGraphMenu;
            printGraphMenu();
            Console.WriteLine(" 1 - Зайти в гараж");
            printGraphMenu();
            Console.WriteLine(" 2 - Показать историю");
            printGraphMenu();



        }
        protected void PrintGraphMenu()
        {
            for (int i = 0; ; i++)
            {
                Console.Write("=");
                if (i == 30)
                {
                    Console.Write("\n");
                    break;
                }
            }

        } // вынесу данный метод в отдельный класс, где добавлю еще пару методов по отрисовке
    }
    
    public enum InputStartMenu
    {
        Garage = 1,
        History = 2,
        
    }
}
