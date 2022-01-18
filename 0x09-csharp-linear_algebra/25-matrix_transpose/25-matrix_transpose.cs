using System;
using System.Collections.Generic;

///<summary>A VectorMath class</summary>
class MatrixMath
{
    ///<summary>Transpose a matrix and return the resulting matrix</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] matrixError = new double[,] {{-1}};
        double height = matrix.GetLength(0);
        double width = matrix.GetLength(1);
        double[,] matrixResult = new double[width, height];

        for (int i = 0; i < width; i++)
            for (int j = 0; j < height; j++)
                matrixResult[i, j] = matrix[j, i];
        return matrixResult;
    }
}
