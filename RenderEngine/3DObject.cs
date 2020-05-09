using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    public class _3DObject
    {
        public Face[] faces = new Face[0];
        public Vector3[] verticies = new Vector3[0];
        public string name = "unknown";
        public string path = "C:\\";
        public Vector3 pos = new Vector3(0, 0, 0);
        public Vector3 rotation = new Vector3(0,0,0);
        public Vector3 scale = new Vector3(1, 1, 1);
    }
}
