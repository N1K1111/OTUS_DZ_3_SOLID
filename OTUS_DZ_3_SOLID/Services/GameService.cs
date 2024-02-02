using OTUS_DZ_3_SOLID.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ_3_SOLID.Services
{
    internal class GameService : IGameService
    {
        public void Execute(Settings set, int generatedNumber)
        {
            int num;

            for (int i = 0; i < set.CountAttempts; i++)
            {
                Console.Write("Введите угадываемое число: ");
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверно. Введите число!");
                    continue;
                }

                if (num > generatedNumber)
                    Console.WriteLine("Введенное вами число больше загаданнго. Попробуйте еще раз.");
                else if (num < generatedNumber)
                    Console.WriteLine("Введенное вами число меньше загаданнго. Попробуйте еще раз.");
                else
                {
                    Console.WriteLine("Поздравляю! Вы Угадали!");
                    break;
                }
            }
            Console.WriteLine("Попытки Закончились!");
        }
    }
}
