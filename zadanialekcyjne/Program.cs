using System.Reflection.Metadata;

namespace Zadanialekcyjne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperaturaCelsjusz = 25;
            double Fahrenheith = Math.Round(temperaturaCelsjusz * 9 / 5 + 32, 2);
            Console.WriteLine($"Temperatura w fahrenheithach {Fahrenheith} \n");
            Console.WriteLine($"Temperatura w celsjuszach {(Math.Round((Fahrenheith - 32) * 5 / 9, 2))} \n");
            temperaturaCelsjusz = -12;
            Console.Write($"{temperaturaCelsjusz} \n");
            if (temperaturaCelsjusz < 0)
            {
                Console.WriteLine("Uwaga: temperatura jest poniżej zera!");
            }

        }
    }
}