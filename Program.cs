using System;

namespace PenSimulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPen myPen = new Pen();

            while (true)
            {
                Console.Write("Enter command (open, close, write <message>, exit): ");
                string input = Console.ReadLine() ?? "";

                if (input == "open")
                {
                    myPen.Open();
                }
                else if (input == "close")
                {
                    myPen.Close();
                }
                else if (input.StartsWith("write "))
                {
                    string message = input.Substring("write ".Length);
                    myPen.Write(message);
                }
                else if (input == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Unknown command.");
                }
            }
        }
    }
}
