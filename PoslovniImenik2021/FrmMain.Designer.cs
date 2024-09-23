using PoslovniImenik.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PoslovniImenik
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._MnuGrupe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promeniNazivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this._ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ucKontakt1 = new PoslovniImenik.UCKontakt();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._PnlSearch = new PoslovniImenik.PanelPlus();
            this.ucSuggestions1 = new PoslovniImenik.UCSuggestions();
            this._ImgSearch = new System.Windows.Forms.PictureBox();
            this.panel1 = new PoslovniImenik.PanelPlus();
            this._DgGrupe = new System.Windows.Forms.DataGridView();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._BsGrupe = new System.Windows.Forms.BindingSource(this.components);
            this._BtnDodaj = new PoslovniImenik.VistaButton();
            this._LabGrupeMenu = new System.Windows.Forms.Label();
            this.panelPlus1 = new PoslovniImenik.PanelPlus();
            this._DgKontakti = new System.Windows.Forms.DataGridView();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._BsKontakti = new System.Windows.Forms.BindingSource(this.components);
            this._LabGrupa = new System.Windows.Forms.Label();
            this._MnuGrupe.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this._PnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ImgSearch)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DgGrupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BsGrupe)).BeginInit();
            this.panelPlus1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DgKontakti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BsKontakti)).BeginInit();
            this.SuspendLayout();
            // 
            // _MnuGrupe
            // 
            this._MnuGrupe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajGrupuToolStripMenuItem,
            this.promeniNazivToolStripMenuItem,
            this.obrišiToolStripMenuItem});
            this._MnuGrupe.Name = "_MnuFizickaLica";
            this._MnuGrupe.Size = new System.Drawing.Size(150, 70);
            // 
            // dodajGrupuToolStripMenuItem
            // 
            this.dodajGrupuToolStripMenuItem.Image = global::PoslovniImenik.Properties.Resources.add;
            this.dodajGrupuToolStripMenuItem.Name = "dodajGrupuToolStripMenuItem";
            this.dodajGrupuToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.dodajGrupuToolStripMenuItem.Text = "Dodaj grupu";
            this.dodajGrupuToolStripMenuItem.Click += new System.EventHandler(this.dodajGrupuToolStripMenuItem_Click);
            // 
            // promeniNazivToolStripMenuItem
            // 
            this.promeniNazivToolStripMenuItem.Image = global::PoslovniImenik.Properties.Resources.page_white_edit;
            this.promeniNazivToolStripMenuItem.Name = "promeniNazivToolStripMenuItem";
            this.promeniNazivToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.promeniNazivToolStripMenuItem.Text = "Promeni naziv";
            this.promeniNazivToolStripMenuItem.Click += new System.EventHandler(this.promeniNazivToolStripMenuItem_Click);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Image = global::PoslovniImenik.Properties.Resources.cross;
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.obrišiToolStripMenuItem.Text = "Obriši grupu";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this._ProgressBar);
            this.panel2.Location = new System.Drawing.Point(12, 738);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1253, 20);
            this.panel2.TabIndex = 7;
            // 
            // _ProgressBar
            // 
            this._ProgressBar.Location = new System.Drawing.Point(3, 3);
            this._ProgressBar.Name = "_ProgressBar";
            this._ProgressBar.Size = new System.Drawing.Size(978, 14);
            this._ProgressBar.TabIndex = 0;
            this._ProgressBar.Visible = false;
            // 
            // ucKontakt1
            // 
            this.ucKontakt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucKontakt1.BackColor = System.Drawing.SystemColors.Control;
            this.ucKontakt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucKontakt1.Location = new System.Drawing.Point(810, 12);
            this.ucKontakt1.Name = "ucKontakt1";
            this.ucKontakt1.Size = new System.Drawing.Size(460, 723);
            this.ucKontakt1.TabIndex = 5;
            this.ucKontakt1.TabStop = false;
            this.ucKontakt1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(810, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 723);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // _PnlSearch
            // 
            this._PnlSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_PnlSearch.BackgroundImage")));
            this._PnlSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._PnlSearch.BorderColor = System.Drawing.SystemColors.ControlDark;
            this._PnlSearch.Controls.Add(this.ucSuggestions1);
            this._PnlSearch.Controls.Add(this._ImgSearch);
            this._PnlSearch.EndColor = System.Drawing.SystemColors.Control;
            this._PnlSearch.GradinetMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this._PnlSearch.Location = new System.Drawing.Point(12, 12);
            this._PnlSearch.Name = "_PnlSearch";
            this._PnlSearch.Size = new System.Drawing.Size(785, 56);
            this._PnlSearch.StartColor = System.Drawing.Color.White;
            this._PnlSearch.TabIndex = 0;
            this._PnlSearch.TabStop = true;
            // 
            // ucSuggestions1
            // 
            this.ucSuggestions1.BackColor = System.Drawing.Color.White;
            this.ucSuggestions1.Location = new System.Drawing.Point(57, 15);
            this.ucSuggestions1.Name = "ucSuggestions1";
            this.ucSuggestions1.Selected = null;
            this.ucSuggestions1.Size = new System.Drawing.Size(712, 27);
            this.ucSuggestions1.SuggestedValue = "";
            this.ucSuggestions1.TabIndex = 2;
            // 
            // _ImgSearch
            // 
            this._ImgSearch.BackColor = System.Drawing.Color.Transparent;
            this._ImgSearch.Image = global::PoslovniImenik.Properties.Resources.search;
            this._ImgSearch.Location = new System.Drawing.Point(8, 8);
            this._ImgSearch.Name = "_ImgSearch";
            this._ImgSearch.Size = new System.Drawing.Size(40, 40);
            this._ImgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._ImgSearch.TabIndex = 1;
            this._ImgSearch.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this._DgGrupe);
            this.panel1.Controls.Add(this._BtnDodaj);
            this.panel1.Controls.Add(this._LabGrupeMenu);
            this.panel1.EndColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.GradinetMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 656);
            this.panel1.StartColor = System.Drawing.SystemColors.Control;
            this.panel1.TabIndex = 1;
            // 
            // _DgGrupe
            // 
            this._DgGrupe.AllowUserToAddRows = false;
            this._DgGrupe.AllowUserToDeleteRows = false;
            this._DgGrupe.AllowUserToOrderColumns = true;
            this._DgGrupe.AllowUserToResizeColumns = false;
            this._DgGrupe.AllowUserToResizeRows = false;
            this._DgGrupe.AutoGenerateColumns = false;
            this._DgGrupe.BackgroundColor = System.Drawing.SystemColors.Control;
            this._DgGrupe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._DgGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DgGrupe.ColumnHeadersVisible = false;
            this._DgGrupe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn});
            this._DgGrupe.DataSource = this._BsGrupe;
            this._DgGrupe.Location = new System.Drawing.Point(7, 45);
            this._DgGrupe.MultiSelect = false;
            this._DgGrupe.Name = "_DgGrupe";
            this._DgGrupe.ReadOnly = true;
            this._DgGrupe.RowHeadersVisible = false;
            this._DgGrupe.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._DgGrupe.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this._DgGrupe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this._DgGrupe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this._DgGrupe.RowTemplate.Height = 30;
            this._DgGrupe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._DgGrupe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._DgGrupe.Size = new System.Drawing.Size(266, 459);
            this._DgGrupe.TabIndex = 11;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _BsGrupe
            // 
            this._BsGrupe.DataSource = typeof(PoslovniImenik.IdTextItem);
            this._BsGrupe.CurrentChanged += new System.EventHandler(this._BsGrupe_CurrentChanged);
            // 
            // _BtnDodaj
            // 
            this._BtnDodaj.BackColor = System.Drawing.SystemColors.Control;
            this._BtnDodaj.BaseColor = System.Drawing.Color.White;
            this._BtnDodaj.ButtonColor = System.Drawing.Color.DimGray;
            this._BtnDodaj.ButtonText = "Dodaj kontakt";
            this._BtnDodaj.CornerRadius = 2;
            this._BtnDodaj.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BtnDodaj.ForeColor = System.Drawing.Color.Black;
            this._BtnDodaj.GlowColor = System.Drawing.Color.DimGray;
            this._BtnDodaj.Image = global::PoslovniImenik.Properties.Resources.add;
            this._BtnDodaj.ImageSize = new System.Drawing.Size(16, 16);
            this._BtnDodaj.Location = new System.Drawing.Point(7, 7);
            this._BtnDodaj.Name = "_BtnDodaj";
            this._BtnDodaj.Size = new System.Drawing.Size(124, 31);
            this._BtnDodaj.TabIndex = 10;
            this._BtnDodaj.TabStop = false;
            this._BtnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BtnDodaj.Click += new System.EventHandler(this._BtnDodaj_Click);
            // 
            // _LabGrupeMenu
            // 
            this._LabGrupeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._LabGrupeMenu.AutoSize = true;
            this._LabGrupeMenu.ContextMenuStrip = this._MnuGrupe;
            this._LabGrupeMenu.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this._LabGrupeMenu.Location = new System.Drawing.Point(248, 5);
            this._LabGrupeMenu.Name = "_LabGrupeMenu";
            this._LabGrupeMenu.Size = new System.Drawing.Size(25, 19);
            this._LabGrupeMenu.TabIndex = 10;
            this._LabGrupeMenu.Text = "";
            this._LabGrupeMenu.Click += new System.EventHandler(this._LabGrupeMenu_Click);
            // 
            // panelPlus1
            // 
            this.panelPlus1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPlus1.BackColor = System.Drawing.Color.Transparent;
            this.panelPlus1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPlus1.BackgroundImage")));
            this.panelPlus1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelPlus1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.panelPlus1.Controls.Add(this._DgKontakti);
            this.panelPlus1.Controls.Add(this._LabGrupa);
            this.panelPlus1.EndColor = System.Drawing.SystemColors.ControlDark;
            this.panelPlus1.GradinetMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelPlus1.Location = new System.Drawing.Point(298, 79);
            this.panelPlus1.Name = "panelPlus1";
            this.panelPlus1.Size = new System.Drawing.Size(500, 656);
            this.panelPlus1.StartColor = System.Drawing.SystemColors.Control;
            this.panelPlus1.TabIndex = 2;
            // 
            // _DgKontakti
            // 
            this._DgKontakti.AllowUserToAddRows = false;
            this._DgKontakti.AllowUserToDeleteRows = false;
            this._DgKontakti.AllowUserToResizeColumns = false;
            this._DgKontakti.AllowUserToResizeRows = false;
            this._DgKontakti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._DgKontakti.AutoGenerateColumns = false;
            this._DgKontakti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DgKontakti.BackgroundColor = System.Drawing.SystemColors.Control;
            this._DgKontakti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._DgKontakti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._DgKontakti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._DgKontakti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DgKontakti.ColumnHeadersVisible = false;
            this._DgKontakti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.prezimeImeDataGridViewTextBoxColumn});
            this._DgKontakti.DataSource = this._BsKontakti;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._DgKontakti.DefaultCellStyle = dataGridViewCellStyle2;
            this._DgKontakti.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._DgKontakti.Location = new System.Drawing.Point(6, 44);
            this._DgKontakti.MultiSelect = false;
            this._DgKontakti.Name = "_DgKontakti";
            this._DgKontakti.ReadOnly = true;
            this._DgKontakti.RowHeadersVisible = false;
            this._DgKontakti.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._DgKontakti.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this._DgKontakti.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this._DgKontakti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._DgKontakti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._DgKontakti.Size = new System.Drawing.Size(487, 602);
            this._DgKontakti.TabIndex = 11;
            this._DgKontakti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DgKontakti_CellClick);
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeImeDataGridViewTextBoxColumn
            // 
            this.prezimeImeDataGridViewTextBoxColumn.DataPropertyName = "PrezimeIme";
            this.prezimeImeDataGridViewTextBoxColumn.HeaderText = "";
            this.prezimeImeDataGridViewTextBoxColumn.Name = "prezimeImeDataGridViewTextBoxColumn";
            this.prezimeImeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _BsKontakti
            // 
            this._BsKontakti.DataSource = typeof(PoslovniImenik.KontaktPreview);
            // 
            // _LabGrupa
            // 
            this._LabGrupa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._LabGrupa.AutoEllipsis = true;
            this._LabGrupa.BackColor = System.Drawing.SystemColors.Control;
            this._LabGrupa.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LabGrupa.Location = new System.Drawing.Point(6, 6);
            this._LabGrupa.Name = "_LabGrupa";
            this._LabGrupa.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this._LabGrupa.Size = new System.Drawing.Size(487, 33);
            this._LabGrupa.TabIndex = 9;
            this._LabGrupa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1277, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this._PnlSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPlus1);
            this.Controls.Add(this.ucKontakt1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livplast - Poslovni imenik v 1.22";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._MnuGrupe.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this._PnlSearch.ResumeLayout(false);
            this._PnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ImgSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DgGrupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BsGrupe)).EndInit();
            this.panelPlus1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._DgKontakti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BsKontakti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prezimeImeDataGridViewTextBoxColumn;
    }
}