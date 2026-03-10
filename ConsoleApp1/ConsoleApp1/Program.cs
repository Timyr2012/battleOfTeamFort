using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        Random rand = new Random();
        static void Main(string[] args)
        {
            var rand = new Random();
            Console.WriteLine("Введіть своє ім'я чаклуне");
            string name = Console.ReadLine();
            Console.WriteLine($"Введіть свій рівень магії {name}");
            double forceOfMagic = int.Parse(Console.ReadLine());
            if (forceOfMagic < 1)
            {
                forceOfMagic = 1;
            }

            else if (forceOfMagic > 10)
            {
                forceOfMagic = 10;
            }
            double forceOfCristal = rand.Next(1, 100);
            double rampedUpPower = Math.Pow(forceOfMagic, 2);
            double finalspellpower = Math.Round(rampedUpPower + forceOfCristal / 2);
            Console.WriteLine($"Вітаю {name}!");
            Console.WriteLine($"Твій рівень магії {forceOfMagic}");
            Console.WriteLine($"Сила кристала твого {forceOfCristal}");
            Console.WriteLine($"Фінальний посилений магічний удар має силу в {finalspellpower} одиниць шкоди");


        }
    }
}
