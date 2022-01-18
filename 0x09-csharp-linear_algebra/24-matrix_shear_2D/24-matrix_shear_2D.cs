using System;
using System.Collections.Generic;

///<summary>A VectorMath class</summary>
class MatrixMath
{
    ///<summary>Shears a square 2D matrix by a given shear factor and returns the resulting matrix</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] shear = new double[2, 2] {{1, 0}, {0, 1}};
        double[,] matrixError = new double[,] {{-1}};
        double[,] matrixResult = new double[2, 2];
        double aux;

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return matrixError;
        if (direction == 'x')
            shear[1, 0] = factor;
        else if (direction == 'y')
            shear[0, 1] = factor;
        else
            return matrixError;

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
            {
                aux = 0;
                for (int k = 0; k < 2; k++)
                    aux += Math.Round(matrix[i, k] * shear[k, j], 2);
                matrixResult[i ,j] = aux;
            }
        return matrixResult;
    }
}
