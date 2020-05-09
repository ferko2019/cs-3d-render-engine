using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    class Math3D
    {

        public static Vector3 crossProduct(Vector3 a,Vector3 b)
        {
            float x, y, z;
            x = a.Y * b.Z - b.Y * a.Z;
            y = (a.X * b.Z - b.X * a.Z) * -1;
            z = a.X * b.Y - b.X * a.Y;
            Vector3 rtnVector = new Vector3(x,y,z);
            return rtnVector;
        }

        public static Vector3 Ava(Vector3[] vectors)
        {
            Vector3 res = new Vector3();
            foreach (Vector3 vec in vectors)
            {
                res += vec;
            }
            res /= vectors.Length;
            return res;
        }
    }
}
