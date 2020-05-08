using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    public class Vector
    {
        public float x = 0;
        public float y = 0;
        public float z = 0;
        public float w = 1;

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

        public static Vector Multiply(Vector a, float b)
        {
            return new Vector() { x = a.x * b, y = a.y * b, z = a.z * b };
        }

        public static Vector ZERO()
        {
            return new Vector() { x = 0, y = 0, z = 0 };
        }

        public static Vector Ava(Vector[] vectors)
        {
            Vector avarange = new Vector();
            float x = 0;
            float y = 0;
            float z = 0;
            foreach (Vector vector in vectors)
            {
                x += vector.x;
                y += vector.y;
                z += vector.z;
            }
            avarange.x = x / vectors.Length;
            avarange.y = y / vectors.Length;
            avarange.z = z / vectors.Length;
            return avarange;
        }

        public string Print()
        {
            return x + @"\/" + y + @"\/" + z;
        }
    }
}
