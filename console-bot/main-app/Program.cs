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
            message = Console.ReadLine();
            message = message.ToLower();
            if(message.Contains("dziekanat") || message.Contains("dean"))
            {
                /*zapytaj jaki wydział i wyświetl:
                 *godziny otwarcia dzisiaj
                 *czy aktualnie jest otwarte
                 *ogólnie, kiedy dziekanat jest czynny
                 * jak znaleźć?
                 * dane kontaktowe (mail/tel) dziekanatu
                 * strona www dziekanatu
                 * dla WSZYSTKICH wydziałów
                */
            }


        }
    }
}
