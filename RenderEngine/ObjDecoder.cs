using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3D_Render_Engine_Whit_UI.RenderEngine;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    class ObjDecoder
    {
        public static _3DObject LoadObj(string path, EngineUi form)
        {
            _3DObject obj = new _3DObject();
            string[] raw_file = File.ReadAllLines(path);
            foreach (string row in raw_file)
            {
                form.ConsolePrint(row);
            }
            return obj;
        }
    }
}
