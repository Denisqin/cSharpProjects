using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region BINGO BONGO JIMBO JAMBO
            Console.ForegroundColor = ConsoleColor.Green;
            //#endregion
            //#region Условные конструкции
            //if (DateTime.Now.Hour < 18)
            //{
            //    Console.WriteLine("Добрый вечер, время:" + DateTime.Now);
            //}
            //else
            //{
            //    Console.WriteLine("Время позднее, пора идти ехай!");
            //}
            //Console.ReadLine();
            //#endregion
            //#region switch
            //switch (DateTime.Now.Hour)
            //{
            //    case 21: Console.WriteLine("it's coding time after 21 o'clock"); break;
            //    case 23: Console.WriteLine("sleeping time for relaxation and continuation coding"); break;
            //}
            //Console.ReadLine();
            //#endregion
            //#region cycles
            //While
            //while (DateTime.Now.Minute < 11)
            //{
            //    Console.WriteLine(DateTime.Now);
            //}
            //Console.ReadLine();
            //for
            //for (string i = "w"; i.Length <= 4; i = i + "w")
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            //#endregion
            //#region Arrays
            //Type collections
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскрессенье" };
            List<string> str_list = new List<string>();
            Console.WriteLine(days[0]);
            for (int i = 0; i < days.Count(); i++)
                {
                Console.WriteLine(days[i]);

                }
            Console.ReadLine();
            //#endregion
        }
    }
}
