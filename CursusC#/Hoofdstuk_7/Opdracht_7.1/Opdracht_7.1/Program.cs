using System;

namespace Opdracht_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie array
            int[] arrayGetal = new int[3];
            int som;

            //Opvragen 3 getallen
            Console.Write("Voer een getal in: ");
            arrayGetal[0] = int.Parse(Console.ReadLine());

            Console.Write("Voer een tweede getal in: ");
            arrayGetal[1] = int.Parse(Console.ReadLine());

            Console.Write("Voer een laatste getal in: ");
            arrayGetal[2] = int.Parse(Console.ReadLine());

            //De som berekenen
            som = arrayGetal[0] + arrayGetal[1] + arrayGetal[2];

            //Weergave console
            Console.WriteLine();
            Console.WriteLine("De som van de 3 getallen = " + som.ToString());
            


            /*
            int intSom, intTeller;
            int[] arraySom = new int[3];
            intSom = arraySom[0];

            for (intTeller = 0; intTeller < 3; intTeller++)
            {
                Console.Write("Geef getal " + (intTeller + 1).ToString() + ": ");
                arraySom[intTeller] = int.Parse(Console.ReadLine());

                intSom += arraySom[intTeller];
            }
            Console.WriteLine("som = " + intSom.ToString());
            Console.ReadLine();
            */
        }
    }
}
