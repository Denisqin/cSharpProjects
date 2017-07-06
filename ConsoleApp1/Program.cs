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
            #region Условные конструкции
            if (DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Добрый вечер, время:" + DateTime.Now);
            }
            else
            {
                Console.WriteLine("Время позднее, пора идти ехай");
            }
            Console.ReadLine();
            #endregion
        }
    }
}
