using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3D_Render_Engine_Whit_UI.RenderEngine;

namespace _3D_Render_Engine_Whit_UI
{
    public partial class EngineUi : Form
    {
        public EngineUi()
        {
            InitializeComponent();
        }

        public float fov = 60;
        public float near = 0.0001f;
        public float far = 100;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            _3DObject obj = ObjDecoder.LoadObj(objFilePath.Text,this);
            _3DObject[] objs = new _3DObject[1] { obj };
            imageOutput.Image = Rasterizer.Rasterize(1280, 720,objs, this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RenderSettingFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ObjFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void FovInput_ValueChanged(object sender, EventArgs e)
        {
            fov = (float)FovInput.Value;
        }

        private void NearInput_ValueChanged(object sender, EventArgs e)
        {
            near = (float)NearInput.Value;
        }

        private void FarInput_ValueChanged(object sender, EventArgs e)
        {
            far = (float)FarInput.Value;
        }
    }
}
