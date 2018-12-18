using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
         string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Jeudi", "Samedi", "Dimanche" };
         for (int i = 0; i < jours.Length; i++)
         Console.WriteLine(jours[i]);
         Console.ReadKey();
         jours[4] = "Vendredi";
         for (int i = 0; i < jours.Length; i++)
         Console.WriteLine(jours[i]);
         Console.ReadKey();
        }
    }
}
