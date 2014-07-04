﻿namespace Tile_Engine
{
    partial class Screen
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
        private void InitializeComponent()
        {
            this.DrawScreen = new Tile_Engine.DBPanel();
            this.SuspendLayout();
            // 
            // DrawScreen
            // 
            this.DrawScreen.BackColor = System.Drawing.Color.White;
            this.DrawScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrawScreen.Location = new System.Drawing.Point(0, 0);
            this.DrawScreen.Name = "DrawScreen";
            this.DrawScreen.Size = new System.Drawing.Size(700, 700);
            this.DrawScreen.TabIndex = 0;
            this.DrawScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.Redraw);
            this.DrawScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClick);
            this.DrawScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoved);
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 699);
            this.Controls.Add(this.DrawScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Screen";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnExit);
            this.ResumeLayout(false);

        }

        #endregion

        private DBPanel DrawScreen;

    }
}

