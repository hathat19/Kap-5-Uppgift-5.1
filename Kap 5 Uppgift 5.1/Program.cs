using System;
namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            //-------------------------------------------

            string[] sentances = { "Hej jag heter Hugo!", "Vad heter du?", "Jag äter banan.", "Banan är överskattat." };

            //Utskrift
            foreach (string sentance in sentances)
            {
                Console.WriteLine(sentance + "\n");
            }
        }
    }
}
/*Skapa ett program som innehåller en array med strängar där varje sträng är en
mening. Skriv ut varje mening med hjälp av en loop, gör så att varje mening hamnar i
ett eget stycke, det ska alltså vara en tom rad mellan varje mening.*/
