using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //ints
            int Char_HP_Current = 20;
            int Char_HP_Full = 20;
            int Char_EXP_Current = 20;
            int Char_EXP_Full = 100;
            int Char_Level_Current = 1;

            int Char_Move_Left_Right = 10;
            int Char_Move_Up_Down = 10;

            int Game_Over = 0;
            //Strings
            string Char_Name = "Bastard Inc";

            
            do{
                //Count EXP


                //Draw GUI
                //Draw Stats
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("________________________________________________________________________________");
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("Name: {0}", Char_Name);
                Console.SetCursorPosition(35, 1);
                Console.WriteLine("HP: {0}/{1}", Char_HP_Current, Char_HP_Full);
                Console.SetCursorPosition(60, 1);
                Console.WriteLine("EXP: {0}/{1}", Char_EXP_Current, Char_EXP_Full);
                Console.WriteLine("________________________________________________________________________________");
                Console.SetCursorPosition(0, 1);
                //Draw Game Screen
                for (int a = 3; a <= 21; a++)
                {
                    Console.SetCursorPosition(0, a);
                    Console.WriteLine("|");
                    Console.SetCursorPosition(79, a);
                    Console.WriteLine("|");
                }
                Console.SetCursorPosition(0, 22);
                Console.WriteLine("________________________________________________________________________________");


                //Player Controls
                ConsoleKeyInfo KeyInfo;
                KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    //moving up down left and right
                    case ConsoleKey.RightArrow:
                        Char_Move_Left_Right++;
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down);
                        Console.Write("X");
                        Console.SetCursorPosition(Char_Move_Left_Right - 1, Char_Move_Up_Down);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("X");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case ConsoleKey.LeftArrow:
                        Char_Move_Left_Right--;
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down);
                        Console.Write("X");
                        Console.SetCursorPosition(Char_Move_Left_Right + 1, Char_Move_Up_Down);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("X");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case ConsoleKey.UpArrow:
                        Char_Move_Up_Down--;
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down);
                        Console.Write("X");
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down + 1);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("X");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case ConsoleKey.DownArrow:
                        Char_Move_Up_Down++;
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down);
                        Console.Write("X");
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down - 1);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("X");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case ConsoleKey.Spacebar:
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down);
                        Console.Write("X");


                        // Sword Attack 
                        System.Threading.Thread.Sleep(30);
                        Console.SetCursorPosition(Char_Move_Left_Right + 1, Char_Move_Up_Down);
                        Console.Write("-");
                        Console.SetCursorPosition(Char_Move_Left_Right + 1, Char_Move_Up_Down);
                        System.Threading.Thread.Sleep(40);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("-");
                        Console.ForegroundColor = ConsoleColor.White;

                        System.Threading.Thread.Sleep(30);
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down - 1 );
                        Console.Write("|");
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down - 1);
                        System.Threading.Thread.Sleep(40);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.White;

                        System.Threading.Thread.Sleep(30);
                        Console.SetCursorPosition(Char_Move_Left_Right - 1, Char_Move_Up_Down);
                        Console.Write("-");
                        Console.SetCursorPosition(Char_Move_Left_Right - 1, Char_Move_Up_Down);
                        System.Threading.Thread.Sleep(40);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("-");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                }
            } while (Game_Over == 0);

            Console.ReadLine();
        }
    }
}
