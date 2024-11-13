using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArray
{
    internal class SumRC
    {
        static void Main(string[] args)
        {
            int[,] arr =
            {
                {2,3,4},
                {3,5,6},
                {5,3,2}

            };
            int row=arr.GetLength(0);
            int col=arr.GetLength(1);
            int[,] matrix = new int[3, 3];
            int[]rowsum=new int[3];
            int [] Colsum = new int[3];


           
            for (int i = 0; i<row; i++)
            {
                for (int j = 0; j< col; j++)
                {
                    rowsum[i] = rowsum[i]+arr[i,j];
                    Colsum[j] +=Colsum[j]+ arr[i,j];
                }
            }
            Console.WriteLine("sum of rows:");
            for(int i=0; i<row;i++)
            {
                Console.WriteLine(rowsum[i]);
            }
            Console.WriteLine("sum of Col:");

            for (int j = 0; j < col; j++)
            {
                Console.WriteLine(Colsum[j]);
            }
        }
    }
}
