﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    public static class HelperClass
    {

        public static void DrawSquare(int x1, int y1, int x2, int y2) {

        }

        public static void CngCol(ConsoleColor c) {
            Console.ForegroundColor = c;
        }

        // get input from the user. if true is inserted the string will be digits only
        public static string GetInput(bool digitsOnly)
        {

            string output = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                    if (_x || !digitsOnly) // if the output should be digits only, check _x.  otherwise just write it to the outputstring
                    {
                        output += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && output.Length > 0)
                    {
                        output = output.Substring(0, (output.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter || output.Length == 0);
            // Stops Receving Keys Once Enter is Pressed

            Console.WriteLine();

            return output;

        }


        // the same as Get Input but it will at the same time write a question
        public static string GetInputToQuestion(string question, bool digitsOnly)
        {

            Console.WriteLine(question);
            return GetInput(digitsOnly);

        }


        //ask a multiple-answer question and return the chosen answer as an int
        public static int MakeMenu(string question, string[] answers)
        {

            int answer;

            Console.WriteLine(question);

            int i = 0;

            foreach (string a in answers)
            {
                Console.WriteLine("\t" + i.ToString() + " : " + a);
                i++;
            }
            answer = GetAnswer(answers.Length - 1);

            return (answer);
        }
        public static int MakeMenu(string question, string[] answers,bool IsOneline)
        {

            int answer;

            Console.WriteLine(question);

            int i = 0;

            bool col = true;

            foreach (string a in answers)
            {
                
                col = !col;
                CngCol(ConsoleColor.DarkGray);
                Console.Write("[");

                if (col) {CngCol(ConsoleColor.Yellow);}
                else { CngCol(ConsoleColor.Yellow); }
                Console.Write(i.ToString());

                CngCol(ConsoleColor.DarkGray);
                Console.Write(":");
                CngCol(ConsoleColor.White);
                Console.Write(a);
                CngCol(ConsoleColor.DarkGray);
                Console.Write("]");
                CngCol(ConsoleColor.Gray);
                i++;
            }
            answer = GetAnswer(answers.Length - 1);
            Console.WriteLine();

            return (answer);
        }


        // this function  iterates to check if a input is within the given range. use this together with MakeMenu() to easily make menues  
        public static int GetAnswer(int range)
        {

            int answer = range + 1;

            do
            {

                int input = int.Parse(GetInput(true));

                if (input <= range)
                {
                    answer = input;
                }
                else
                {
                    Console.WriteLine("Input a valid choice between 0 and " + range.ToString() + "!");
                }

            } while (answer > range); // if the input is not within the range then 
            return answer;
        }
    }
}
