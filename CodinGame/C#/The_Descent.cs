using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            int indexMax=0;
            int ValueMax=0;
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                Console.Error.WriteLine("mountainH "+mountainH);
                if(mountainH > ValueMax)
                {
                    ValueMax = mountainH;
                    indexMax = i;
                    Console.Error.WriteLine("indexMax "+indexMax);
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(indexMax); // The index of the mountain to fire on.
        }
    }
}