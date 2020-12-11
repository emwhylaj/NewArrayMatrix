using System;

namespace newArrayMatrix
{
    internal class DeterminantAndMatrices
    {
        private static void Main(string[] args)
        {
            try
            {   // inputing the dimesions of the matrix

                Console.WriteLine("*********************** Welcome to the determinant and squared matrix calculator********************");
                Console.WriteLine("Provide the  desired value");
                int firstValue = int.Parse(Console.ReadLine());

                Console.WriteLine("Provide the  desired value");
                int secondValue = int.Parse(Console.ReadLine());

                Console.WriteLine("Provide the  desired value");
                int thirdValue = int.Parse(Console.ReadLine());

                Console.WriteLine("Provide the  desired value");
                int fourthValue = int.Parse(Console.ReadLine());
                if (thirdValue != fourthValue)
                {
                    Console.WriteLine("The number row and column must be this same to calculate the determinant");
                }

                int[,,,] matrixArray = new int[firstValue, secondValue, thirdValue, fourthValue];

                for (int i = 0; i < firstValue; i++)
                {
                    for (int j = 0; j < secondValue; j++)
                    {
                        for (int k = 0; k < thirdValue; k++)
                        {
                            for (int l = 0; l < fourthValue; l++)
                            {
                                Console.WriteLine("Please enter elements in the matrix[{0},{1},{2},{3}]", i, j, k, l);
                                matrixArray[i, j, k, l] = int.Parse(Console.ReadLine());
                            }
                        }
                    }
                }

                Console.WriteLine();

                // Calculating the determinant: Using Crammer's Rule

                if (thirdValue == fourthValue)
                {
                    int firstElement = matrixArray[0, 0, 0, 0] * (((matrixArray[0, 0, 1, 3] * matrixArray[0, 0, 2, 1] * matrixArray[0, 0, 3, 2] + matrixArray[0, 0, 1, 2] * matrixArray[0, 0, 2, 3] * matrixArray[0, 0, 3, 1] + matrixArray[0, 0, 1, 1] * matrixArray[0, 0, 2, 2] * matrixArray[0, 0, 3, 3]) -
                        (matrixArray[0, 0, 1, 2] * matrixArray[0, 0, 2, 1] * matrixArray[0, 0, 3, 3] + matrixArray[0, 0, 1, 1] * matrixArray[0, 0, 2, 3] * matrixArray[0, 0, 3, 2] + matrixArray[0, 0, 1, 3] * matrixArray[0, 0, 2, 2] * matrixArray[0, 0, 3, 1])));

                    int secondElement = matrixArray[0, 0, 0, 1] * (((matrixArray[0, 0, 1, 3] * matrixArray[0, 0, 2, 0] * matrixArray[0, 0, 3, 2] + matrixArray[0, 0, 1, 2] * matrixArray[0, 0, 2, 3] * matrixArray[0, 0, 3, 0] + matrixArray[0, 0, 1, 0] * matrixArray[0, 0, 2, 2] * matrixArray[0, 0, 3, 3]) -
                        (matrixArray[0, 0, 1, 2] * matrixArray[0, 0, 2, 0] * matrixArray[0, 0, 3, 3] + matrixArray[0, 0, 1, 0] * matrixArray[0, 0, 2, 3] * matrixArray[0, 0, 3, 2] + matrixArray[0, 0, 1, 3] * matrixArray[0, 0, 2, 2] * matrixArray[0, 0, 3, 0])));

                    int thirdElement = matrixArray[0, 0, 0, 2] * (((matrixArray[0, 0, 1, 3] * matrixArray[0, 0, 2, 0] * matrixArray[0, 0, 3, 1] + matrixArray[0, 0, 1, 1] * matrixArray[0, 0, 2, 3] * matrixArray[0, 0, 3, 0] + matrixArray[0, 0, 1, 0] * matrixArray[0, 0, 2, 1] * matrixArray[0, 0, 3, 3]) -
                       (matrixArray[0, 0, 1, 1] * matrixArray[0, 0, 2, 0] * matrixArray[0, 0, 3, 3] + matrixArray[0, 0, 1, 0] * matrixArray[0, 0, 2, 3] * matrixArray[0, 0, 3, 1] + matrixArray[0, 0, 1, 3] * matrixArray[0, 0, 2, 1] * matrixArray[0, 0, 3, 0])));

                    int fourthElement = matrixArray[0, 0, 0, 3] * (((matrixArray[0, 0, 1, 2] * matrixArray[0, 0, 2, 0] * matrixArray[0, 0, 3, 1] + matrixArray[0, 0, 1, 1] * matrixArray[0, 0, 2, 2] * matrixArray[0, 0, 3, 0] + matrixArray[0, 0, 1, 0] * matrixArray[0, 0, 2, 1] * matrixArray[0, 0, 3, 2]) -
                        (matrixArray[0, 0, 1, 2] * matrixArray[0, 0, 2, 1] * matrixArray[0, 0, 3, 0] + matrixArray[0, 0, 1, 0] * matrixArray[0, 0, 2, 2] * matrixArray[0, 0, 3, 1] + matrixArray[0, 0, 1, 1] * matrixArray[0, 0, 2, 0] * matrixArray[0, 0, 3, 2])));

                    int results = firstElement - secondElement + thirdElement - fourthElement;
                    Console.WriteLine($"The determinant of the matrix is : {results} and the square is given below");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }

                int[,,,] squareResult = new int[firstValue, secondValue, thirdValue, fourthValue];
                for (int i = 0; i < matrixArray.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixArray.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrixArray.GetLength(2); k++)
                        {
                            for (int l = 0; l < matrixArray.GetLength(3); l++)
                            {
                                squareResult[i, j, k, l] = 0;
                                for (int m = 0; m < thirdValue; m++)
                                {
                                    squareResult[i, j, k, l] += matrixArray[i, j, k, m] * matrixArray[i, j, m, l];
                                }
                            }
                        }
                    }
                }

                // Displaying the square of the Matrix

                for (int i = 0; i < matrixArray.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixArray.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrixArray.GetLength(2); k++)
                        {
                            for (int l = 0; l < matrixArray.GetLength(3); l++)
                            {
                                Console.Write(squareResult[i, j, k, l] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}