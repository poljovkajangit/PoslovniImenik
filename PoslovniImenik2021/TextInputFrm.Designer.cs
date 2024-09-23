using System.Drawing;
using System.Windows.Forms;

namespace PoslovniImenik
{
    partial class TextInputFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._TbInput = new TextBox();
            this._BtnOdustani = new Button();
            this._BtnPrihvati = new Button();
            base.SuspendLayout();
            this._TbInput.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._TbInput.Location = new Point(12, 12);
            this._TbInput.Name = "_TbInput";
            this._TbInput.Size = new Size(0x10c, 0x16);
            this._TbInput.TabIndex = 0;
            this._BtnOdustani.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this._BtnOdustani.DialogResult = DialogResult.Cancel;
            this._BtnOdustani.Location = new Point(0xcd, 0x2f);
            this._BtnOdustani.Name = "_BtnOdustani";
            this._BtnOdustani.Size = new Size(0x4b, 0x17);
            this._BtnOdustani.TabIndex = 1;
            this._BtnOdustani.Text = "Odustani";
            this._BtnOdustani.UseVisualStyleBackColor = true;
            this._BtnPrihvati.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this._BtnPrihvati.DialogResult = DialogResult.OK;
            this._BtnPrihvati.Location = new Point(0x7c, 0x2f);
            this._BtnPrihvati.Name = "_BtnPrihvati";
            this._BtnPrihvati.Size = new Size(0x4b, 0x17);
            this._BtnPrihvati.TabIndex = 2;
            this._BtnPrihvati.Text = "Prihvati";
            this._BtnPrihvati.UseVisualStyleBackColor = true;
            base.AcceptButton = this._BtnPrihvati;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this._BtnOdustani;
            base.ClientSize = new Size(0x124, 0x52);
            base.Controls.Add(this._BtnPrihvati);
            base.Controls.Add(this._BtnOdustani);
            base.Controls.Add(this._TbInput);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "TextInputFrm";
            base.StartPosition = FormStartPosition.CenterScreen;
            base.ResumeLayout(false);
            base.PerformLayout();

        }

        #endregion
    }
}