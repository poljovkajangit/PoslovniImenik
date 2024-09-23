using System;
using System.Drawing;
using System.Windows.Forms;

namespace PoslovniImenik
{
    partial class FPromenaFrm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.label1 = new Label();
            this._DtDatum = new DateTimePicker();
            this._TbOpis = new TextBox();
            this.label4 = new Label();
            this._BtnPrihvati = new Button();
            this._BtnOdustani = new Button();
            this.panel1 = new Panel();
            this._TbPotrazuje = new TextBox();
            this.label5 = new Label();
            this._TbDuguje = new TextBox();
            this.label3 = new Label();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2f, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum:";
            this._DtDatum.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._DtDatum.Format = DateTimePickerFormat.Short;
            this._DtDatum.Location = new Point(0x10, 0x1c);
            this._DtDatum.Name = "_DtDatum";
            this._DtDatum.Size = new Size(0x8f, 0x16);
            this._DtDatum.TabIndex = 0;
            this._TbOpis.AcceptsReturn = true;
            this._TbOpis.AcceptsTab = true;
            this._TbOpis.BorderStyle = BorderStyle.FixedSingle;
            this._TbOpis.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._TbOpis.Location = new Point(0x10, 160);
            this._TbOpis.Multiline = true;
            this._TbOpis.Name = "_TbOpis";
            this._TbOpis.ScrollBars = ScrollBars.Vertical;
            this._TbOpis.Size = new Size(0xef, 0x55);
            this._TbOpis.TabIndex = 4;
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(15, 0x91);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x22, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opis:";
            this._BtnPrihvati.DialogResult = DialogResult.OK;
            this._BtnPrihvati.Location = new Point(0x7f, 0x11d);
            this._BtnPrihvati.Name = "_BtnPrihvati";
            this._BtnPrihvati.Size = new Size(0x4b, 0x17);
            this._BtnPrihvati.TabIndex = 1;
            this._BtnPrihvati.Text = "Prihvati";
            this._BtnPrihvati.UseVisualStyleBackColor = true;
            this._BtnOdustani.DialogResult = DialogResult.Cancel;
            this._BtnOdustani.Location = new Point(0xd0, 0x11d);
            this._BtnOdustani.Name = "_BtnOdustani";
            this._BtnOdustani.Size = new Size(0x4b, 0x17);
            this._BtnOdustani.TabIndex = 2;
            this._BtnOdustani.Text = "Odustani";
            this._BtnOdustani.UseVisualStyleBackColor = true;
            this.panel1.BackColor = Color.WhiteSmoke;
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this._TbPotrazuje);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._TbDuguje);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this._DtDatum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._TbOpis);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x10f, 0x106);
            this.panel1.TabIndex = 0;
            this._TbPotrazuje.BorderStyle = BorderStyle.FixedSingle;
            this._TbPotrazuje.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._TbPotrazuje.Location = new Point(0x10, 0x74);
            this._TbPotrazuje.Name = "_TbPotrazuje";
            this._TbPotrazuje.Size = new Size(0x7f, 0x16);
            this._TbPotrazuje.TabIndex = 2;
            this._TbPotrazuje.Text = "0";
            this._TbPotrazuje.Enter += new EventHandler(this._TbPotrazuje_Enter);
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(14, 100);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x3e, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Potražuje:";
            this._TbDuguje.BorderStyle = BorderStyle.FixedSingle;
            this._TbDuguje.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._TbDuguje.Location = new Point(0x10, 0x48);
            this._TbDuguje.Name = "_TbDuguje";
            this._TbDuguje.Size = new Size(0x7f, 0x16);
            this._TbDuguje.TabIndex = 1;
            this._TbDuguje.Text = "0";
            this._TbDuguje.Enter += new EventHandler(this._TbDuguje_Enter);
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(13, 0x38);
            this.label3.Name = "label3";
            this.label3.Size = new Size(50, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duguje:";
            base.AcceptButton = this._BtnPrihvati;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this._BtnOdustani;
            base.ClientSize = new Size(0x127, 0x13f);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this._BtnOdustani);
            base.Controls.Add(this._BtnPrihvati);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FPromenaFrm";
            base.ShowIcon = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "_";
            base.FormClosing += new FormClosingEventHandler(this.FPromenaFrm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            base.ResumeLayout(false);

        }

        #endregion
    }
}