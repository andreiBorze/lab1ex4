using System;

namespace lab1ex4
{
    /*Scrieti un program care va afisa semnul unui numar citit de la tastatura
    • Daca numarul este pozitiv, va afisa “+”
    • Daca numarul este negativ, va afisa “-”
    • Daca numarul este 0, va afisa “0”*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va afisa semnul unui numar citit de la tastatura. \n");

            Console.WriteLine("Introduceti numarul:");
            var nr = int.Parse(Console.ReadLine());


            if (nr == 0)
                Console.WriteLine("0");
            else if(nr > 0)
                Console.WriteLine("+");
            else
                Console.WriteLine("-");
        }
    }
}
