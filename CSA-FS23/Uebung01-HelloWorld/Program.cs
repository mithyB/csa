using System;

namespace Uebung01_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage("Hello, World!", false);
            PrintMessage("Hello, World!", true);
        }

        /// <summary>
        /// Gibt eine Meldung auf dem Bildschirm aus
        /// </summary>
        /// <param name="message">Anzuzeigende Nachrichte</param>
        /// <param name="toUpper">Ob alles in GROSS oder normalen Buchstaben</param>
        private static void PrintMessage(string message, bool toUpper)
        {
            if (toUpper)
            {
                message = message.ToUpper();
            }

            Console.WriteLine(message);
        }
    }
}