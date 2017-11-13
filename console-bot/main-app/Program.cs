using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_app
{
    class Program
    {
        static string message;
        static void Main(string[] args)
        {
            while (true)
            {
                /*
                 * inne protipy:
                 * użyj daty: DateTime.Now;
                 * najlepiej przekaż stringa message do nowej klasy
                 * może wart zrobić wersję dwujęzyczną każdego modułu? Jak możemy to zrobić? ;)
                 */
                message = Console.ReadLine();
                message = message.ToLower();
                if (message.Contains("dziekanat") || message.Contains("dean"))
                {
                    //TODO: INFORMACJE O DZIEKANACIE
                    /*zapytaj jaki wydział i wyświetl:
                     * godziny otwarcia dzisiaj
                     * czy aktualnie jest otwarte
                     * ogólnie, kiedy dziekanat jest czynny
                     * jak znaleźć?
                     * dane kontaktowe (mail/tel) dziekanatu
                     * strona www dziekanatu
                     * dla WSZYSTKICH wydziałów
                    */
                }
                else if (message.Contains("godziny") ||
                    message.Contains("<tutaj wpsiz inne slowo kluczowe dla godzin dziekanskich>") ||
                    message.Contains("<i jeszcze inne słowo kluczowe>"))
                {
                    Console.WriteLine("poniedziałek, wtorek, piątek: 10:00 - 13:00");
                    Console.WriteLine("czwartek: 12:00 - 15:00:");
                    Console.WriteLine("środa: nieczynne");
                    Console.WriteLine("Okienko 1");
                    Console.WriteLine("poniedziałek, wtorek, piątek: 10:00 - 15:00     przerwa 13:15 - 13:45");
                    Console.WriteLine("czwartek: 11:00 - 16:00     przerwa 14:00 - 14:30");
                    Console.WriteLine("środa: nieczynne");
                }
                else if (message.Contains("event") || message.Contains("wydarz"))
                {
                    //Co tutaj się powinno znaleźć?
                }
                else if (message.Contains("map"))
                {
                    //TODO: LINKI DO MAP
                    /*
                     * Stworzyć klasę, która pomoże sprecyzować zapytanie a nastepnie wyświetlić spersonalizowany link do mapy
                     * https://pooler22.github.io/MapaPL/index.html
                     */
                }
                else if (message.Contains("<wyrazenie>") || message.Contains("<fragment wyrażenia>"))
                {
                    //Może jeszcze jakaś funkcjonalność? :P
                }
                else if (message == "exit") break; //koniec działania aplikacji
                else if (message == "co tu wpisać?") Info(); //TODO: Informacje o aplikacji

                else if (message.Contains("Jednostki")
                {
                    message.Contains("W1")
                    {
                        Console.WriteLine("Instytut Inżynierii Materiałowej" /n "Instytut Obrabiarek i Technologii Budowy Maszyn" /n "Instytut Maszyn Przepływowych" /n "Katedra Pojazdów i Podstaw Budowy Maszyn" /n "Katedra Wytrzymałości Materiałów i Konstrukcji" /n "Katedra Dynamiki Maszyn" /n "Katedra Automatyki, Biomechaniki i Mechatroniki" /n "Katedra Technologii Materiałowych i Systemów Produkcji")
                    }

                }

                else Help(); //TODO: wypisywanie komend

            }
        }

        private static void Info()
        {
            throw new NotImplementedException();
        }

        private static void Jednostki()
        {
            message.Contains("W1")
                    {
                Console.WriteLine("Instytut Inżynierii Materiałowej" / n "Instytut Obrabiarek i Technologii Budowy Maszyn" / n "Instytut Maszyn Przepływowych" / n "Katedra Pojazdów i Podstaw Budowy Maszyn" / n "Katedra Wytrzymałości Materiałów i Konstrukcji" / n "Katedra Dynamiki Maszyn" / n "Katedra Automatyki, Biomechaniki i Mechatroniki" / n "Katedra Technologii Materiałowych i Systemów Produkcji")
                    }
        }

        private static void Help()
        {
            Console.WriteLine("dziekanat/godziny/event/map/exit/co tu wpisać");
        }


    }

   
}