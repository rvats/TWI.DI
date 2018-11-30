using System;
using System.Threading;

namespace TWI.DI
{
    public static class TwiConsole
    {
        public static int Rows;

        private static void WriteMessage(string message, ConsoleColor color = ConsoleColor.White,
            bool animation = false, bool newLine = false)
        {
            Console.ForegroundColor = color;
            if (newLine)
            {
                Console.WriteLine(message);
                Rows++;
            }
            else
            {
                Console.Write(message);
            }

            Console.ForegroundColor = ConsoleColor.White;
            if (animation)
            {
                ApplyAnimation();
            }
        }

        private static void ApplyAnimation(int delayInMilliSeconds = 500)
        {
            Thread.Sleep(delayInMilliSeconds);
        }

        public static string ReadLine()
        {
            Rows++;
            return Console.ReadLine();
        }

        public static void WriteHighlightMessage(string message, bool animation = false, bool newLine = false)
        {
            WriteMessage(message, ConsoleColor.Blue, animation, newLine);
        }

        public static void WriteSuccessMessage(string message, bool animation = false, bool newLine = false)
        {
            WriteMessage(message, ConsoleColor.Green, animation, newLine);
        }

        public static void WriteErrorMessage(string message, bool animation = false, bool newLine = false)
        {
            WriteMessage(message, ConsoleColor.Red, animation, newLine);
        }

        public static void WriteGeneralMessage(string message, bool animation = false, bool newLine = false)
        {
            WriteMessage(message, ConsoleColor.White, animation, newLine);
        }
    }
}
