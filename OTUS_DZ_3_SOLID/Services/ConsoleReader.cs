using OTUS_DZ_3_SOLID.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ_3_SOLID.Services
{
    internal class ConsoleReader : IReader
    {
        public string?[] Read()
        {
            Console.WriteLine("Введите колличество Попыток");
            string? count = Console.ReadLine();
            Console.WriteLine("Введите минимальное число");
            string? minNumber = Console.ReadLine();
            Console.WriteLine("Введите максимальное число");
            string? maxNumber = Console.ReadLine();
            return new string?[] { count, minNumber, maxNumber };
        }
    }
}
