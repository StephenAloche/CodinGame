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
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
            char[] inputText = T.ToCharArray();
            var asciiLetters = new List<String>();
        
        for (int lineNum = 0; lineNum < H; lineNum++)
        {
            string ROW = Console.ReadLine();
                int rowPlaceHolder = 0;
                for (int letterPosition=0; letterPosition<ROW.Length/L; letterPosition++)
                {
                    if(lineNum == 0)
                    {
                        asciiLetters.Add(ROW.Substring(rowPlaceHolder, L));
                    }
                    else
                    {
                        asciiLetters[letterPosition] += ROW.Substring(rowPlaceHolder, L);
                    }
                    rowPlaceHolder += L;
                }            
        }
        
        string[] lineConsole = new String[H];
        var asciiConstruct = new List<string>();
        for (int charPosition = 0; charPosition< inputText.Length; charPosition++)
        {
            int asciiNum = (int)inputText[charPosition];
            if(asciiNum >= 65 && asciiNum <= 90)
            {
                asciiNum -=65;
            }
            else if(asciiNum >= 97 && asciiNum <= 122)
            {
                asciiNum -=97;
            }
            else
            {
                asciiNum = asciiLetters.Count -1;    
            }
            asciiConstruct.Add(asciiLetters[asciiNum]);
        }
        
        //Affichage
            int lineNumberSortie = 0;
            for (int lineNum2=0; lineNum2<H; lineNum2++)
            {
                for(int asciiCharPos=0;asciiCharPos < asciiConstruct.Count; asciiCharPos++)
                {
                    lineConsole[lineNum2] += asciiConstruct[asciiCharPos].Substring(lineNumberSortie, L);
                }
                lineNumberSortie +=L;
                
                Console.WriteLine(lineConsole[lineNum2]);
            }
        }

}