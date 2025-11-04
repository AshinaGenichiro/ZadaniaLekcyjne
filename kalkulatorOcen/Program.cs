using System.Reflection.Metadata;

namespace kalkulatorOcen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź ocenę: ");
            string ocena = Console.ReadLine();
            int ocenaLiczba = int.Parse(ocena);
            string opis = "";
            if (ocenaLiczba >= 1 && ocenaLiczba <= 6)
            {
                switch(ocenaLiczba)
                {
                    case 1:
                        opis = "Niedostateczny";
                    break;
                    case 2:
                        opis = "Dopuszczający";
                    break;
                    case 3:
                        opis = "Dostateczny";
                    break;
                    case 4:
                        opis = "Dobry";
                    break;
                    case 5:
                        opis = "Bardzo dobry";
                    break;
                    case 6:
                        opis = "Celujący";
                    break;
                }
                Console.WriteLine($"Twoja ocena to: {opis} ");
            }
            else
            {
                Console.WriteLine("Wprowadź poprawne dane");
            }
            
        }
    }
}