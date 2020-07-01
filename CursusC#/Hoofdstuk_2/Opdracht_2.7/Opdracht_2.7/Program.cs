using System;

namespace Opdracht_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double varY, varA, varB, varC;

            //Het getal opvragen
            Console.Write("Getal a = ");
            varA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Getal b = ");
            varB = Convert.ToInt16(Console.ReadLine());

            Console.Write("Getal c = ");
            varC = Convert.ToInt16(Console.ReadLine());

            //De som berekenen
            varY = varA * (varB / varC);

            //Het resultaat weergeven in de console
            Console.WriteLine("De uitkomst = " + varY.ToString());
            Console.ReadLine();
        }
    }
}
