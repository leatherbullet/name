using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace имя
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userSimbol;
            string simbols = "";

            Console.WriteLine("введите имя:");
            userName = Console.ReadLine();
            Console.WriteLine("введите символ:");
            userSimbol = Console.ReadLine();

            for (int i = 0 ; i <= userName.Length + 1 ; i++)
            {
                simbols += userSimbol;
            }

            Console.Clear();
            Console.WriteLine(simbols);
            Console.WriteLine(userSimbol + userName + userSimbol);
            Console.WriteLine(simbols);
        }
    }
}
