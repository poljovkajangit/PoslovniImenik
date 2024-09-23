using PoslovniImenik.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PoslovniImenik
{
    partial class UCKontakt
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
            this.components = new System.ComponentModel.Container();
            this._BsKontakt = new System.Windows.Forms.BindingSource(this.components);
            this._TbNaziv = new System.Windows.Forms.TextBox();
            this._TbPrezimeIme = new System.Windows.Forms.TextBox();
            this._TbMesto = new System.Windows.Forms.TextBox();
            this._TbAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._TbPib = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._LnkEmail = new System.Windows.Forms.LinkLabel();
            this._LnkWeb = new System.Windows.Forms.LinkLabel();
            this._TbDelatnost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._LbTelefoni = new System.Windows.Forms.ListBox();
            this._BsTelefoni = new System.Windows.Forms.BindingSource(this.components);
            this._TbNapomena = new System.Windows.Forms.TextBox();
            this._BtnPodsetnik = new PoslovniImenik.VistaButton();
            this.vistaButton1 = new PoslovniImenik.VistaButton();
            this._TbDrzava = new System.Windows.Forms.TextBox();
            this.vistaButton2 = new PoslovniImenik.VistaButton();
            this._CloseBtn = new PoslovniImenik.VistaButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDokumenta = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this._BsKontakt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BsTelefoni)).BeginInit();
            this.SuspendLayout();
            // 
            // _BsKontakt
            // 
            this._BsKontakt.DataSource = typeof(PoslovniImenik.KontaktPreview);
            // 
            // _TbNaziv
            // 
            this._TbNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TbNaziv.BackColor = System.Drawing.SystemColors.Control;
            this._TbNaziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._BsKontakt, "Naziv", true));
            this._TbNaziv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbNaziv.Location = new System.Drawing.Point(9, 6);
            this._TbNaziv.Name = "_TbNaziv";
            this._TbNaziv.ReadOnly = true;
            this._TbNaziv.Size = new System.Drawing.Size(306, 23);
            this._TbNaziv.TabIndex = 0;
            // 
            // _TbPrezimeIme
            // 
            this._TbPrezimeIme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TbPrezimeIme.BackColor = System.Drawing.SystemColors.Control;
            this._TbPrezimeIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbPrezimeIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._BsKontakt, "PrezimeIme", true));
            this._TbPrezimeIme.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbPrezimeIme.Location = new System.Drawing.Point(9, 33);
            this._TbPrezimeIme.Name = "_TbPrezimeIme";
            this._TbPrezimeIme.ReadOnly = true;
            this._TbPrezimeIme.Size = new System.Drawing.Size(340, 21);
            this._TbPrezimeIme.TabIndex = 1;
            // 
            // _TbMesto
            // 
            this._TbMesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TbMesto.BackColor = System.Drawing.SystemColors.Control;
            this._TbMesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbMesto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._BsKontakt, "Mesto", true));
            this._TbMesto.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbMesto.Location = new System.Drawing.Point(9, 83);
            this._TbMesto.Name = "_TbMesto";
            this._TbMesto.ReadOnly = true;
            this._TbMesto.Size = new System.Drawing.Size(340, 21);
            this._TbMesto.TabIndex = 3;
            // 
            // _TbAdresa
            // 
            this._TbAdresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TbAdresa.BackColor = System.Drawing.SystemColors.Control;
            this._TbAdresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._BsKontakt, "Adresa", true));
            this._TbAdresa.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbAdresa.Location = new System.Drawing.Point(9, 58);
            this._TbAdresa.Name = "_TbAdresa";
            this._TbAdresa.ReadOnly = true;
            this._TbAdresa.Size = new System.Drawing.Size(340, 21);
            this._TbAdresa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fax:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._BsKontakt, "Fax", true));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(70, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 5;
            // 
            // _TbPib
            // 
            this._TbPib.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TbPib.BackColor = System.Drawing.SystemColors.Control;
            this._TbPib.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbPib.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._BsKontakt, "PIB", true));
            this._TbPib.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbPib.Location = new System.Drawing.Point(70, 178);
            this._TbPib.Name = "_TbPib";
            this._TbPib.ReadOnly = true;
            this._TbPib.Size = new System.Drawing.Size(279, 20);
            this._TbPib.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "PIB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Web:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // _LnkEmail
            // 
            this._LnkEmail.AutoSize = true;
            this._LnkEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._BsKontakt, "Email", true));
            this._LnkEmail.Location = new System.Drawing.Point(67, 205);
            this._LnkEmail.Name = "_LnkEmail";
            this._LnkEmail.Size = new System.Drawing.Size(55, 13);
            this._LnkEmail.TabIndex = 10;
            this._LnkEmail.TabStop = true;
            this._LnkEmail.Text = "linkLabel1";
            this._LnkEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._LnkEmail_LinkClicked);
            // 
            // _LnkWeb
            // 
            this._LnkWeb.AutoSize = true;
            this._LnkWeb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._BsKontakt, "Web", true));
            this._LnkWeb.Location = new System.Drawing.Point(67, 227);
            this._LnkWeb.Name = "_LnkWeb";
            this._LnkWeb.Size = new System.Drawing.Size(55, 13);
            this._LnkWeb.TabIndex = 11;
            this._LnkWeb.TabStop = true;
            this._LnkWeb.Text = "linkLabel2";
            this._LnkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._LnkWeb_LinkClicked);
            // 
            // _TbDelatnost
            // 
            this._TbDelatnost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TbDelatnost.BackColor = System.Drawing.SystemColors.Control;
            this._TbDelatnost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbDelatnost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._BsKontakt, "Delatnost", true));
            this._TbDelatnost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbDelatnost.Location = new System.Drawing.Point(70, 134);
            this._TbDelatnost.Name = "_TbDelatnost";
            this._TbDelatnost.ReadOnly = true;
            this._TbDelatnost.Size = new System.Drawing.Size(279, 20);
            this._TbDelatnost.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Delatnost:";
            // 
            // _LbTelefoni
            // 
            this._LbTelefoni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._LbTelefoni.BackColor = System.Drawing.SystemColors.Control;
            this._LbTelefoni.DataSource = this._BsTelefoni;
            this._LbTelefoni.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LbTelefoni.FormattingEnabled = true;
            this._LbTelefoni.ItemHeight = 21;
            this._LbTelefoni.Location = new System.Drawing.Point(9, 280);
            this._LbTelefoni.Name = "_LbTelefoni";
            this._LbTelefoni.ScrollAlwaysVisible = true;
            this._LbTelefoni.Size = new System.Drawing.Size(340, 109);
            this._LbTelefoni.TabIndex = 14;
            // 
            // _TbNapomena
            // 
            this._TbNapomena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TbNapomena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._BsKontakt, "Napomena", true));
            this._TbNapomena.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbNapomena.Location = new System.Drawing.Point(9, 397);
            this._TbNapomena.Multiline = true;
            this._TbNapomena.Name = "_TbNapomena";
            this._TbNapomena.ReadOnly = true;
            this._TbNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._TbNapomena.Size = new System.Drawing.Size(340, 262);
            this._TbNapomena.TabIndex = 15;
            // 
            // _BtnPodsetnik
            // 
            this._BtnPodsetnik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnPodsetnik.BackColor = System.Drawing.SystemColors.Control;
            this._BtnPodsetnik.BaseColor = System.Drawing.Color.White;
            this._BtnPodsetnik.ButtonColor = System.Drawing.Color.DimGray;
            this._BtnPodsetnik.ButtonText = "Podsetnik";
            this._BtnPodsetnik.CornerRadius = 2;
            this._BtnPodsetnik.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BtnPodsetnik.ForeColor = System.Drawing.Color.Black;
            this._BtnPodsetnik.GlowColor = System.Drawing.Color.Silver;
            this._BtnPodsetnik.ImageSize = new System.Drawing.Size(16, 16);
            this._BtnPodsetnik.Location = new System.Drawing.Point(275, 667);
            this._BtnPodsetnik.Name = "_BtnPodsetnik";
            this._BtnPodsetnik.Size = new System.Drawing.Size(74, 37);
            this._BtnPodsetnik.TabIndex = 16;
            this._BtnPodsetnik.TabStop = false;
            this._BtnPodsetnik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._BtnPodsetnik.Click += new System.EventHandler(this._BtnPodsetnik_Click);
            // 
            // vistaButton1
            // 
            this.vistaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vistaButton1.BackColor = System.Drawing.SystemColors.Control;
            this.vistaButton1.BaseColor = System.Drawing.Color.White;
            this.vistaButton1.ButtonColor = System.Drawing.Color.DimGray;
            this.vistaButton1.ButtonText = "Izmeni";
            this.vistaButton1.CornerRadius = 2;
            this.vistaButton1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaButton1.ForeColor = System.Drawing.Color.Black;
            this.vistaButton1.GlowColor = System.Drawing.Color.Silver;
            this.vistaButton1.Image = global::PoslovniImenik.Properties.Resources.page_white_edit;
            this.vistaButton1.ImageSize = new System.Drawing.Size(16, 16);
            this.vistaButton1.Location = new System.Drawing.Point(9, 667);
            this.vistaButton1.Name = "vistaButton1";
            this.vistaButton1.Size = new System.Drawing.Size(70, 37);
            this.vistaButton1.TabIndex = 17;
            this.vistaButton1.TabStop = false;
            this.vistaButton1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.vistaButton1.Click += new System.EventHandler(this.vistaButton1_Click);
            // 
            // _TbDrzava
            // 
            this._TbDrzava.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TbDrzava.BackColor = System.Drawing.SystemColors.Control;
            this._TbDrzava.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbDrzava.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._BsKontakt, "Drzava", true));
            this._TbDrzava.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbDrzava.Location = new System.Drawing.Point(9, 108);
            this._TbDrzava.Name = "_TbDrzava";
            this._TbDrzava.ReadOnly = true;
            this._TbDrzava.Size = new System.Drawing.Size(340, 21);
            this._TbDrzava.TabIndex = 18;
            // 
            // vistaButton2
            // 
            this.vistaButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vistaButton2.BackColor = System.Drawing.SystemColors.Control;
            this.vistaButton2.BaseColor = System.Drawing.Color.White;
            this.vistaButton2.ButtonColor = System.Drawing.Color.DimGray;
            this.vistaButton2.ButtonText = "Obriši";
            this.vistaButton2.CornerRadius = 2;
            this.vistaButton2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaButton2.ForeColor = System.Drawing.Color.Black;
            this.vistaButton2.GlowColor = System.Drawing.Color.Silver;
            this.vistaButton2.Image = global::PoslovniImenik.Properties.Resources.page_white_edit;
            this.vistaButton2.ImageSize = new System.Drawing.Size(16, 16);
            this.vistaButton2.Location = new System.Drawing.Point(85, 667);
            this.vistaButton2.Name = "vistaButton2";
            this.vistaButton2.Size = new System.Drawing.Size(70, 37);
            this.vistaButton2.TabIndex = 19;
            this.vistaButton2.TabStop = false;
            this.vistaButton2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.vistaButton2.Click += new System.EventHandler(this.vistaButton2_Click);
            // 
            // _CloseBtn
            // 
            this._CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseBtn.BackColor = System.Drawing.SystemColors.Control;
            this._CloseBtn.BaseColor = System.Drawing.Color.White;
            this._CloseBtn.ButtonColor = System.Drawing.Color.DimGray;
            this._CloseBtn.ButtonText = "X";
            this._CloseBtn.CornerRadius = 2;
            this._CloseBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseBtn.ForeColor = System.Drawing.Color.Black;
            this._CloseBtn.GlowColor = System.Drawing.Color.Silver;
            this._CloseBtn.ImageSize = new System.Drawing.Size(16, 16);
            this._CloseBtn.Location = new System.Drawing.Point(317, 3);
            this._CloseBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._CloseBtn.Name = "_CloseBtn";
            this._CloseBtn.Size = new System.Drawing.Size(38, 26);
            this._CloseBtn.TabIndex = 20;
            this._CloseBtn.TabStop = false;
            this._CloseBtn.Click += new System.EventHandler(this._CloseBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "Folder sa dokumentima:";
            // 
            // lblDokumenta
            // 
            this.lblDokumenta.AutoSize = true;
            this.lblDokumenta.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this._BsKontakt, "FolderLocation", true));
            this.lblDokumenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDokumenta.Location = new System.Drawing.Point(141, 249);
            this.lblDokumenta.Name = "lblDokumenta";
            this.lblDokumenta.Size = new System.Drawing.Size(66, 20);
            this.lblDokumenta.TabIndex = 22;
            this.lblDokumenta.TabStop = true;
            this.lblDokumenta.Text = "Otvori ...";
            this.lblDokumenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDokumenta_LinkClicked);
            // 
            // UCKontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDokumenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._CloseBtn);
            this.Controls.Add(this.vistaButton2);
            this.Controls.Add(this._TbDrzava);
            this.Controls.Add(this.vistaButton1);
            this.Controls.Add(this._BtnPodsetnik);
            this.Controls.Add(this._TbNapomena);
            this.Controls.Add(this._LbTelefoni);
            this.Controls.Add(this._TbDelatnost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._LnkWeb);
            this.Controls.Add(this._LnkEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._TbPib);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._TbMesto);
            this.Controls.Add(this._TbAdresa);
            this.Controls.Add(this._TbPrezimeIme);
            this.Controls.Add(this._TbNaziv);
            this.Name = "UCKontakt";
            this.Size = new System.Drawing.Size(358, 707);
            ((System.ComponentModel.ISupportInitialize)(this._BsKontakt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BsTelefoni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VistaButton _CloseBtn;
        private Label label6;
        private LinkLabel lblDokumenta;
    }
}
