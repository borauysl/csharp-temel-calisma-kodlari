using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Program
    {
        static void Main()
        {
            int[,] pageMatrix = new int[4, 4];
            int[] pageReferences = { 2, 1, 0, 3, 2, 1, 0 };
            int pageFaults = 0;

            for (int i = 0; i < pageReferences.Length; i++)
            {
                int pageNumber = pageReferences[i];
                bool pageFound = false;

                for (int row = 0; row < 4; row++)
                {
                    if (pageMatrix[row, pageNumber] == 1)
                    {
                        pageFound = true;
                        break;
                    }
                }

                if (!pageFound)
                {
                    pageFaults++;

                    int rowIndexToReplace = FindLRURow(pageMatrix, pageNumber);
                    for (int col = 0; col < 4; col++)
                    {
                        pageMatrix[rowIndexToReplace, col] = 0;
                    }

                    pageMatrix[rowIndexToReplace, pageNumber] = 1;
                }
            }

            Console.WriteLine("Page to be replaced: " + FindPageToReplace(pageMatrix));
            Console.WriteLine("Page Faults: " + pageFaults);
            Console.ReadLine();
        }

        static int FindLRURow(int[,] pageMatrix, int pageNumber)
        {
            int rowIndexToReplace = 0;
            int minAccessIndex = int.MaxValue;

            for (int row = 0; row < 4; row++)
            {
                int lastAccessIndex = GetLastAccessIndex(pageMatrix, row, pageNumber);
                if (lastAccessIndex < minAccessIndex)
                {
                    minAccessIndex = lastAccessIndex;
                    rowIndexToReplace = row;
                }
            }

            return rowIndexToReplace;
        }

        static int GetLastAccessIndex(int[,] pageMatrix, int rowIndex, int pageNumber)
        {
            for (int col = 3; col >= 0; col--)
            {
                if (pageMatrix[rowIndex, col] == 1)
                {
                    return col;
                }
            }

            return -1;
        }

        static int FindPageToReplace(int[,] pageMatrix)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (pageMatrix[row, col] == 0)
                    {
                        return col;
                    }
                }
            }

            return -1;
        }
        
        

    }
}
