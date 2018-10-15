using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie_practic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ConsoleKeyInfo key;
            int y = 1;

            ConsoleKeyInfo key2;
            int y2 = 1;

            while (true)
            {
              Show(ref y);
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow) { if (y < 3) y++; }
                else if (key.Key == ConsoleKey.UpArrow) { if (y > 1) y--; }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (y == 1)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(1, 1);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("РЕГИСТРАЦИЯ В ПАЙПАЛ");
                        Console.ReadKey();
                        Console.Clear();
                    }//if add file
                    else if (y == 2)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(1,1);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("ВХОД ЧЕРЕЗ ПАЙПАЛ ПАЙПАЛ");
                        Console.ReadKey();



                        while (true)
                        {
                            Console.Clear();
                            ShowMyAccount(ref y2);
                            key2 = Console.ReadKey();
                            if (key2.Key == ConsoleKey.DownArrow) { if (y2 < 4) y2++; }
                            else if (key2.Key == ConsoleKey.UpArrow) { if (y2 > 1) y2--; }
                            else if (key2.Key == ConsoleKey.Enter)
                            {
                                if (y2 == 1)
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(1, 1);
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Отправка денег через ПАЙПАЛ");
                                    Console.ReadKey();
                                    Console.Clear();
                                }//if add file
                                else if (y2 == 2)
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(1, 1);
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Пополнить через ПАЙПАЛ");
                                    Console.ReadKey();
                                }
                                else if (y2 == 3)
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(1, 1);
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Снять");
                                    Console.ReadKey();
                                }
                                else if (y2 == 4)
                                {
                                    Environment.Exit(0);
                                }
                            }

                        }

                        Console.Clear();
                    }// копирование на флеш устройство
                    else if (y == 3)
                    {
                        Environment.Exit(0);
                    }
                    
                }
            }
        }


        public static void Show(ref int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (y == 1) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, 1);
            Console.Write("Регистрация");
            if (y == 2) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, 2);
            Console.Write("Войти");         
            if (y == 3) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, 3);
            Console.Write("Выход");
        }

        public static void ShowMyAccount(ref int y)
        {
            Console.SetCursorPosition(0, 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Кошелек");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (y == 1) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(10, 5);
            Console.Write("Отправить деньги");

            if (y == 2) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(10, 6);
            Console.Write("Пополнить");

            if (y == 3) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(10, 7);
            Console.Write("Снять");

            if (y == 4) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(10, 8);
            Console.Write("Выход");
        }


    }
}


















