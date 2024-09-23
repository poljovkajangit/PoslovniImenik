using System;
using System.Drawing;
using System.Windows.Forms;

namespace PoslovniImenik
{
    partial class VistaButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            base.Name = "VistaButton";
            base.Size = new Size(100, 0x20);
            base.Paint += new PaintEventHandler(this.VistaButton_Paint);
            base.KeyUp += new KeyEventHandler(this.VistaButton_KeyUp);
            base.KeyDown += new KeyEventHandler(this.VistaButton_KeyDown);
            base.MouseEnter += new EventHandler(this.VistaButton_MouseEnter);
            base.MouseLeave += new EventHandler(this.VistaButton_MouseLeave);
            base.MouseUp += new MouseEventHandler(this.VistaButton_MouseUp);
            base.MouseDown += new MouseEventHandler(this.VistaButton_MouseDown);
            base.GotFocus += new EventHandler(this.VistaButton_MouseEnter);
            base.LostFocus += new EventHandler(this.VistaButton_MouseLeave);
            base.Resize += new EventHandler(this.VistaButton_Resize);

        }

        #endregion
    }
}
