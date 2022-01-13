using System;
using System.Collections.Generic;

///<summary>A VectorMath class</summary>
class VectorMath
{
    ///<summary>Adds two vectors and returns the resulting vector</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] vectorResult = new double[1] {-1};

        if (vector1.Length == 2 && vector2.Length == 2)
        {
            vectorResult = new double[2] {vector1[0] + vector2[0], vector1[1] + vector2[1]};
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            vectorResult = new double[3] {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2]};
        }
        return vectorResult;
    }
}
