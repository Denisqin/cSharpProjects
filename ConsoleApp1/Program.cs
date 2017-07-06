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
            //Console.ForegroundColor = ConsoleColor.Green;
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
            switch(DateTime.Now.Hour)
            {
                case 21: Console.WriteLine("it's coding time after 21 o'clock"); break;
                case 23: Console.WriteLine("sleeping time for relaxation and continuation coding"); break;
            }
            Console.ReadLine();
        }
    }
}
