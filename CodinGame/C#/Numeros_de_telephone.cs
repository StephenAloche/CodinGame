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
    public static int count = 0;
    static void Main(string[] args)
    {
        List<string> numList = new List<string>();

        int N = int.Parse(Console.ReadLine());

        string tel = "";
        if (N > 0)
        {
            for (int i = 0; i < N; i++)
            {
                tel = Console.ReadLine();
                numList.Add(tel);
            }
        }
        BuildTree(numList.Distinct().ToList());

        Console.WriteLine(count);
    }

    static void BuildTree(List<string> listNum)
    {
        if (listNum.Count == 1)
        {
            count += listNum[0].Length;
            return;
        }

        for (int i = 0; i <= 9; i++)
        {
            var listNumStartWith_i = (from num in listNum where num.StartsWith(i.ToString()) select num).Distinct().ToList();
            if (listNumStartWith_i.Count > 0)
            {
                count++;
                var listFilter = (from item in listNumStartWith_i where item.Length > 1 select item.Substring(1)).ToList();
                if(listFilter.Count != 0)
                    BuildTree(listFilter);
            }
        }
    }
}