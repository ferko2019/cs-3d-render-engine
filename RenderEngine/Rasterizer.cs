using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SimpleMatrix;
using System.Numerics;

namespace _3D_Render_Engine_Whit_UI.RenderEngine
{
    class Rasterizer
    {
        public static Bitmap Rasterize(int width, int height,_3DObject[] objects,EngineUi form)
        {
            Size size = new Size(width, height);
            Vector2 offset = new Vector2(width/2,height/2);
            //Console.WriteLine(objects.Length);
            //Console.WriteLine(objects[0].verticies.Length);
            Bitmap image = new Bitmap(size.Width, size.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            foreach (_3DObject obj in objects)
            {
                Vector3 pos = obj.pos;
                Vector3 rot = obj.rotation;
                Vector3 scale = obj.scale;
                foreach (Vector3 vert in obj.verticies)
                {
                    Vector2 projected = Project(vert, pos, rot, scale, form.fov, form.near, form.far, 10,size);
                    image.SetPixel((int)Math.Round(projected.X + offset.X), (int)Math.Round(projected.Y + offset.Y), Color.Red);
                }
            }
            return image;
        }

        public static Vector2 Project(Vector3 vert,Vector3 pos,Vector3 rot,Vector3 scale,float fov,float near,float far,int world_scale,Size resolution)
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

            double[,] ortho_phojection_matrix = new double[2,3] {
                {1,0,0},
                {0,1,0 }
            };

            float[,] rotate_x_matrix = new float[3, 3]{
                {1,0,0 },
                {0,(float)Math.Cos(rot.X),(float)-Math.Sin(rot.X) },
                {0,(float)Math.Sin(rot.X),(float)Math.Cos(rot.X) }
            };

            float[,] rotate_y_matrix = new float[3, 3]{
                {(float)Math.Cos(rot.Y),0,(float)Math.Sin(rot.Y) },
                {0,1,0 },
                {(float)-Math.Sin(rot.Y),0,(float)Math.Cos(rot.Y) }
            };

            float[,] rotate_z_matrix = new float[3, 3]{
                {(float)Math.Cos(rot.Z),(float)-Math.Sin(rot.Z),0 },
                {(float)Math.Sin(rot.Z),(float)Math.Cos(rot.Z),0 },
                {0,0,1 }
            };

            vert = vert * scale;
            vert = vert + pos;
            Console.WriteLine(vert);
            float[,] vert_matrix_3 = new float[1,3]{ { vert.X, vert.Y, vert.Z} };

            vert_matrix_3 = Matrix.Multiply(vert_matrix_3, rotate_x_matrix);
            vert_matrix_3 = Matrix.Multiply(vert_matrix_3, rotate_y_matrix);
            vert_matrix_3 = Matrix.Multiply(vert_matrix_3, rotate_z_matrix);

            double[,] vert_matrix_3_2 = new double[3, 1] { { vert_matrix_3[0, 0] }, { vert_matrix_3[0, 1] }, { vert_matrix_3[0, 2] } };

            //float[,] projected_matrix = new float[3, 1];//Matrix.Multiply(ortho_phojection_matrix,vert_matrix_3_2);

            SimpleMatrix.Matrix vert_matrix_3_2_matrix = new SimpleMatrix.Matrix(vert_matrix_3_2);
            SimpleMatrix.Matrix ortho_projection = new SimpleMatrix.Matrix(ortho_phojection_matrix);

            SimpleMatrix.Matrix projected_matrix = ortho_projection * vert_matrix_3_2_matrix;

            //Console.WriteLine(projected_matrix[0, 0] + " ; " + projected_matrix[0, 1] + " ; " + projected_matrix[0, 2] + ";" + projected_matrix.Rows+";"+projected_matrix.Columns.ToString());
            //Console.WriteLine(projected_matrix[0, 0] + " ; " + projected_matrix[0, 1] + " ; " + projected_matrix[0, 2] + " ; " + projected_matrix[0, 3] + ";" + projected_matrix.GetLength(0)+";"+projected_matrix.GetLength(1).ToString());

            Vector2 projected = new Vector2();
            projected.X = (float)projected_matrix[0, 0] * world_scale;
            projected.Y = (float)projected_matrix[1, 0] * world_scale;
            return projected;
        }
    }
}