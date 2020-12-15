using System;

namespace HomeWork4_Pyphagoras
{
    class Program
    {
        static int ReadLine()
        {
            int IntputNum = Int32.Parse(Console.ReadLine());
            return IntputNum;
        }

        static void WriteIndent(int LastVer, int FirstVer, int countMaxRank)
        {
            Console.WriteLine();
            while (countMaxRank > 0)
            {
                Console.Write(" ");
                countMaxRank--;
            }
            Console.Write("  "); //verNumbers have sign |
        }

        static void WriteHor(int FirstHor, int LastHor, int countMaxRank)
        {
            while (true)
            {
                int countHor = 0;
                int countHorRank;
                int FirstHorEmul = FirstHor;
                while (true)
                {
                    FirstHorEmul = FirstHorEmul / 10;
                    countHor++;
                    if (FirstHorEmul == 0)
                    {
                        break;
                    }
                }
                if (FirstHor >= 0)
                {
                    countHorRank = countMaxRank - countHor;
                }
                else
                {
                    countHorRank = (countMaxRank -1) - countHor;

                }
                while (countHorRank >= 0)
                {
                    Console.Write(" ");
                    countHorRank--;
                }
                Console.Write(FirstHor);
                if (FirstHor == LastHor)
                {
                    break;
                }
                if (FirstHor < LastHor)
                {
                    FirstHor++;
                }
                else
                {
                    FirstHor--;
                }
            }
        }

        static void WriteLine(int FirstHor, int LastHor, int countMaxRank)
        {
            while (true)
            {
                int countLine = 0;
                int countLineAll;
                int FirstHorEmul = FirstHor;
                while (true)
                {
                    FirstHorEmul = FirstHorEmul / 10;
                    countLine++;
                    if (FirstHorEmul == 0)
                    {
                        break;
                    }
                }
                int CountLineSpace = countLine;
                if (FirstHor >= 0)
                {
                    countLineAll = countMaxRank - CountLineSpace;
                }
                else
                {
                    countLineAll = (countMaxRank - 1) - CountLineSpace;

                }
                while (countLineAll >= 0)
                {
                    Console.Write(" ");
                    countLineAll--;
                }
                while (CountLineSpace > 0)
                {
                    Console.Write("_");
                    CountLineSpace--;
                }
                if (FirstHor < 0)
                {
                    Console.Write("_");
                }
                if (FirstHor == LastHor)
                {
                    break;
                }
                if (FirstHor < LastHor)
                {
                    FirstHor++;
                }
                else
                {
                    FirstHor--;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void WriteMultip(int FirstHor, int LastHor, int FirstVer, int LastVer, int countMaxRank, int correctionHor)
        {
            while (true)
            {
                int FirstVerEmul = FirstVer;
                int countVer = 0;
                int countVerRank;
                while (true)
                {
                    FirstVerEmul = FirstVerEmul / 10;
                    countVer++;
                    if (FirstVerEmul == 0)
                    {
                        break;
                    }
                }
                if (FirstVer >= 0)
                {
                    countVerRank = countMaxRank - countVer;
                }
                else
                {
                    countVerRank = (countMaxRank - 1) - countVer;

                }
                while (countVerRank >= 0)
                {
                    Console.Write(" ");
                    countVerRank--;
                }
                Console.Write(FirstVer + "|");

                FirstHor = correctionHor;
                while (true)
                {
                    int result = FirstHor * FirstVer;
                    int countLoc = 0;
                    int countLocalRank;
                    int resultMultip = result;
                    while (true)
                    {
                        resultMultip = resultMultip / 10;
                        countLoc++;
                        if (resultMultip == 0)
                        {
                            break;
                        }
                    }
                    if (result >= 0)
                    {
                        countLocalRank = countMaxRank - countLoc;
                    }
                    else
                    {
                        countLocalRank = (countMaxRank - 1) - countLoc;
                    }
                    while (countLocalRank >= 0)
                    {
                        Console.Write(" ");
                        countLocalRank--;
                    }
                    Console.Write(result);
                    if (FirstHor == LastHor)
                    {
                        break;
                    }
                        if (FirstHor < LastHor)
                    {
                        FirstHor++;
                    }
                    else
                    {
                        FirstHor--;
                    }
                }
                if (FirstVer == LastVer)
                {
                    break;
                }
                    if (FirstVer < LastVer)
                {
                    FirstVer++;
                }
                else
                {
                    FirstVer--;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int correctionHor;
            int FirstHor = Int32.MinValue;
            int LastHor = Int32.MinValue;
            int FirstVer = Int32.MinValue;
            int LastVer = Int32.MinValue;

            while (FirstHor == Int32.MinValue)
            {
                try
                {
                    Console.WriteLine("Enter first number of range of horizontal values:");
                    FirstHor = ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong enter!!!");
                    continue;
                }
            }
            correctionHor = FirstHor;

            while (LastHor == Int32.MinValue)
            {
                try
                {
                    Console.WriteLine("Enter last number of range of horizontal values:");
                    LastHor = ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong enter!!!");
                    continue;
                }
            }
            while (FirstVer == Int32.MinValue)
            {
                try
                {
                    Console.WriteLine("Enter first number of range of vertical values:");
                    FirstVer = ReadLine();
                }

                catch (Exception)
                {
                    Console.WriteLine("Wrong enter!!!");
                    continue;
                }
            }
            while (LastVer == Int32.MinValue)
            {
                try
                {
                    Console.WriteLine("Enter last number of range of vertical values:");
                    LastVer = ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong enter!!!");
                    continue;
                }
            }

            int maxVal = 0;
            if (Math.Abs(LastHor) >= Math.Abs(FirstHor) && Math.Abs(LastVer) >= Math.Abs(FirstVer))
            {
                maxVal = LastHor * LastVer;
            }
            if (Math.Abs(FirstHor) >= Math.Abs(LastHor) && Math.Abs(FirstVer) >= Math.Abs(LastVer))
            {
                maxVal = FirstHor * FirstVer;
            }
            if (Math.Abs(FirstHor) >= Math.Abs(LastHor) && Math.Abs(LastVer) >= Math.Abs(FirstVer))
            {
                maxVal = FirstHor * LastVer;
            }
            if (Math.Abs(LastHor) >= Math.Abs(FirstHor) && Math.Abs(FirstVer) >= Math.Abs(LastVer))
            {
                maxVal = LastHor * FirstVer;
            }

            int countMaxRank = 0;
            int MaxValue = maxVal;
            while (true) 
                {
                MaxValue = MaxValue / 10;
                countMaxRank++;
                if (MaxValue == 0)
                {
                    break;
                }
            }

            WriteIndent(LastVer, FirstVer, countMaxRank);
            WriteHor(FirstHor, LastHor, countMaxRank);

            FirstHor = correctionHor;
            WriteIndent(LastVer, FirstVer, countMaxRank);
            WriteLine(FirstHor, LastHor, countMaxRank);

            WriteMultip(FirstHor, LastHor, FirstVer, LastVer, countMaxRank, correctionHor);

            Console.ReadLine();
        }
    }
}