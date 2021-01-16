using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        if(n!=0)
        {
            string[] inputs = Console.ReadLine().Split(' ');
                List<int> listTemp = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int t = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526
                listTemp.Add(t);
            }
            
            int nearestTemp = listTemp[0];
            int tempTemp = 0;
                Console.Error.WriteLine("nearestTemp : "+nearestTemp);
            foreach (int temp in listTemp)
            {            
                Console.Error.WriteLine("temp : "+ temp);
                if(Math.Abs(temp)<=Math.Abs(nearestTemp))
                {                    
                    if(Math.Abs(temp)==Math.Abs(nearestTemp))
                    {
                        nearestTemp = temp.CompareTo(nearestTemp) > 0 ? temp : nearestTemp;
                    }    
                    else
                    {
                        nearestTemp = temp;                    
                        Console.Error.WriteLine("nearestTemp : "+nearestTemp);}                
                    }
                }
                Console.WriteLine(nearestTemp);
            }
        else
        {
        Console.WriteLine(0);            
        }
    }
}

/* soluce 

int tempCount = int.Parse(Console.ReadLine());
        var temps = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

        var result = temps.Select(int.Parse)
            .OrderBy(Math.Abs)
            .ThenByDescending(x => x)
            .FirstOrDefault();

        Console.WriteLine(result);
        
*/