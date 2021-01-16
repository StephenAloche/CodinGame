using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTX = int.Parse(inputs[2]); // Thor's starting X position
        int initialTY = int.Parse(inputs[3]); // Thor's starting Y position
    
        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.
            
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            /*
            Console.WriteLine("N"); TY != Y && TX = X && TY > Y
            Console.WriteLine("S"); TY != Y && TX = X && TY < Y
            Console.WriteLine("E"); TX != X && TY = Y && TX < X
            Console.WriteLine("W"); TX != X && TY = Y && TX > X
            Console.WriteLine("NW"); TX != X && TY != Y && TY > Y && TX > X
            Console.WriteLine("NE"); TX != X && TY != Y && TY > Y && TX < X            
            Console.WriteLine("SW"); TX != X && TY != Y && TY < Y && TX > X
            Console.WriteLine("SE"); TX != X && TY != Y && TY < Y && TX < X
            */
            if(initialTX != lightX && initialTY != lightY)
            {
                if(initialTY>lightY && initialTX>lightX)
                {                 
                    initialTX-=1;
                    initialTY-=1;
                    Console.WriteLine("NW");   
                }
                else if(initialTY>lightY && initialTX<lightX)
                {                  
                    initialTX+=1;
                    initialTY-=1;
                    Console.WriteLine("NE"); 
                }                
                else if(initialTY<lightY && initialTX>lightX)
                {                  
                    initialTX-=1;
                    initialTY+=1;
                    Console.WriteLine("SW"); 
                }                
                else if(initialTY<lightY && initialTX<lightX)
                {                  
                    initialTX+=1;
                    initialTY+=1;
                    Console.WriteLine("SE"); 
                }
            }
            else
            {
                if(initialTX != lightX)
                {
                    if(initialTX<lightX)
                    {
                    Console.Error.WriteLine("initialTX "+initialTX+" lightX "+lightX);
                    initialTX+=1;
                    Console.WriteLine("E");
                    }
                    else
                    {    
                    Console.Error.WriteLine("initialTX "+initialTX+" lightX "+lightX);
                    initialTX-=1;                        
                    Console.WriteLine("W");
                    }
                }
    
                if(initialTY != lightY)
                {
                    if(initialTY<lightY)
                    {                    
                    Console.Error.WriteLine("initialTY "+initialTY+" lightY "+lightY);
                    initialTY+=1;
                    Console.WriteLine("S");
                    }
                    else
                    {             
                    Console.Error.WriteLine("initialTY "+initialTY+" lightY "+lightY); 
                    initialTY-=1;                     
                    Console.WriteLine("N");
                    }                
                }    
            }
                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                                           
        }
    }
}