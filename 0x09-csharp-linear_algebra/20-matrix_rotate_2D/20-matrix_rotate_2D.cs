using System;
using System.Collections.Generic;

///<summary>A VectorMath class</summary>
class MatrixMath
{
    ///<summary>Rotates a square 2D matrix by a given angle in radians and returns the resulting matrix</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] rotation = new double[2, 2] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        double[,] matrixError = new double[,] {{-1}};
        double[,] matrixResult = new double[2, 2];
        double aux;

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return matrixError;

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
            {
                aux = 0;
                for (int k = 0; k < 2; k++)
                    aux += Math.Round(matrix[i, k] * rotation[k, j], 2);
                matrixResult[i ,j] = aux;
            }
        return matrixResult;
    }
}
