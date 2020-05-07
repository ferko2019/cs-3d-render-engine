using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    public class _3DObject
    {
        public Face[] faces = new Face[0];
        public Vector[] verticies = new Vector[0];
        public string name = "unknown";
        public string path = "C:\\";
        public Vector pos = new Vector() { x = 0, y = 0, z = 0 };
        public Vector rotation = new Vector() { x = 0, y = 0, z = 0 };
        public Vector scale = new Vector() { x = 1, y = 1, z = 1 };
    }
}
