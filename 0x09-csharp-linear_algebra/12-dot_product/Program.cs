using System;
using System.Collections.Generic;

///<summary>A VectorMath class</summary>
class VectorMath
{
    ///<summary>Calculates dot product of either two 2D or two 3D vectors</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double dot = -1;

        if (vector1.Length == 2 && vector2.Length == 2)
        {
            dot = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]);
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            dot = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]);
        }
        return dot;
    }
}
