using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden("Запорожан Илья", "Староватутенский проезд");
            
            garden.Flowers.Add(new Flower($"Роза", "Вася"));
            garden.Flowers.Add(new Flower($"Пионы", "Петя"));
            garden.Flowers.Add(new Flower($"Бегония", "Вадим"));
            garden.Flowers.Add(new Flower($"Колеус", "Вадим"));

            garden.ShowAll();

            Console.ReadKey();
        }
    }
}
