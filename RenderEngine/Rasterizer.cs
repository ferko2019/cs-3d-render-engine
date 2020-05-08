using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SimpleMatrix;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    class Rasterizer
    {
        public static Bitmap Rasterize(int width, int height,_3DObject[] objects,EngineUi form)
        {
            Size size = new Size(width, height);
            //Console.WriteLine(objects.Length);
            //Console.WriteLine(objects[0].verticies.Length);
            foreach (_3DObject obj in objects)
            {
                Vector pos = obj.pos;
                Vector rot = obj.rotation;
                Vector scale = obj.scale;
                foreach (Vector vert in obj.verticies)
                {
                    Console.WriteLine(Project(vert, pos, rot, scale, form.fov, form.near, form.far, 10,size));
                }
            }
            Bitmap image = new Bitmap(size.Width, size.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            return image;
        }

        public static Vector2 Project(Vector vert,Vector pos,Vector rot,Vector scale,float fov,float near,float far,int world_scale,Size resolution)
        {
            float S = 1 / ((float)Math.Tan((fov / 2) * (Math.PI / 180)));
            float aspect_ratio = resolution.Width / resolution.Height;
            float t = (float)Math.Tan((fov / 2)) * near;
            float b = -t;
            float r = t * aspect_ratio;
            float l = -t * aspect_ratio;
            float[,] projection_matrix = new float[4, 4] {
                { (2*near)/(r-1),0,0,0},
                {0,(2*near)/(t-b),0,0 },
                {(r+1)/(r-1),(t+b)/(t-b),-((far+near)/(far-near)),-1 },
                {0,0,-((2*far*near)/(far-near)),0 }
            };

            float[,] rotate_x_matrix = new float[3, 3]{
                {1,0,0 },
                {0,(float)Math.Cos(rot.x),(float)-Math.Sin(rot.x) },
                {0,(float)Math.Sin(rot.x),(float)Math.Cos(rot.x) }
            };

            float[,] rotate_y_matrix = new float[3, 3]{
                {(float)Math.Cos(rot.y),0,(float)Math.Sin(rot.y) },
                {0,1,0 },
                {(float)-Math.Sin(rot.y),0,(float)Math.Cos(rot.y) }
            };

            float[,] rotate_z_matrix = new float[3, 3]{
                {(float)Math.Cos(rot.z),(float)-Math.Sin(rot.z),0 },
                {(float)Math.Sin(rot.z),(float)Math.Cos(rot.z),0 },
                {0,0,1 }
            };

            vert = Vector.Multiply(vert, scale);
            vert = Vector.Add(vert,pos);
            Console.WriteLine(vert.Print());
            float[,] vert_matrix_3 = { { vert.x, vert.y, vert.z} };

            vert_matrix_3 = Matrix.Multiply(vert_matrix_3, rotate_x_matrix);
            vert_matrix_3 = Matrix.Multiply(vert_matrix_3, rotate_y_matrix);
            vert_matrix_3 = Matrix.Multiply(vert_matrix_3, rotate_z_matrix);

            float[,] vert_matrix_4 = { { vert_matrix_3[0, 0]/vert.w, vert_matrix_3[0, 1]/vert.w, vert_matrix_3[0, 2]/vert.w, 1 } };

            float[,] projected_matrix = Matrix.Multiply(vert_matrix_4, projection_matrix);

            Console.WriteLine(projected_matrix[0, 0] + " ; " + projected_matrix[0, 1] + " ; " + projected_matrix[0, 2] + " ; " + projected_matrix[0, 3] + ";" + projected_matrix.GetLength(0)+";"+projected_matrix.GetLength(1).ToString());

            Vector2 projected = new Vector2();
            projected.x = projected_matrix[0, 0] * world_scale;
            projected.y = projected_matrix[0, 1] * world_scale;
            return projected;
        }
    }
}