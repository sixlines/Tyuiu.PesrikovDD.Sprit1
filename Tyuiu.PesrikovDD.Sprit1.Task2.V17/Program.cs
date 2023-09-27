using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PesrikovDD.Sprit1.Task2.V17.Lib;

namespace Tyuiu.PesrikovDD.Sprit1.Task2.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                             *");
            Console.WriteLine("* Задание #2                                                                 *");
            Console.WriteLine("* Вариант #17                                                                *");
            Console.WriteLine("* Выполнил: Пестриков Данила Дмитриевич | ИИПБ-23-1                          *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,    *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int x;

            Console.WriteLine("Время в минутах (целое число)");
            x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Время в часах: " + ds.ConvertMinutesToHours(x));
            Console.ReadLine();
        }
    }
}