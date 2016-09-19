using System;

namespace CrackingTheCodingInterview
{
    class Chapter1
    {
        /* **************************************************************
         *          Rotate the given matrix by 90 degrees.
         * *************************************************************/

         private static int[,] RotateMatrix(int[,] mat)
         {
             // Missing: Check if matrix is null and create it in such case.
             // Also, make sure it is square.
             int dimension = mat.GetLength(0);
             var rotatedMatrix = new int[dimension, dimension];

             // Row i becomes column k where k = dimension - 1 - i.
             for  (int i = 0; i < dimension; i++)
             {
                 for (int j = 0; j < dimension; j++)
                 {
                     rotatedMatrix[j, dimension-i-1] = mat[i, j];
                 }
             }
             return rotatedMatrix;
         }

        /* **************************************************************
         *      Rotate the given matrix in place (i.e. without using
         *      additional structures.)
         * *************************************************************/

        private static void RotateMatrixInPlace(int[,] matrix)
        {
            // Missing: Check if matrix is null and create it in such case.
            // Also, make sure it is square.
            int dimension = matrix.GetLength(0);

            // Use a layer pattern going from outside to inside.
            for (int layer = 0; layer < (dimension / 2); layer++)
            {
                int start = layer;
                int end = dimension - layer - 1;

                for (int i = start; i < end; i++)
                {
                    int top = matrix[start, i];
                    int offset = i - start;

                    // Left to Top
                    matrix[start, i] = matrix[end-offset, start];

                    // Bottom to Left
                    matrix[end-offset, start] = matrix[end, end-offset];

                    // Right to Bottom
                    matrix[end, end-offset] = matrix[i, end];

                    // Top to Right
                    matrix[i, end] = top;
                }
            }
        }

        /* **************************************************************
         *                    Testing Main Method!!!
         * *************************************************************/

        static void Main(string[] args)
        {
            Console.WriteLine("If we rotate the following matrix by "
                                + "90 degrees, how will it be?");
            
            const int n = 4;
            int[,] matrix = new int[n, n] {{1, 2, 3, 4},
                                           {5, 6, 7, 8},
                                           {9, 10, 11, 12},
                                           {13, 14, 15, 16}};

            Console.WriteLine("\nOriginal Matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("[{0}]", matrix[i, j]);
                    if (j < n - 1) Console.Write("\t");
                }
                Console.Write("\n");
            }

            RotateMatrixInPlace(matrix);
            Console.WriteLine("\nRotated Matrix in Place:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("[{0}]", matrix[i, j]);
                    if (j < n - 1) Console.Write("\t");
                }
                Console.Write("\n");
            }

            matrix = RotateMatrix(matrix);
            Console.WriteLine("\nWe rotate it once more, but by creating "
                                + "an additional matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("[{0}]", matrix[i, j]);
                    if (j < n - 1) Console.Write("\t");
                }
                Console.Write("\n");
            }
        }
    }
}
