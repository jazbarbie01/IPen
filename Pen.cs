using System;

namespace PenSimulation
{
    public class Pen : IPen
    {
        private bool isOpen = false;

        public void Open()
        {
            isOpen = true;
            Console.WriteLine("Pen is now open.");
        }

        public void Close()
        {
            isOpen = false;
            Console.WriteLine("Pen is now closed.");
        }

        public void Write(string message)
        {
            if (isOpen)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Cannot write. Pen is closed.");
            }
        }
    }
}
