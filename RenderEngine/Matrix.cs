using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    class Matrix
    {
        public static float[,] Multiply(float[,] matrixA, float[,] matrixB)
        {
            if(matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                Console.WriteLine("Illegal matrix dimensions!");
                return null;
            }
            float[,] resoult = new float[matrixA.GetLength(0),matrixB.GetLength(1)];

            for (int i = 0; i < resoult.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(0); j++)
                {
                    for (int k = 0; k < matrixA.GetLength(1); k++)
                    {
                        resoult[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return resoult;
        }
    }
}
