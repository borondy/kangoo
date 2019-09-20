using System;

namespace Kangoro.Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write(Kangoroo(-1,1,1,1));
        }
        public static string Kangoroo(int x1, int v1, int x2, int v2)
        {
            if (x1 < 0 || x2 < 0)
            {
                return ErrorMessage.InitialPositionToLow;
            }

            if (x1 > 10000 || x2 > 10000)
            {
                return ErrorMessage.InitialPositionToHigh;
            }

            if (v1 * v2 <= 0)
            {
                return ErrorMessage.SpeedToLow;
            }
            if(v1>10000 || v2>10000)
            {
                return ErrorMessage.SpeedToHigh;
            }
            if(x1>x2){
                return ErrorMessage.FirstKangorooShouldHaveSmallerInitialPosition;
            }

            do
            {
                x1+=v1;
                x2+=v2;
                if(x1==x2)
                {
                    return "YES";
                }
            }
            while (x1<x2);

            return "NO";
        }
    }

    public static class ErrorMessage
    {
        static string _errorStart = "The following errors happened: " + Environment.NewLine;
        public static string InitialPositionToLow { get; } = _errorStart + "The initial positions should be greater than or equal to 0.";
        public static string InitialPositionToHigh { get; } = _errorStart + "The initial positions should be smaller than or equal to 10000.";
        public static string SpeedToLow { get; } = _errorStart + "The distance should be greater than or equal 1.";
        public static string SpeedToHigh { get; } = _errorStart + "The distance should be smaller than or equal 10000.";
        public static string FirstKangorooShouldHaveSmallerInitialPosition { get; } = _errorStart + "The first kangoroo should have smaller initial position than the second one";

    }


}
