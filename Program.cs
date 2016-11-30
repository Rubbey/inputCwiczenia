using System;

namespace inputCwiczenia
{
    class Program
    {
        //komentarz testowy
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Aplikacja sprawdająca poprawność wpisanych danych.\n");
           
            float testNumber;
            bool test = false;

            // wersja pierwsza
            do
            {

                Console.Write("Podaj liczbę: ");

                try
                {
                  testNumber = float.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("To nie jest poprawna liczba!");
                    continue;
                }
                test = true;
                Console.WriteLine("\nTestowana liczba to {0} - to jest prawidłowa liczba!", testNumber);

            } while (test == !true);


            // wersja druga

             
            float testNumber2;
            
                Console.Write("\n\nTo jest druga wersja mechanizmu sprawdzania. ");

            while (true)
            {
                Console.Write("Podaj kolejną liczbę, tym razem musi być różna od 0: ");
                string wejscie = Console.ReadLine();
                float.TryParse(wejscie, out testNumber2);

                if (testNumber2 != 0)
                {
                    Console.WriteLine("\nPodana liczba to {0} i jest ona prawidłowa.", testowanaLiczba2);
                    break;
                }
                if (testNumber2 == 0)
                {
                    Console.WriteLine("\nPodana wartość to \"{0}\" i jest ona nieprawidowa!", wejscie);
                    continue;
                }
                


            }

            
        }
    }
        static public void Sprawdzenie()
    {

    }
}
