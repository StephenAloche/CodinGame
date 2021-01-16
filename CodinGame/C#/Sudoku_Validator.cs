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
    List<List<int>> Sudoku = new List<List<int>>();
	
	for (int i = 0; i < 9; i++)
	{
		List<int> Line = new List<int>();
		string[] inputs = Console.ReadLine().Split(' ');
		//string[] o = entry.Split('\n');
		//string[] inputs = o[i].Split(' ');
			for (int j = 0; j < 9; j++)
			{
				int n = int.Parse(inputs[j]);
			Line.Add(n);
			//int[] column = ListColumns[j];
			//	column[i] = n;
				
				Console.Error.Write(n);
				Console.Error.Write(' ');
			}
		Sudoku.Add(Line);
		Console.Error.WriteLine();
	}
	//si une des ligne comporte des element inferieur a 1 ou superieur a 9
string retour = "true";
		if (Sudoku.Any(line => line.Any(n => (n > 9 || n < 1))))
	{
		Console.Error.WriteLine("first if");
		retour = "false";
	}
	else
	{
		//numero en double dans les columns
		for (int i = 0; i < 9; i++)
		{
			if (Sudoku.GroupBy(line => line[i]).Any(n => n.Count() > 1))
			{
				Console.Error.WriteLine("column double");
				retour = "false";
			}
		}

		//numero en double dans un eligne
		if (Sudoku.Any(line => line.GroupBy(n => n).Any(n => n.Count() > 1)))
		{
			Console.Error.WriteLine("ligne double");
			retour = "false";
		}
		//verification des subGrids
        bool subGridError = false;
        for (int i = 0; i < 9; i+=3)
		{
			for	(int j = 0; j < 3; j++)
			{				
            List<int> listLine = new List<int>();
				listLine = Sudoku[0+i].Skip(3*j).Take(3).ToList();
				listLine.AddRange(Sudoku[1+i].Skip(3*j).Take(3).ToList());
				listLine.AddRange(Sudoku[2+i].Skip(3*j).Take(3).ToList());
                subGridError = listLine.GroupBy(n=>n).Any(n=>n.Count()>1);

                if (subGridError)
                {
                    Console.Error.WriteLine("error subgrid");
                    retour="false";
                }
			}
		}

		

		Console.WriteLine(retour);
	}
	}
}