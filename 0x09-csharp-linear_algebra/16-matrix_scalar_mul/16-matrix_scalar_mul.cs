using System;
using System.Collections.Generic;

///<summary>A VectorMath class</summary>
class MatrixMath
{
    ///<summary>Multiplies a matrix and a scalar and returns the resulting matrix</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] matrixError = new double[,] {{-1}};
        int height = matrix.GetLength(0);
        int width = matrix.GetLength(1);

        if (height == 2 && width == 2)
        {
            for (int x = 0; x < height; x++)
                for (int y = 0; y < width; y++)
                    matrix[x, y] = matrix[x, y] * scalar;
            return matrix;
        }
        else if (height == 3 && width == 3)
        {
            for (int x = 0; x < height; x++)
                for (int y = 0; y < width; y++)
                    matrix[x, y] = matrix[x, y] * scalar;
            return matrix;
        }
        else
            return matrixError;
    }
}
