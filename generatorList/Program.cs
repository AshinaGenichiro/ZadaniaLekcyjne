using System.Reflection.Metadata;

namespace generatorList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe zdań (1-20):");
            string zdania = Console.ReadLine();
            if (int.TryParse(zdania, out int liczbaZdan))
            {
                if (liczbaZdan >= 1 && liczbaZdan <= 20)
                {
                    for (int i = 1; i <= liczbaZdan; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine($"Zdanie {i} - priorytet normalny");
                        }
                        else
                        {
                            Console.WriteLine($"Zdanie {i} - priorytet wysoki");

                        }
                    }
                }
            }
        }
    }
}