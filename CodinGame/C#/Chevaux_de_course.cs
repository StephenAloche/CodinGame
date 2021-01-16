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
        int N = int.Parse(Console.ReadLine());
        //stocker les valeurs dans un tableau
        List<int> values = new List<int>();
        List<int> listEcarts  = new List<int>();
        int? lastval = null;

        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            //Console.Error.WriteLine($"pi {i} : {pi}     /");
            values.Add(pi);
        }

        //les trier par ordre croissant
        foreach(int val in values.OrderBy(i=>i))
        {       
            if(lastval != null)                
                listEcarts.Add(val-(int)lastval); //stocké l'écarts entre chaques valeurs
            lastval = val;  
        }
        Console.WriteLine(listEcarts.Min());
    }
}