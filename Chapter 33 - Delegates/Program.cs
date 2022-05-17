// Delegates Are Similar to Pointers to Functions - pg 266
using System;
using System.IO;

namespace DelegateApp
{
    class PrintString
    {
        static FileStream fileStream;
        static StreamWriter streamWriter;

        // Declare Delegate
        public delegate void printString(string s);

        // Prints to Console
        public static void WriteToScreen(string s)
        {
            System.Console.WriteLine($"String is : {s}");
        }

        // Prints to File
        public static void WriteToFile(string s)
        {
            fileStream = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
            streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(s);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

        // Takes Delegate as Parameter
        // Calls the Required Methods
        public static void sendString(printString ps)
        {
            ps("Hello World");
        }

        public static void Main(string[] args)
        {
            printString ps1 = new printString(WriteToScreen);
            sendString(ps1);

            printString ps2 = new printString(WriteToFile);
            sendString(ps2);
        }
    }
}
// pg 270, 271