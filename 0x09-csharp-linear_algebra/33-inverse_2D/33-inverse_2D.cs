using System;
using System.Collections.Generic;

///<summary>A VectorMath class</summary>
class MatrixMath
{
    ///<summary>Calculates the inverse of a 2D matrix and returns the resulting matrix</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] matrixError = new double[,] {{-1}};
        double aux;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            aux = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            
            if (aux == 0)
                return matrixError;

            double[,] matrixResult = new double[,] {
                {(1 / aux) * matrix[1, 1], (1 / aux) * -matrix[0, 1]},
                {(1 / aux) * -matrix[1, 0], (1 / aux) * matrix[0, 0]},
            };
            return matrixResult;
        }
        return matrixError;
    }
}
