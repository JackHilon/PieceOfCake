using System;

namespace PieceOfCake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Piece of Cake!
            // https://open.kattis.com/problems/pieceofcake2 
            // simple numerical program - max area

            Console.WriteLine(MaxVolumeCalculation(Enter3Numbers()));
        }
        private static int MaxVolumeCalculation(int[] cake)
        {
            int thick = 4;

            int side = cake[0];
            double halfSide = Math.Ceiling((double)side / 2);
            int cut1 = cake[1];
            int cut2 = cake[2];

            if (cut1 < halfSide)
                cut1 = side - cut1;
            if (cut2 < halfSide)
                cut2 = side - cut2;

            return cut1 * cut2 * thick;
        }

        private static int[] Enter3Numbers()
        {
            string[] arr = new string[3] { "", "", "" };
            int[] res = new int[3] { 0, 0, 0 };
            try
            {
                arr = Console.ReadLine().Split(' ', 3);
                for (int i = 0; i < arr.Length; i++)
                {
                    res[i] = int.Parse(arr[i]);
                }
                if (Conditions(res) == false)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Enter3Numbers();
            }
            return res;
        }
        private static bool Conditions(int[] array)
        {
            int n = array[0];
            int h = array[1];
            int v = array[2];

            if (n < 2 || n > 10000)
                return false;
            else if (h <= 0 || h >= n)
                return false;
            else if (v <= 0 || v >= n)
                return false;
            else
                return true;
        }
    }
}
