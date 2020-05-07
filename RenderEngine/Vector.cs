using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    public class Vector
    {
        public float x;
        public float y;
        public float z;

        public static Vector Add(Vector a, Vector b)
        {
            return new Vector() { x = a.x + b.x, y = a.y + b.y, z = a.z + b.z };
        }

        public static Vector Sub(Vector a, Vector b)
        {
            return new Vector() { x = a.x - b.x, y = a.y - b.y, z = a.z - b.z };
        }

        public static Vector Multiply(Vector a, Vector b)
        {
            return new Vector() { x = a.x * b.x, y = a.y * b.y, z = a.z * b.z };
        }

        public static Vector Multiply(Vector a, int b)
        {
            return new Vector() { x = a.x * b, y = a.y * b, z = a.z * b };
        }

        public static Vector ZERO()
        {
            return new Vector() { x = 0, y = 0, z = 0 };
        }
    }
}
