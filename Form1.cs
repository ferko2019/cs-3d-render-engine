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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            ObjDecoder.LoadObj(objFilePath.Text,this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
