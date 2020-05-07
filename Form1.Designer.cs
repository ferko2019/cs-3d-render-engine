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
            Console.Text += "\n" + txt;
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
            ((System.ComponentModel.ISupportInitialize)(this.imageOutput)).BeginInit();
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
            this.renderButton.Location = new System.Drawing.Point(881, 37);
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
            this.progressBar.Value = 100;
            // 
            // objFilePath
            // 
            this.objFilePath.Font = new System.Drawing.Font("Dubai", 8.25F);
            this.objFilePath.Location = new System.Drawing.Point(957, 168);
            this.objFilePath.Name = "objFilePath";
            this.objFilePath.Size = new System.Drawing.Size(200, 26);
            this.objFilePath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(832, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Object file path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(797, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Render setting path:";
            // 
            // renderSettingFilePath
            // 
            this.renderSettingFilePath.Font = new System.Drawing.Font("Dubai", 8.25F);
            this.renderSettingFilePath.Location = new System.Drawing.Point(957, 211);
            this.renderSettingFilePath.Name = "renderSettingFilePath";
            this.renderSettingFilePath.Size = new System.Drawing.Size(200, 26);
            this.renderSettingFilePath.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(881, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Console
            // 
            this.Console.Location = new System.Drawing.Point(801, 270);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(451, 244);
            this.Console.TabIndex = 9;
            // 
            // EngineUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
    }
}

