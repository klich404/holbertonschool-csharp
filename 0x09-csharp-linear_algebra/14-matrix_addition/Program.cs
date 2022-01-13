using System;
using System.Collections.Generic;

///<summary>A VectorMath class</summary>
class VectorMath
{
    ///<summary>Adds two matrices and returns the resulting matrix</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] matrixResult;
        double[,] matrixError = new double[,] {{-1}};
        int height1 = matrix1.GetLength(0);
        int width1 = matrix1.GetLength(1);
        int height2 = matrix2.GetLength(0);
        int width2 = matrix2.GetLength(1);

        if (height1 == 2 && width1 == 2 && height1 == height2 && width1 == width2)
            matrixResult = new double[2, 2];
        else if (height1 == 3 && width1 == 3 && height1 == height2 && width1 == width2)
            matrixResult = new double[3, 3];
        else
            return matrixError;

        for (int x = 0; x < height1; x++)
            for (int y = 0; y < width1; y++)
                matrixResult[x, y] = matrix1[x, y] + matrix2[x, y];
        return matrixResult;
    }
}
