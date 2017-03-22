using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmRechnerV1._0
{
    class dEingabe
    {
        public static double GetDouble()
        {
            bool bComma = false;
            bool bMinus = false;
            bool bE = false;
            ConsoleKeyInfo taste;
            StringBuilder sbEingabe = new StringBuilder();
            double dZahl = 0;


            do
            {
                
                    taste = Console.ReadKey(true);
                    switch (taste.Key)
                    {
                        case ConsoleKey.E:

                            if (sbEingabe.Length > 0 && bE == false && sbEingabe.ToString(sbEingabe.Length - 1, 1) != "-")
                            {
                                sbEingabe.Append(taste.KeyChar);
                                Console.Write(taste.KeyChar);
                                bE = true;
                                bMinus = false;
                            }
                            break;
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

                            if (sbEingabe.ToString().Contains("e-"))
                            {
                                if (sbEingabe.ToString(sbEingabe.Length - 1, 1) == "1")
                                {
                                    if (Convert.ToInt32(taste.KeyChar.ToString()) > 8)
                                        break;
                                }
                                else if (sbEingabe.ToString(sbEingabe.ToString().IndexOf("e-") - 1, 1) != "1")
                                {
                                    if (sbEingabe.Length == sbEingabe.ToString().IndexOf("e-") + 3)
                                        break;
                                }
                                if (sbEingabe.Length == sbEingabe.ToString().IndexOf("e") + 4)
                                    break;
                            }
                            else if (sbEingabe.ToString().Contains("e"))
                            {
                                if (sbEingabe.ToString(sbEingabe.Length - 1, 1) == "1")
                                {
                                    if (Convert.ToInt32(taste.KeyChar.ToString()) > 8)
                                        break;
                                }
                                else if (sbEingabe.ToString(sbEingabe.ToString().IndexOf("e") - 1, 1) != "1")
                                {
                                    if (sbEingabe.Length == sbEingabe.ToString().IndexOf("e") + 2)
                                        break;
                                }
                                if (sbEingabe.Length == sbEingabe.ToString().IndexOf("e") + 3)
                                    break;

                            }

                            if (taste.Modifiers > 0) continue;
                            sbEingabe.Append(taste.KeyChar);
                            Console.Write(taste.KeyChar);

                            break;

                        case ConsoleKey.OemMinus:
                        case ConsoleKey.Subtract:
                            if (sbEingabe.Length == 0 && bMinus == false || sbEingabe.ToString(sbEingabe.Length - 1, 1) == "e")
                            {

                                sbEingabe.Append(taste.KeyChar);
                                Console.Write(taste.KeyChar);
                                bMinus = true;

                            }
                            break;

                        case ConsoleKey.Backspace:
                            if (sbEingabe.Length > 0)
                            {
                                if (sbEingabe.ToString(sbEingabe.Length - 1, 1) == ",")
                                {
                                    bComma = false;
                                }
                                if (sbEingabe.ToString(sbEingabe.Length - 1, 1) == "e" || sbEingabe.ToString(sbEingabe.Length - 1, 1) == "E")
                                {
                                    bE = false;
                                }

                                if (sbEingabe.ToString(sbEingabe.Length - 1, 1) == "-")
                                {
                                    bMinus = false;
                                }

                                sbEingabe.Remove(sbEingabe.Length - 1, 1);
                                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                Console.Write(" ");
                                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);


                            }

                            break;
                        case ConsoleKey.OemComma:
                        case ConsoleKey.Decimal:
                            if (sbEingabe.Length > 0 && bComma == false && sbEingabe.ToString(sbEingabe.Length - 1, 1) != "-" && bE == false)
                            {
                                sbEingabe.Append(taste.KeyChar);
                                Console.Write(taste.KeyChar);
                                bComma = true;



                            }
                            break;

                    }
                }
                
            
            
            while (taste.Key != ConsoleKey.Enter);
            if (sbEingabe.Length == 0)
            {
                sbEingabe.Append("0");
            }
            dZahl = Convert.ToDouble(sbEingabe.ToString());
            
            return dZahl;


        }
    }
}
