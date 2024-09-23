using PoslovniImenik.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PoslovniImenik
{
    partial class UCTelefoni
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
            this.label1 = new System.Windows.Forms.Label();
            this._BtnDodajTelefon = new PoslovniImenik.VistaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefoni";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _BtnDodajTelefon
            // 
            this._BtnDodajTelefon.BackColor = System.Drawing.Color.Transparent;
            this._BtnDodajTelefon.BaseColor = System.Drawing.Color.White;
            this._BtnDodajTelefon.ButtonColor = System.Drawing.Color.Gray;
            this._BtnDodajTelefon.ButtonText = null;
            this._BtnDodajTelefon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._BtnDodajTelefon.GlowColor = System.Drawing.SystemColors.ActiveBorder;
            this._BtnDodajTelefon.Image = global::PoslovniImenik.Properties.Resources.add;
            this._BtnDodajTelefon.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._BtnDodajTelefon.ImageSize = new System.Drawing.Size(16, 16);
            this._BtnDodajTelefon.Location = new System.Drawing.Point(5, 278);
            this._BtnDodajTelefon.Name = "_BtnDodajTelefon";
            this._BtnDodajTelefon.Size = new System.Drawing.Size(241, 32);
            this._BtnDodajTelefon.TabIndex = 0;
            this._BtnDodajTelefon.Click += new System.EventHandler(this._BtnDodajTelefon_Click);
            // 
            // UCTelefoni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this._BtnDodajTelefon);
            this.Name = "UCTelefoni";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(251, 315);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
