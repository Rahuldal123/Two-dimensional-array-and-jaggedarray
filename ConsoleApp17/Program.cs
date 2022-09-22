using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)

            // WAP to find maxmum and Minimum number from  two dimensional array
        {
            int[,] arr = new int[3, 4] {
                                        {10,20,30,40},
                                        { 60,90,10,100},
                                        { 80,110,120,55}
            };
            int maxvalue = arr[0, 0];
            int minimumvalue = arr[0, 0];
            for (int i = 0; i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    int num = arr[i, j];

                    if (num > maxvalue)
                        maxvalue = num;
                    if (num < minimumvalue)
                        minimumvalue = num;
                }
               
            }
            Console.WriteLine($"lowest number is{minimumvalue}");
            Console.WriteLine($"maximum number is{maxvalue}");

            // Jagged Array

            int[][] jaggeArray = new int[3][];

            jaggeArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggeArray[1] = new int[] { 1, 2, 3 };
            jaggeArray[2] = new int[] { 1, 2 };

            for(int i =0;i<jaggeArray.GetLength(0);i++)
            {
                for(int j = 0; j < jaggeArray[i].Length;j++)
                {
                    Console.Write(jaggeArray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
