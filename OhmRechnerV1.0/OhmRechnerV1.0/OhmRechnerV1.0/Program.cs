using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OhmRechnerV1._0
{
    class Program
    {
        
        
            public static void loescheZeile() 
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine(new string(' ',Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 2);
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black; 
            double dEingabe_1, dEingabe_2;
            double dErgebniss;
            ConsoleKeyInfo ckiTaste;
            Console.Title = "Ohm Rechner";
            do
            {
                dEingabe_1= 0;
                dEingabe_2 = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.SetCursorPosition(1, 2);
                Console.WriteLine("Berechnungen im ohmschen Gesetz");
                Console.WriteLine(" ===============================");
                Console.SetCursorPosition(1, 5);
                Console.WriteLine("Spannung                   < 1 >");
                Console.SetCursorPosition(1, 6);
                Console.WriteLine("Widerstand                 < 2 >");
                Console.SetCursorPosition(1, 7);
                Console.WriteLine("Strom                      < 3 >"); 
                Console.SetCursorPosition(1, 16);
                Console.WriteLine("Ihre Eingabe               <   >");
                Console.SetCursorPosition(1, 20);
                Console.WriteLine(" -  ESC für Programmabbruch  -");
                Console.SetCursorPosition(30, 16);
                
                ckiTaste = Console.ReadKey(true);
                switch (ckiTaste.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                     // Widerstand kann nicht <= 0 sein.
                    do
                    {
                        Console.Write("Geben Sie den Widerstand ein: ");
                        dEingabe_1 = dEingabe.GetDouble();
                        if (dEingabe_1 <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ungültige Eingabe, die Zahl muss größer als 0 sein !");
                            Thread.Sleep(3000);
                            loescheZeile();
                            loescheZeile();
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                    }
                    while (dEingabe_1 <= 0 );
                    do
                    {
                        Console.SetCursorPosition(0, 2);
                        Console.Write("Geben Sie den Strom ein: ");
                        dEingabe_2 = dEingabe.GetDouble();
                        if (dEingabe_2 <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ungültige Eingabe, die Zahl muss größer als 0 sein !");
                            Thread.Sleep(3000);
                            loescheZeile();
                            loescheZeile();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    while (dEingabe_2 <= 0);
                        dErgebniss = dEingabe_1* dEingabe_2;
                        Console.SetCursorPosition(0, 6);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Das Ergebnis ist: ");
                        Console.Write(dErgebniss);
                        Console.SetCursorPosition(0, 7);
                        Console.Write("____________________");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        do
                        {
                            Console.Clear();
                            Console.Write("Geben Sie die Spannung ein: ");
                            dEingabe_1 = dEingabe.GetDouble();

                            if (dEingabe_1 <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ungültige Eingabe, die Zahl muss größer als 0 sein !");
                                Thread.Sleep(2000);
                                loescheZeile();
                                loescheZeile();
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        } 
                        while (dEingabe_1 <= 0);

                        do
                        {
                            Console.Write("Geben Sie den Strom ein: ");
                            dEingabe_2 = dEingabe.GetDouble();
                            if (dEingabe_2 <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ungültige Eingabe, die Zahl muss größer als 0 sein !");
                                Thread.Sleep(2000);
                                loescheZeile();
                                loescheZeile();
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        } while (dEingabe_2 <= 0);
                        
                        dErgebniss = dEingabe_1 / dEingabe_2;
                        Console.SetCursorPosition(0, 6);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Das Ergebniss ist: ");
                        Console.Write(dErgebniss);
                        Console.SetCursorPosition(0, 7);
                        Console.Write("____________________");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        do
                        {
                            Console.Clear();
                            Console.Write("Geben Sie die Spannung ein: ");
                            dEingabe_1 = dEingabe.GetDouble();
                            if (dEingabe_1 <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ungültige Eingabe, die Zahl muss größer als 0 sein !");
                                Thread.Sleep(2000);
                                loescheZeile();
                                loescheZeile();
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        } while (dEingabe_1 <= 0);
                        do
                        {
                            Console.Write("Geben Sie den Widerstand ein: ");
                            dEingabe_2 = dEingabe.GetDouble();
                            if (dEingabe_2 <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ungültige Eingabe, die Zahl muss größer als 0 sein !");
                                Thread.Sleep(2000);
                                loescheZeile();
                                loescheZeile();
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        } while (dEingabe_2 <= 0);
                        dErgebniss = dEingabe_1 / dEingabe_2;
                        Console.SetCursorPosition(0, 6);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Das Ergebniss ist: ");
                        Console.Write(dErgebniss);
                        Console.SetCursorPosition(0, 7);
                        Console.Write("____________________");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(1, 18);
                        Console.CursorVisible = (false);
                        Console.Write("Ungültige Eingabe");
                        Thread.Sleep(1000);
                        Console.CursorVisible = (true);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;


                }
            }
            while (ckiTaste.Key != ConsoleKey.Escape);
        }
        }
    }

