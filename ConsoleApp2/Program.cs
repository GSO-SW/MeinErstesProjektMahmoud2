using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {

         
         int value = 1234;

         double value2 = 1000.11;
         Console.WriteLine(value + value2);

         long a = 10, b = 1000000000000000000;

         Console.WriteLine
                ("Wert von 'a' = {0}\nWert von 'b' = {1}", a, b);

         Console.WriteLine("Ich kaufe {0,10} Eier", a);
         Console.WriteLine("Ich kaufe {0,-10} Eier", a);

         Console.WriteLine("value= {0:E}", value);
         Console.WriteLine("value= {0:E2}", value);

         float value3 = 0.2512F;
         Console.WriteLine("value3={0,10:G}", value3);
         Console.WriteLine("value3={0:P4}", value3);
         Console.WriteLine($"a={a},b={b}");
         Console.WriteLine("a={0},b={1}", a, b);

         Console.WriteLine("Hallo\\Welt");

         string input1 = Console.ReadLine();                        //Wartet auf den Eingabestrom und gibt die Zeichenfolge als string wieder
         Console.WriteLine($"Die Eingabe ist: {0}",input1);         //Der Zeilenunbruch wird bei ReadLine aus dem Eingabestrom gelöscht
         Console.WriteLine($"Die Eingabe ist: {input1}");

         int input2 = Console.Read();                               //Read liest den ersten eingabewert als Dezimalen ASCII-Wert aus 
         Console.WriteLine(input2);                                 //Der Zeilenumbruch wird nicht aus dem Eingabestrom gelöscht
         Console.ReadLine();                                        //gepuffert bis eine Methode wie ReadLine sie direkt verarbeitet








         Console.ReadKey();






        }
    }
}
