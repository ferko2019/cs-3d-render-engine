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
            obj.pos = new Vector() { x = 0, y = 0, z = 0 };
            obj.rotation = new Vector() { x = 0, y = 0, z = 0 };
            obj.scale = new Vector() { x = 1, y = 1, z = 1 };
            string[] raw_file = File.ReadAllLines(path);
            List<Vector> vertices = new List<Vector>();
            foreach (string row in raw_file)
            {
                string[] row_splitted = row.Split(' ');
                if (row_splitted[0].Contains("o"))
                {
                    obj.name = row_splitted[2];
                }else if (row_splitted[0].Contains("v"))
                {

                }else if (row_splitted[0].Contains("vn"))
                {

                }else if (row_splitted[0].Contains("f"))
                {

                }
            }
            return obj;
        }
    }
}
