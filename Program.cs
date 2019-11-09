using System;

namespace HourglassArray
{

    class Program
    {
        private static int[][] Input =
            new int[][]
            {
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 2, 4, 4, 0 },
                new int[] { 0, 0, 0, 2, 0, 0 },
                new int[] { 0, 0, 1, 2, 4, 0 },
            };

        // A B C D E F G H I J K L M N O P
        // 0 1 2 3 4 5 6 7 8 9 A B C D E F
        private static int[][][] Map = new int[][][]
        {
            new int[][] { new[] { 0 }, new[] { 0, 1 }, new[] { 0, 1,2 }, new[] { 1,2,3 }, new[] { 3,2 }, new[] { 3 }  },
            new int[][] { new[] { 4 }, new[] { 0, 4, 5 }, new[] { 1, 4, 5, 5 }, new[] { 2, 5, 6, 7 }, new[] { 3, 6, 7 }, new[] { 7 }  },
            new int[][] { new[] { 0,8 }, new[] { 0, 1, 4,8,9 }, new[] {0,1,2,5,8,9,10 }, new[] { 1,2,3,6,9,10,11 }, new[] { 2,3,7,10,11 }, new[] { 3,11 }  },
            new int[][] { new[] { 4,12 }, new[] { 4,5,8,12,13 }, new[] { 4,5,6,9,12,13,14}, new[] { 5,6,7,10,13,14,15 }, new[] {6,7,11,14,15}, new[] { 7,15 }  },
            new int[][] { new[] { 8 }, new[] { 8,9,12 }, new[] {8,9,10,13 }, new[] { 9, 10, 11, 14 }, new[] {10,11,15}, new[] { 11 }  },
            new int[][] { new[] {12 }, new[] { 12,13 }, new[] { 12,13,14 }, new[] {15,14,13 }, new[] { 14,15 }, new[] { 15 }  },
        };

        private static int[] Hourglasses = new int[16];
        static void Main(string[] args)
        {
            for (int Row = 0; Row < Input.Length; Row++)
            {

                for (int Column = 0; Column < Input.Length; Column++)
                {
                    foreach(int glass in Map[Row][Column])
                    {
                        Hourglasses[glass] += Input[Row][Column];   
                    }
                }
            }

            int GreatestIndex = 0;
            for (int i = 0; i < Hourglasses.Length; i++)
            {
                if(Hourglasses[i] > Hourglasses[GreatestIndex])
                {
                    GreatestIndex = i;
                }
            }
            Console.WriteLine(Hourglasses[GreatestIndex]);
        }
    }
}
