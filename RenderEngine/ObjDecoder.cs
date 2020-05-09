using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3D_Render_Engine_Whit_UI.RenderEngine;
using System.Windows.Forms;
using System.Numerics;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    class ObjDecoder
    {
        public static _3DObject LoadObj(string path, EngineUi form)
        {
            _3DObject obj = new _3DObject();
            obj.pos = new Vector3(0, 0, 0);
            obj.rotation = new Vector3(0, 0, 0);
            obj.scale = new Vector3(1, 1, 1);
            if(path.Length == 0)
            {
                form.ConsolePrint("No path specified!");
                return null;
            }
            string[] raw_file = File.ReadAllLines(Directory.GetCurrentDirectory()+path);
            List<Vector3> vertices = new List<Vector3>();
            List<Vector3> normlas = new List<Vector3>();
            List<int> raw_faces = new List<int>();
            List<int> raw_normals = new List<int>();
            foreach (string row in raw_file)
            {
                string[] row_splitted = row.Split(' ');
                if (row_splitted[0].Contains("o"))
                {
                    obj.name = row_splitted[1];
                }else if (row_splitted[0] == "v")
                {
                    //form.ConsolePrint(row);
                    float x = float.Parse(row_splitted[1].Replace('.',','));
                    float y = float.Parse(row_splitted[2].Replace('.', ','));
                    float z = float.Parse(row_splitted[3].Replace('.', ','));
                    vertices.Add(new Vector3(x,y,z));
                    //form.ConsolePrint(row_splitted[0] + "||" + row_splitted[1] + "||" + row_splitted[2] + "||"+row_splitted[3]);
                    Console.WriteLine("Vertex loaded");
                }else if (row_splitted[0].Contains("vn"))
                {
                    float x = float.Parse(row_splitted[1].Replace('.', ','));
                    float y = float.Parse(row_splitted[2].Replace('.', ','));
                    float z = float.Parse(row_splitted[3].Replace('.', ','));
                    normlas.Add(new Vector3(x,y,z));
                    //form.ConsolePrint(row_splitted[0] + "||" + row_splitted[1] + "||" + row_splitted[2] + "||"+row_splitted[3]);
                    Console.WriteLine("Normal loaded");
                }
                else if (row_splitted[0].Contains("f"))
                {
                    string face_data0 = row_splitted[1];
                    string face_data1 = row_splitted[2];
                    string face_data2 = row_splitted[3];
                    int a = Int32.Parse(face_data0.Split('/')[0]);
                    int b = Int32.Parse(face_data1.Split('/')[0]);
                    int c = Int32.Parse(face_data2.Split('/')[0]);
                    raw_faces.Add(a);
                    raw_faces.Add(b);
                    raw_faces.Add(c);
                    int an = Int32.Parse(face_data0.Split('/')[2]);
                    int bn = Int32.Parse(face_data1.Split('/')[2]);
                    int cn = Int32.Parse(face_data2.Split('/')[2]);
                    raw_normals.Add(an);
                    raw_normals.Add(bn);
                    raw_normals.Add(cn);
                    Console.WriteLine(a + "/" + b + "/" + c);
                    Console.WriteLine(an + "/" + bn + "/" + cn);
                }
            }
            Face[] faces = new Face[raw_faces.Count / 3];
            for (int i = 0; i < raw_faces.Count-1; i+= 3)
            {
                Vector3[] normals = new Vector3[3] { vertices[raw_normals[i] - 1], vertices[raw_normals[i + 1] - 1], vertices[raw_normals[i] - 1 + 2] };
                Face face = new Face() { a = vertices[raw_faces[i]-1], b = vertices[raw_faces[i + 1]-1], c = vertices[raw_faces[i + 2]-1] ,aNormal = normals[0], bNormal = normals[1], cNormal = normals[2], normal = Math3D.Ava(normals) };
                faces[i / 3] = face;
                Console.WriteLine(face.a+"||" + face.b + "||" + face.c+ "||" + face.aNormal + "||" + face.bNormal + "||" + face.cNormal+"||"+face.normal);
            }
            obj.faces = faces;
            obj.verticies = vertices.ToArray();
            obj.path = path;
            obj.scale = new Vector3(1,1,1);
            return obj;
        }
    }
}