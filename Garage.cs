using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AutoGarage
{
    [DataContract]
    internal class Garage
    {
        [DataMember]
        public string AutoName { get; set; }
        [DataMember]
        public string EngineType { get; set; }
        [DataMember]
        public double ValueEngine { get; set; }
        [DataMember]
        public int YearAuto { get; set; }
        
        public void InputAuto(string autoName,string engineType, double valueEngine, int yearAuto)
        {
            
            Console.Write("Введите марку и модель авто ");

            autoName = Console.ReadLine();
            AutoName = autoName;
           
           
            Console.Write("Введите тип двигателя ");
            engineType = Console.ReadLine();
            EngineType = engineType;
            Console.Write("Введите объем двигателя ");

             valueEngine = Convert.ToDouble(Console.ReadLine()) ;
            ValueEngine = valueEngine;


            Console.Write("Введите год авто ");
             yearAuto = Convert.ToInt32(Console.ReadLine());
            YearAuto = yearAuto;
            var json = new JsonEngine();
            json.goToJson();





        } 
     

        public void PrintGarageMenu()
        {
            var printGraphMenu = new Garage();
            Console.WriteLine("Ваш гараж");
            printGraphMenu.InputAuto(AutoName, EngineType, ValueEngine, YearAuto) ;
            
            
            
        }
    }
}
