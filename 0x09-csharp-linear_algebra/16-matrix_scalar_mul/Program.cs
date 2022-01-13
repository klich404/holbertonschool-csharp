using System;
using System.Collections.Generic;

///<summary>A VectorMath class</summary>
class VectorMath
{
    ///<summary>Multiplies a matrix and a scalar and returns the resulting matrix</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] matrixError = new double[,] {{-1}};
        int height = matrix.GetLength(0);
        int width = matrix.GetLength(1);

        if (height1 == 2 && width1 == 2 && height1 == height2 && width1 == width2)
        {
            for (int x = 0; x < height; x++)
                for (int y = 0; y < width; y++)
                    matrix[x, y] = matrix[x, y] * scalar;
            return matrix;
        }
        else if (height1 == 3 && width1 == 3 && height1 == height2 && width1 == width2)
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
