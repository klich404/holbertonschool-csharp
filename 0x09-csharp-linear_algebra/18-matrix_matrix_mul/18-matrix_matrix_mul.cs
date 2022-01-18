using System;
using System.Collections.Generic;

///<summary>A VectorMath class</summary>
class MatrixMath
{
    ///<summary>Multiplies two matrices and returns the resulting matrix</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] matrixError = new double[,] {{-1}};
        double[,] matrixResult;
        int height = matrix1.GetLength(1);
        int width = matrix2.GetLength(0);
        double aux;

        if (height == width)
            matrixResult = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        else
            return matrixError;

        for (int i = 0; i < matrixResult.GetLength(0); i++)
            for (int j = 0; j < matrixResult.GetLength(1); j++)
            {
                aux = 0;
                for (int k = 0; k < height; k++)
                    aux += matrix1[i, k] * matrix2[k, j];
                matrixResult[i ,j] = aux;
            }
        return matrixResult;
    }
}
