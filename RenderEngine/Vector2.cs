using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    class Vector2
    {
        public float x;
        public float y;

        public static Vector2 Add(Vector2 a, Vector2 b)
        {
            return new Vector2() { x = a.x + b.x, y = a.y + b.y};
        }

        public static Vector2 Sub(Vector2 a, Vector2 b)
        {
            return new Vector2() { x = a.x - b.x, y = a.y - b.y};
        }

        public static Vector2 Multiply(Vector2 a, Vector2 b)
        {
            return new Vector2() { x = a.x * b.x, y = a.y * b.y};
        }

        public static Vector2 Multiply(Vector2 a, float b)
        {
            return new Vector2() { x = a.x * b, y = a.y * b};
        }

        public static Vector2 ZERO()
        {
            return new Vector2() { x = 0, y = 0};
        }

        public static Vector2 Ava(Vector[] vectors)
        {
            Vector2 avarange = new Vector2();
            float x = 0;
            float y = 0;
            foreach (Vector vector in vectors)
            {
                x += vector.x;
                y += vector.y;
            }
            avarange.x = x / vectors.Length;
            avarange.y = y / vectors.Length;
            return avarange;
        }

        public string Print()
        {
            return x + @"\/" + y;
        }
    }
}
