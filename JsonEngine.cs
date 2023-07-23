using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace AutoGarage
{
    internal class JsonEngine
    {
        public void goToJson()// метод для ввода данных и вывода в json файл
        {
            var garage = new Garage();
            var folderFile = "History.json";
            var jsonserilizer = JsonSerializer.Serialize(garage) ;
            File.WriteAllText(folderFile, jsonserilizer);

        }
    }
}
