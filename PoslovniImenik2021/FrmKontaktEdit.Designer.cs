using PoslovniImenik.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace PoslovniImenik
{
    partial class FrmKontaktEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKontaktEdit));
            this._BtnSave = new PoslovniImenik.VistaButton();
            this._BtnSledeci = new PoslovniImenik.VistaButton();
            this._PnlMainPanel = new PoslovniImenik.PanelPlus();
            this._LnkPodesiFolder = new System.Windows.Forms.LinkLabel();
            this._TbFolder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._TbDrzava = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ucTelefoni1 = new PoslovniImenik.UCTelefoni();
            this._TbPrezimeIme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._TbDelatnost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this._TbPIB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._TbWeb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._TbNapomena = new System.Windows.Forms.TextBox();
            this._TbEmail = new System.Windows.Forms.TextBox();
            this._TbFax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._TbMesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._TbAdresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._TbNaziv = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.Label();
            this._PnlMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _BtnSave
            // 
            this._BtnSave.BackColor = System.Drawing.Color.Transparent;
            this._BtnSave.BaseColor = System.Drawing.Color.White;
            this._BtnSave.ButtonColor = System.Drawing.Color.Gray;
            this._BtnSave.ButtonText = "Sačuvaj (F2)";
            this._BtnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BtnSave.ForeColor = System.Drawing.Color.Black;
            this._BtnSave.GlowColor = System.Drawing.Color.Khaki;
            this._BtnSave.Image = global::PoslovniImenik.Properties.Resources.accept;
            this._BtnSave.ImageSize = new System.Drawing.Size(16, 16);
            this._BtnSave.Location = new System.Drawing.Point(850, 558);
            this._BtnSave.Name = "_BtnSave";
            this._BtnSave.Size = new System.Drawing.Size(110, 44);
            this._BtnSave.TabIndex = 1;
            this._BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BtnSave.Click += new System.EventHandler(this._BtnSave_Click);
            // 
            // _BtnSledeci
            // 
            this._BtnSledeci.BackColor = System.Drawing.Color.Transparent;
            this._BtnSledeci.BaseColor = System.Drawing.Color.White;
            this._BtnSledeci.ButtonColor = System.Drawing.Color.Gray;
            this._BtnSledeci.ButtonText = "Dodaj sledeći";
            this._BtnSledeci.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BtnSledeci.ForeColor = System.Drawing.Color.Black;
            this._BtnSledeci.GlowColor = System.Drawing.Color.Khaki;
            this._BtnSledeci.Location = new System.Drawing.Point(12, 558);
            this._BtnSledeci.Name = "_BtnSledeci";
            this._BtnSledeci.Size = new System.Drawing.Size(107, 44);
            this._BtnSledeci.TabIndex = 3;
            this._BtnSledeci.Visible = false;
            this._BtnSledeci.Click += new System.EventHandler(this._BtnSledeci_Click);
            // 
            // _PnlMainPanel
            // 
            this._PnlMainPanel.AngleRadius = 8;
            this._PnlMainPanel.BackColor = System.Drawing.Color.Transparent;
            this._PnlMainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_PnlMainPanel.BackgroundImage")));
            this._PnlMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._PnlMainPanel.BorderColor = System.Drawing.Color.Gray;
            this._PnlMainPanel.Controls.Add(this._LnkPodesiFolder);
            this._PnlMainPanel.Controls.Add(this._TbFolder);
            this._PnlMainPanel.Controls.Add(this.label8);
            this._PnlMainPanel.Controls.Add(this._TbDrzava);
            this._PnlMainPanel.Controls.Add(this.label5);
            this._PnlMainPanel.Controls.Add(this.ucTelefoni1);
            this._PnlMainPanel.Controls.Add(this._TbPrezimeIme);
            this._PnlMainPanel.Controls.Add(this.label7);
            this._PnlMainPanel.Controls.Add(this._TbDelatnost);
            this._PnlMainPanel.Controls.Add(this.label14);
            this._PnlMainPanel.Controls.Add(this._TbPIB);
            this._PnlMainPanel.Controls.Add(this.label9);
            this._PnlMainPanel.Controls.Add(this.label3);
            this._PnlMainPanel.Controls.Add(this._TbWeb);
            this._PnlMainPanel.Controls.Add(this.label1);
            this._PnlMainPanel.Controls.Add(this._TbNapomena);
            this._PnlMainPanel.Controls.Add(this._TbEmail);
            this._PnlMainPanel.Controls.Add(this._TbFax);
            this._PnlMainPanel.Controls.Add(this.label6);
            this._PnlMainPanel.Controls.Add(this._TbMesto);
            this._PnlMainPanel.Controls.Add(this.label4);
            this._PnlMainPanel.Controls.Add(this._TbAdresa);
            this._PnlMainPanel.Controls.Add(this.label2);
            this._PnlMainPanel.Controls.Add(this._TbNaziv);
            this._PnlMainPanel.Controls.Add(this.Naziv);
            this._PnlMainPanel.EndColor = System.Drawing.Color.LightGray;
            this._PnlMainPanel.Location = new System.Drawing.Point(11, 12);
            this._PnlMainPanel.Name = "_PnlMainPanel";
            this._PnlMainPanel.Size = new System.Drawing.Size(940, 540);
            this._PnlMainPanel.StartColor = System.Drawing.Color.White;
            this._PnlMainPanel.TabIndex = 0;
            // 
            // _LnkPodesiFolder
            // 
            this._LnkPodesiFolder.AutoSize = true;
            this._LnkPodesiFolder.Location = new System.Drawing.Point(229, 445);
            this._LnkPodesiFolder.Name = "_LnkPodesiFolder";
            this._LnkPodesiFolder.Size = new System.Drawing.Size(51, 13);
            this._LnkPodesiFolder.TabIndex = 42;
            this._LnkPodesiFolder.TabStop = true;
            this._LnkPodesiFolder.Text = "Podesi ...";
            this._LnkPodesiFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._LnkPodesiFolder_LinkClicked);
            // 
            // _TbFolder
            // 
            this._TbFolder.BackColor = System.Drawing.Color.LightGray;
            this._TbFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbFolder.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbFolder.Location = new System.Drawing.Point(19, 445);
            this._TbFolder.MaxLength = 254;
            this._TbFolder.Name = "_TbFolder";
            this._TbFolder.ReadOnly = true;
            this._TbFolder.Size = new System.Drawing.Size(205, 15);
            this._TbFolder.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Folder sa dokumentima:";
            // 
            // _TbDrzava
            // 
            this._TbDrzava.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbDrzava.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbDrzava.Location = new System.Drawing.Point(18, 198);
            this._TbDrzava.Name = "_TbDrzava";
            this._TbDrzava.Size = new System.Drawing.Size(260, 15);
            this._TbDrzava.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Država:";
            // 
            // ucTelefoni1
            // 
            this.ucTelefoni1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucTelefoni1.Location = new System.Drawing.Point(709, 28);
            this.ucTelefoni1.Name = "ucTelefoni1";
            this.ucTelefoni1.Padding = new System.Windows.Forms.Padding(5);
            this.ucTelefoni1.Size = new System.Drawing.Size(211, 498);
            this.ucTelefoni1.TabIndex = 11;
            // 
            // _TbPrezimeIme
            // 
            this._TbPrezimeIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbPrezimeIme.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbPrezimeIme.Location = new System.Drawing.Point(18, 72);
            this._TbPrezimeIme.MaxLength = 254;
            this._TbPrezimeIme.Name = "_TbPrezimeIme";
            this._TbPrezimeIme.Size = new System.Drawing.Size(260, 15);
            this._TbPrezimeIme.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Prezime i ime:";
            // 
            // _TbDelatnost
            // 
            this._TbDelatnost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbDelatnost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbDelatnost.Location = new System.Drawing.Point(18, 400);
            this._TbDelatnost.MaxLength = 254;
            this._TbDelatnost.Name = "_TbDelatnost";
            this._TbDelatnost.Size = new System.Drawing.Size(260, 15);
            this._TbDelatnost.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Delatnost:";
            // 
            // _TbPIB
            // 
            this._TbPIB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbPIB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbPIB.Location = new System.Drawing.Point(18, 359);
            this._TbPIB.Name = "_TbPIB";
            this._TbPIB.Size = new System.Drawing.Size(260, 15);
            this._TbPIB.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "PIB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Web sajt:";
            // 
            // _TbWeb
            // 
            this._TbWeb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbWeb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbWeb.Location = new System.Drawing.Point(18, 321);
            this._TbWeb.Name = "_TbWeb";
            this._TbWeb.Size = new System.Drawing.Size(260, 15);
            this._TbWeb.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Email:";
            // 
            // _TbNapomena
            // 
            this._TbNapomena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbNapomena.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbNapomena.Location = new System.Drawing.Point(300, 29);
            this._TbNapomena.Multiline = true;
            this._TbNapomena.Name = "_TbNapomena";
            this._TbNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._TbNapomena.Size = new System.Drawing.Size(400, 497);
            this._TbNapomena.TabIndex = 10;
            // 
            // _TbEmail
            // 
            this._TbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbEmail.Location = new System.Drawing.Point(18, 280);
            this._TbEmail.Name = "_TbEmail";
            this._TbEmail.Size = new System.Drawing.Size(260, 15);
            this._TbEmail.TabIndex = 6;
            // 
            // _TbFax
            // 
            this._TbFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbFax.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbFax.Location = new System.Drawing.Point(18, 240);
            this._TbFax.Name = "_TbFax";
            this._TbFax.Size = new System.Drawing.Size(260, 15);
            this._TbFax.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fax:";
            // 
            // _TbMesto
            // 
            this._TbMesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbMesto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbMesto.Location = new System.Drawing.Point(18, 155);
            this._TbMesto.Name = "_TbMesto";
            this._TbMesto.Size = new System.Drawing.Size(260, 15);
            this._TbMesto.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mesto:";
            // 
            // _TbAdresa
            // 
            this._TbAdresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbAdresa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbAdresa.Location = new System.Drawing.Point(18, 114);
            this._TbAdresa.Name = "_TbAdresa";
            this._TbAdresa.Size = new System.Drawing.Size(260, 15);
            this._TbAdresa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresa:";
            // 
            // _TbNaziv
            // 
            this._TbNaziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._TbNaziv.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TbNaziv.Location = new System.Drawing.Point(18, 29);
            this._TbNaziv.Name = "_TbNaziv";
            this._TbNaziv.Size = new System.Drawing.Size(260, 15);
            this._TbNaziv.TabIndex = 0;
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naziv.Location = new System.Drawing.Point(13, 13);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(37, 13);
            this.Naziv.TabIndex = 0;
            this.Naziv.Text = "Naziv:";
            // 
            // FrmKontaktEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 611);
            this.Controls.Add(this._BtnSave);
            this.Controls.Add(this._BtnSledeci);
            this.Controls.Add(this._PnlMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKontaktEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_kontakt_";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KonPlEditFrm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this._PnlMainPanel.ResumeLayout(false);
            this._PnlMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private TextBox _TbFolder;
        private Label label8;
        private LinkLabel _LnkPodesiFolder;
    }
}