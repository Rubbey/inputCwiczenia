using System;

namespace inputCwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Aplikacja sprawdająca poprawność wpisanych danych.\n");
           
            float testowanaLiczba;
            bool test = false;

            // wersja pierwsza
            do
            {

                Console.Write("Podaj liczbę: ");

                try
                {
                  testowanaLiczba = float.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("To nie jest poprawna liczba!");
                    continue;
                }
                test = true;
                Console.WriteLine("\nTestowana liczba to {0} - to jest prawidłowa liczba!", testowanaLiczba);

            } while (test == !true);


            // wersja druga

             
            float testowanaLiczba2;
            
                Console.Write("\n\nTo jest druga wersja mechanizmu sprawdzania. ");

            while (true)
            {
                Console.Write("Podaj kolejną liczbę, tym razem musi być różna od 0: ");
                string wejscie = Console.ReadLine();
                float.TryParse(wejscie, out testowanaLiczba2);

                if (testowanaLiczba2 != 0)
                {
                    Console.WriteLine("\nPodana liczba to {0} i jest ona prawidłowa.", testowanaLiczba2);
                    break;
                }
                if (testowanaLiczba2 == 0)
                {
                    Console.WriteLine("\nPodana liczba to \"{0}\" i jest ona nieprawidowa!", wejscie);
                    continue;
                }
                


            }

            
        }
    }
        static public void Sprawdzenie()
    {

    }
}
