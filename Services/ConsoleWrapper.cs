using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    class ConsoleWrapper
    {
        public void PrintInLine(string text)
        {
            Console.Write(text);
        }
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
        public void ClearPrint(string text)
        {
            Console.Clear();
            Console.WriteLine(text);
        }
        public System.ConsoleKeyInfo KeyRead()
        {
           return Console.ReadKey();
        }
        public void clear()
        {
            Console.Clear();
        }

        public void ConsoleRed()
        {
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Red;
        }
        public void ConsoleGreen()
        {
            Console.ForegroundColor = System.ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Green;
        }

        public void ConsoleGray()
        {
            Console.ForegroundColor = System.ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }
        public void ConsoleYellow()
        {
            Console.ForegroundColor = System.ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
        }
        public void ConsoleDefaoult()
        {
            Console.ForegroundColor = System.ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public int randomInt(int choicesCount)
        {
            Random random = new Random();
            return random.Next(choicesCount+1);
        }
        public void newLine()
        {
            Console.Write("\n");
        }
    }
}
