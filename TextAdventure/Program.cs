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

            //Draw GUI
            //Draw Stats
            do{
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

                ConsoleKeyInfo KeyInfo;
                KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        Char_Move_Left_Right++;
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down);
                        Console.WriteLine("X");
                        break;
                }
            } while (Game_Over == 0);

            Console.ReadLine();
        }
    }
}
