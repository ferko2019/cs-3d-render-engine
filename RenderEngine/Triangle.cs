using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    class Triangle
    {
        Vector3 a, b, c;
        public static bool Intersect(Vector3 p1,Vector3 p2,Vector3 p3,Ray ray)
        {
            bool isIntersect = false;
            return isIntersect;
        }
        
        public Vector3 Normal
        {
            get
            {
                var dir = Vector3.Cross(b - a, c - a);
                var norm = Vector3.Normalize(dir);
                return norm;
            }
        }
    }
}
