using System;
using System.Collections.Generic;

///<summary>A VectorMath class</summary>
class VectorMath
{
    ///<summary>Multiplies a vector and a scalar and returns the resulting vector</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] vectorResult = new double[1] {-1};

        if (vector.Length == 2)
        {
            vectorResult = new double[2] {vector[0] * scalar, vector[1] * scalar};
        }
        else if (vector.Length == 3)
        {
            vectorResult = new double[3] {vector[0] * scalar, vector[1] * scalar, vector[2] * scalar};
        }
        return vectorResult;
    }
}
