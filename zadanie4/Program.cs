using System.Reflection.Metadata;

namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imie = "Anna";
            string naziwsko = "Kowalska";
            string wiek = "28";
            string email = "anna.kowalska@example.com";
            string numerTelefonu = "123456789";
            bool wiekOk = false;
            bool emailOk = false;
            bool telefonOk = false;
            bool imieOk = false;
            bool naziwskoOk = false;

            if (int.TryParse(wiek, out int wiekNumer))
            {
                if (wiekNumer >= 18 && wiekNumer <= 100)
                {
                    wiekOk = true;
                    Console.WriteLine("[Pole] ✓ OK");
                }
                else
                {
                    Console.WriteLine("[Pole] ✗ Błąd: Zły wiek (musi być miedzy 18 a 100");
                }
            }

            else
            {
                Console.WriteLine("[Pole] ✗ Błąd: Zły wiek, musi byc liczbą");
            }

            if (email.Contains('@'))
            {
                emailOk = true;
                Console.WriteLine("[Pole] ✓ OK");
            }
            else
            {
                Console.WriteLine("[Pole] X Błąd: email powinnien zawierac @");
            }

            if (numerTelefonu.Length == 9)
            {
                telefonOk = true;
                Console.WriteLine("[Pole] ✓ OK");
            }
            else
            {
                Console.WriteLine("[Pole] X Błąd: Numer telefonu powinnien zawierać 9 ");
            }

            if (!string.IsNullOrEmpty(imie))
            {
                imieOk = true;
                Console.WriteLine("[Pole] ✓ OK");
            }
            else
            {
                Console.WriteLine("[Pole] x imie nie moze byc puste");
            }

            if (!string.IsNullOrEmpty(naziwsko))
            {
                naziwskoOk = true;
                Console.WriteLine("[Pole] ✓ OK");
            }
            else
            {
                Console.WriteLine("[Pole] x naziwsko nie moze byc puste");
            }
            if (naziwskoOk && imieOk && telefonOk && emailOk && wiekOk)
            {
                Console.WriteLine("Wszystko jest poprawne");
            }
            else
            {
                Console.WriteLine("Popraw dane");
            }

        }
    }
}