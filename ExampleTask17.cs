using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napilnik1
{
    class ExampleTask17
    {
        public static void GenerateNewObject()
        {
            //Создание объекта на карте
        }

        public static void DefineChance()
        {
            _chance = Random.Range(0, 100);
        }

        public static int PaySalary(int hoursWorked)
        {
            return _hourlyRate * hoursWorked;
        }
    }
}
