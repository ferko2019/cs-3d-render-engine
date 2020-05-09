using _3D_Render_Engine_Whit_UI.RenderEngine;

namespace _3D_Render_Engine_Whit_UI
{
    partial class EngineUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        public void ConsolePrint(string txt)
        {
            Console.Text += "\n"+txt;
        }

        private void InitializeComponent()
        {
            this.imageOutput = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.renderButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.objFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.renderSettingFilePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Console = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FovInput = new System.Windows.Forms.NumericUpDown();
            this.NearInput = new System.Windows.Forms.NumericUpDown();
            this.FarInput = new System.Windows.Forms.NumericUpDown();
            this.EngineSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NearInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarInput)).BeginInit();
            this.SuspendLayout();
            // 
            // imageOutput
            // 
            this.imageOutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imageOutput.Location = new System.Drawing.Point(18, 34);
            this.imageOutput.Name = "imageOutput";
            this.imageOutput.Size = new System.Drawing.Size(720, 480);
            this.imageOutput.TabIndex = 0;
            this.imageOutput.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.MaximumSize = new System.Drawing.Size(100, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Render:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // renderButton
            // 
            this.renderButton.Location = new System.Drawing.Point(881, 11);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(276, 44);
            this.renderButton.TabIndex = 2;
            this.renderButton.Text = "Render Image";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(18, 525);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1234, 23);
            this.progressBar.TabIndex = 3;
            // 
            // objFilePath
            // 
            this.objFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.objFilePath.Location = new System.Drawing.Point(957, 142);
            this.objFilePath.Name = "objFilePath";
            this.objFilePath.Size = new System.Drawing.Size(200, 20);
            this.objFilePath.TabIndex = 4;
            this.objFilePath.Text = "\\Objects\\cube.obj";
            this.objFilePath.TextChanged += new System.EventHandler(this.ObjFilePath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(832, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Object file path:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(797, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Render setting path:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // renderSettingFilePath
            // 
            this.renderSettingFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.renderSettingFilePath.Location = new System.Drawing.Point(957, 185);
            this.renderSettingFilePath.Name = "renderSettingFilePath";
            this.renderSettingFilePath.Size = new System.Drawing.Size(200, 20);
            this.renderSettingFilePath.TabIndex = 7;
            this.renderSettingFilePath.TextChanged += new System.EventHandler(this.RenderSettingFilePath_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(881, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Console
            // 
            this.Console.AutoSize = true;
            this.Console.Location = new System.Drawing.Point(802, 256);
            this.Console.MaximumSize = new System.Drawing.Size(354, 1000);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(0, 13);
            this.Console.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1084, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(798, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fov:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(894, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Near:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(1024, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Far:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // FovInput
            // 
            this.FovInput.Location = new System.Drawing.Point(837, 219);
            this.FovInput.Name = "FovInput";
            this.FovInput.Size = new System.Drawing.Size(51, 20);
            this.FovInput.TabIndex = 14;
            this.FovInput.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.FovInput.ValueChanged += new System.EventHandler(this.FovInput_ValueChanged);
            // 
            // NearInput
            // 
            this.NearInput.Location = new System.Drawing.Point(948, 218);
            this.NearInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.NearInput.Name = "NearInput";
            this.NearInput.Size = new System.Drawing.Size(70, 20);
            this.NearInput.TabIndex = 15;
            this.NearInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.NearInput.ValueChanged += new System.EventHandler(this.NearInput_ValueChanged);
            // 
            // FarInput
            // 
            this.FarInput.Location = new System.Drawing.Point(1067, 218);
            this.FarInput.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.FarInput.Name = "FarInput";
            this.FarInput.Size = new System.Drawing.Size(76, 20);
            this.FarInput.TabIndex = 16;
            this.FarInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.FarInput.ValueChanged += new System.EventHandler(this.FarInput_ValueChanged);
            // 
            // EngineSelect
            // 
            this.EngineSelect.FormattingEnabled = true;
            this.EngineSelect.Items.AddRange(new object[] {
            "Rasterize",
            "Raytracer"});
            this.EngineSelect.Location = new System.Drawing.Point(882, 106);
            this.EngineSelect.Name = "EngineSelect";
            this.EngineSelect.Size = new System.Drawing.Size(260, 21);
            this.EngineSelect.TabIndex = 17;
            this.EngineSelect.Text = "Select Engine";
            // 
            // EngineUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 593);
            this.Controls.Add(this.EngineSelect);
            this.Controls.Add(this.FarInput);
            this.Controls.Add(this.NearInput);
            this.Controls.Add(this.FovInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.renderSettingFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.objFilePath);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.renderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageOutput);
            this.Name = "EngineUi";
            this.Text = "Render Engine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NearInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox objFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox renderSettingFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Console;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown FovInput;
        private System.Windows.Forms.NumericUpDown NearInput;
        private System.Windows.Forms.NumericUpDown FarInput;
        private System.Windows.Forms.ComboBox EngineSelect;
    }
}

