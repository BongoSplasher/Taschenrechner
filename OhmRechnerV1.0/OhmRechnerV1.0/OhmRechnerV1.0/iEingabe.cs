using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmRechnerV1._0
{
    class iEingabe
    {
        public static int GetInt()
        {
            bool boolComma = false; int iZahl = 0;
            ConsoleKeyInfo taste;
            StringBuilder sbEingabe = new StringBuilder();



            do
            {
                taste = Console.ReadKey(true);
                switch (taste.Key)
                {

                    case ConsoleKey.D0:
                    case ConsoleKey.D1:
                    case ConsoleKey.D2:
                    case ConsoleKey.D3:
                    case ConsoleKey.D4:
                    case ConsoleKey.D5:
                    case ConsoleKey.D6:
                    case ConsoleKey.D7:
                    case ConsoleKey.D8:
                    case ConsoleKey.D9:

                        sbEingabe.Append(taste.KeyChar);
                        Console.Write(taste.KeyChar);
                        break;
                    case ConsoleKey.OemMinus:
                        if (sbEingabe.Length == 0)
                        {
                            sbEingabe.Append(taste.KeyChar);
                            Console.Write(taste.KeyChar);
                        }
                        break;

                    case ConsoleKey.Backspace:
                        if (sbEingabe.Length > 0)
                        {
                            sbEingabe.Remove(sbEingabe.Length - 1, 1);
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        }
                        break;
                    case ConsoleKey.OemComma:
                        if (sbEingabe.Length > 0 && boolComma == false)
                        {
                            sbEingabe.Append(taste.KeyChar);
                            Console.Write(taste.KeyChar);
                            boolComma = true;



                        }
                        break;

                }
            }
            while (taste.Key != ConsoleKey.Enter);

            iZahl = Convert.ToInt32(sbEingabe.ToString());

            return iZahl;
        }
    }
}
