using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Program
    {
        static bool check = true;
        static bool checkgame = true;
        static int number;
        static int number1;
        static string N;
        static int dong;
        static int score = 0;
        static void Main(string[] args)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write($"Score: {score}");
            Thread t = new Thread(() => { random(); });
            t.Start();
            while (check == true)
            {
                var move = Console.ReadKey(true).Key;
                if (number == 0 && move == ConsoleKey.A)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 1 && move == ConsoleKey.B)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 2 && move == ConsoleKey.C)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 3 && move == ConsoleKey.D)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 4 && move == ConsoleKey.E)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 5 && move == ConsoleKey.F)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 6 && move == ConsoleKey.G)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 7 && move == ConsoleKey.H)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 8 && move == ConsoleKey.I)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 9 && move == ConsoleKey.J)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 10 && move == ConsoleKey.K)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 11 && move == ConsoleKey.L)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 12 && move == ConsoleKey.M)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 13 && move == ConsoleKey.N)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 14 && move == ConsoleKey.O)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 15 && move == ConsoleKey.P)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 16 && move == ConsoleKey.Q)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 17 && move == ConsoleKey.R)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 18 && move == ConsoleKey.S)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 19 && move == ConsoleKey.T)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 20 && move == ConsoleKey.U)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 21 && move == ConsoleKey.V)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 22 && move == ConsoleKey.W)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 23 && move == ConsoleKey.X)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 24 && move == ConsoleKey.Y)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
                else if (number == 25 && move == ConsoleKey.Z)
                {
                    score++;
                    Console.Clear();
                    t.Suspend();
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(number1, dong);
                    t = new Thread(() => { random(); });
                    t.Start();
                }
            }
        }

        static void random()
        {
            Random ran = new Random();
            number = ran.Next(0, 26);
            number1 = ran.Next(5, 110);
            N = "";
            dong = 1;
            switch (number)
            {
                case 0:
                    N += "A";
                    break;
                case 1:
                    N += "B";
                    break;
                case 2:
                    N += "C";
                    break;
                case 3:
                    N += "D";
                    break;
                case 4:
                    N += "E";
                    break;
                case 5:
                    N += "F";
                    break;
                case 6:
                    N += "G";
                    break;
                case 7:
                    N += "H";
                    break;
                case 8:
                    N += "I";
                    break;
                case 9:
                    N += "J";
                    break;
                case 10:
                    N += "K";
                    break;
                case 11:
                    N += "L";
                    break;
                case 12:
                    N += "M";
                    break;
                case 13:
                    N += "N";
                    break;
                case 14:
                    N += "O";
                    break;
                case 15:
                    N += "P";
                    break;
                case 16:
                    N += "Q";
                    break;
                case 17:
                    N += "R";
                    break;
                case 18:
                    N += "S";
                    break;
                case 19:
                    N += "T";
                    break;
                case 20:
                    N += "U";
                    break;
                case 21:
                    N += "V";
                    break;
                case 22:
                    N += "W";
                    break;
                case 23:
                    N += "X";
                    break;
                case 24:
                    N += "Y";
                    break;
                case 25:
                    N += "Z";
                    break;
            }
            while (checkgame == true)
            {
                //Console.Clear();
                Console.SetCursorPosition(number1, dong);
                Console.Write(N);
                Console.SetCursorPosition(number1, dong - 1);
                Console.Write(" ");
                Thread.Sleep(500);
                dong++;
            }
        }
    }
}