using PoslovniImenik.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PoslovniImenik
{
    partial class KarticaPromenaFrm
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

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            DataGridViewCellStyle style7 = new DataGridViewCellStyle();
            this._LblNaziv = new Label();
            this._LblMesto = new Label();
            this._BtnNovaPromena = new Button();
            this._DgItems = new DataGridView();
            this.StatusImage = new DataGridViewImageColumn();
            this.datumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.dugujeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.potrazujeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this._BsDuguje = new BindingSource(this.components);
            this._BtnDelete = new Button();
            this._BtnSave = new Button();
            this._LabUkupnoDuguje = new Label();
            this._LabUkupnoPotrazuje = new Label();
            this.panel1 = new Panel();
            this._LabUkupno = new Label();
            this.label1 = new Label();
            this.label2 = new Label();
            this._BtnUpdate = new Button();
            this._PnlDatumi = new Panel();
            this._DtDo = new NullableDateTimePicker();
            this._DtOd = new NullableDateTimePicker();
            ((ISupportInitialize)this._DgItems).BeginInit();
            ((ISupportInitialize)this._BsDuguje).BeginInit();
            this.panel1.SuspendLayout();
            this._PnlDatumi.SuspendLayout();
            base.SuspendLayout();
            this._LblNaziv.AutoSize = true;
            this._LblNaziv.Font = new Font("Tahoma", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this._LblNaziv.Location = new Point(12, 6);
            this._LblNaziv.Name = "_LblNaziv";
            this._LblNaziv.Size = new Size(0x4d, 0x15);
            this._LblNaziv.TabIndex = 2;
            this._LblNaziv.Text = "_naziv_";
            this._LblMesto.AutoSize = true;
            this._LblMesto.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._LblMesto.Location = new Point(12, 0x1a);
            this._LblMesto.Name = "_LblMesto";
            this._LblMesto.Size = new Size(0x33, 0x10);
            this._LblMesto.TabIndex = 3;
            this._LblMesto.Text = "_naziv_";
            this._BtnNovaPromena.Image = Resources.add;
            this._BtnNovaPromena.ImageAlign = ContentAlignment.MiddleLeft;
            this._BtnNovaPromena.Location = new Point(15, 0x18f);
            this._BtnNovaPromena.Name = "_BtnNovaPromena";
            this._BtnNovaPromena.Padding = new Padding(2, 0, 0, 0);
            this._BtnNovaPromena.Size = new Size(0x68, 0x21);
            this._BtnNovaPromena.TabIndex = 4;
            this._BtnNovaPromena.Text = "Nova promena";
            this._BtnNovaPromena.TextAlign = ContentAlignment.MiddleRight;
            this._BtnNovaPromena.UseVisualStyleBackColor = true;
            this._BtnNovaPromena.Click += new EventHandler(this._BtnNovaPromena_Click);
            this._DgItems.AllowUserToAddRows = false;
            this._DgItems.AllowUserToDeleteRows = false;
            this._DgItems.AllowUserToResizeColumns = false;
            this._DgItems.AllowUserToResizeRows = false;
            this._DgItems.AutoGenerateColumns = false;
            this._DgItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this._DgItems.BackgroundColor = Color.White;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this._DgItems.ColumnHeadersDefaultCellStyle = style;
            this._DgItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DgItems.Columns.AddRange(new DataGridViewColumn[] { this.StatusImage, this.datumDataGridViewTextBoxColumn, this.dugujeDataGridViewTextBoxColumn, this.potrazujeDataGridViewTextBoxColumn, this.opisDataGridViewTextBoxColumn });
            this._DgItems.DataSource = this._BsDuguje;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Window;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.ControlText;
            style2.SelectionBackColor = Color.Gainsboro;
            style2.SelectionForeColor = Color.Black;
            style2.WrapMode = DataGridViewTriState.False;
            this._DgItems.DefaultCellStyle = style2;
            this._DgItems.EditMode = DataGridViewEditMode.EditProgrammatically;
            this._DgItems.Location = new Point(15, 0x34);
            this._DgItems.MultiSelect = false;
            this._DgItems.Name = "_DgItems";
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this._DgItems.RowHeadersDefaultCellStyle = style3;
            this._DgItems.RowHeadersVisible = false;
            style4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style4.WrapMode = DataGridViewTriState.True;
            this._DgItems.RowsDefaultCellStyle = style4;
            this._DgItems.RowTemplate.Height = 0x10;
            this._DgItems.ScrollBars = ScrollBars.Vertical;
            this._DgItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this._DgItems.Size = new Size(0x27b, 0x13c);
            this._DgItems.TabIndex = 5;
            this._DgItems.CellDoubleClick += new DataGridViewCellEventHandler(this._DgItems_CellDoubleClick);
            this._DgItems.RowPrePaint += new DataGridViewRowPrePaintEventHandler(this._DgItems_RowPrePaint);
            this._DgItems.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this._DgItems_DataBindingComplete);
            this.StatusImage.DataPropertyName = "StatusImage";
            this.StatusImage.HeaderText = "";
            this.StatusImage.Name = "StatusImage";
            this.StatusImage.ReadOnly = true;
            this.StatusImage.Width = 0x19;
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 120;
            this.dugujeDataGridViewTextBoxColumn.DataPropertyName = "Duguje";
            style5.Alignment = DataGridViewContentAlignment.MiddleRight;
            style5.Format = "N2";
            style5.NullValue = null;
            this.dugujeDataGridViewTextBoxColumn.DefaultCellStyle = style5;
            this.dugujeDataGridViewTextBoxColumn.HeaderText = "Duguje";
            this.dugujeDataGridViewTextBoxColumn.Name = "dugujeDataGridViewTextBoxColumn";
            this.potrazujeDataGridViewTextBoxColumn.DataPropertyName = "Potrazuje";
            style6.Alignment = DataGridViewContentAlignment.MiddleRight;
            style6.Format = "N2";
            style6.NullValue = null;
            this.potrazujeDataGridViewTextBoxColumn.DefaultCellStyle = style6;
            this.potrazujeDataGridViewTextBoxColumn.HeaderText = "Potražuje";
            this.potrazujeDataGridViewTextBoxColumn.Name = "potrazujeDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            style7.WrapMode = DataGridViewTriState.True;
            this.opisDataGridViewTextBoxColumn.DefaultCellStyle = style7;
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this._BsDuguje.DataSource = typeof(FPromenaItem);
            this._BsDuguje.ListChanged += new ListChangedEventHandler(this._BsDuguje_ListChanged);
            this._BtnDelete.Image = Resources.cross;
            this._BtnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            this._BtnDelete.Location = new Point(0xeb, 0x18f);
            this._BtnDelete.Name = "_BtnDelete";
            this._BtnDelete.Padding = new Padding(2, 0, 0, 0);
            this._BtnDelete.Size = new Size(0x68, 0x21);
            this._BtnDelete.TabIndex = 6;
            this._BtnDelete.Text = "Obriši promenu";
            this._BtnDelete.TextAlign = ContentAlignment.MiddleRight;
            this._BtnDelete.UseVisualStyleBackColor = true;
            this._BtnDelete.Click += new EventHandler(this._BtnDelete_Click);
            this._BtnSave.Enabled = false;
            this._BtnSave.Image = Resources.accept;
            this._BtnSave.ImageAlign = ContentAlignment.MiddleLeft;
            this._BtnSave.Location = new Point(0x21a, 0x18f);
            this._BtnSave.Name = "_BtnSave";
            this._BtnSave.Padding = new Padding(3, 0, 0, 0);
            this._BtnSave.Size = new Size(0x70, 0x21);
            this._BtnSave.TabIndex = 7;
            this._BtnSave.Text = "Sačuvaj izmene";
            this._BtnSave.TextAlign = ContentAlignment.MiddleRight;
            this._BtnSave.UseVisualStyleBackColor = true;
            this._BtnSave.Click += new EventHandler(this._BtnSave_Click);
            this._BtnSave.EnabledChanged += new EventHandler(this._BtnSave_EnabledChanged);
            this._LabUkupnoDuguje.BackColor = Color.Silver;
            this._LabUkupnoDuguje.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._LabUkupnoDuguje.ForeColor = Color.Black;
            this._LabUkupnoDuguje.Location = new Point(0x93, 0);
            this._LabUkupnoDuguje.Name = "_LabUkupnoDuguje";
            this._LabUkupnoDuguje.Size = new Size(0x68, 20);
            this._LabUkupnoDuguje.TabIndex = 9;
            this._LabUkupnoDuguje.Text = "0,00";
            this._LabUkupnoDuguje.TextAlign = ContentAlignment.MiddleRight;
            this._LabUkupnoPotrazuje.BackColor = Color.Silver;
            this._LabUkupnoPotrazuje.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._LabUkupnoPotrazuje.ForeColor = Color.Black;
            this._LabUkupnoPotrazuje.Location = new Point(0xfd, -1);
            this._LabUkupnoPotrazuje.Name = "_LabUkupnoPotrazuje";
            this._LabUkupnoPotrazuje.Size = new Size(0x63, 0x16);
            this._LabUkupnoPotrazuje.TabIndex = 10;
            this._LabUkupnoPotrazuje.Text = "0,00";
            this._LabUkupnoPotrazuje.TextAlign = ContentAlignment.MiddleRight;
            this.panel1.BackColor = Color.DimGray;
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this._LabUkupno);
            this.panel1.Controls.Add(this._LabUkupnoDuguje);
            this.panel1.Controls.Add(this._LabUkupnoPotrazuje);
            this.panel1.Location = new Point(15, 0x16f);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x27b, 0x16);
            this.panel1.TabIndex = 11;
            this._LabUkupno.BackColor = Color.Silver;
            this._LabUkupno.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._LabUkupno.Location = new Point(0x20a, 0);
            this._LabUkupno.Name = "_LabUkupno";
            this._LabUkupno.Padding = new Padding(0, 0, 2, 0);
            this._LabUkupno.Size = new Size(0x6f, 20);
            this._LabUkupno.TabIndex = 11;
            this._LabUkupno.Text = "000,00";
            this._LabUkupno.TextAlign = ContentAlignment.MiddleRight;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x19, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Od:";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(0x7e, 4);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x18, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Do:";
            this._BtnUpdate.Image = Resources.page_white_edit;
            this._BtnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            this._BtnUpdate.Location = new Point(0x7d, 0x18f);
            this._BtnUpdate.Name = "_BtnUpdate";
            this._BtnUpdate.Size = new Size(0x68, 0x21);
            this._BtnUpdate.TabIndex = 0x10;
            this._BtnUpdate.Text = "Izmeni promenu";
            this._BtnUpdate.TextAlign = ContentAlignment.MiddleRight;
            this._BtnUpdate.UseVisualStyleBackColor = true;
            this._BtnUpdate.Click += new EventHandler(this._BtnUpdate_Click);
            this._PnlDatumi.Controls.Add(this._DtDo);
            this._PnlDatumi.Controls.Add(this._DtOd);
            this._PnlDatumi.Controls.Add(this.label1);
            this._PnlDatumi.Controls.Add(this.label2);
            this._PnlDatumi.Location = new Point(0x198, 6);
            this._PnlDatumi.Name = "_PnlDatumi";
            this._PnlDatumi.Size = new Size(250, 0x2c);
            this._PnlDatumi.TabIndex = 0x11;
            this._DtDo.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._DtDo.Format = DateTimePickerFormat.Short;
            this._DtDo.Location = new Point(0x80, 0x13);
            this._DtDo.Name = "_DtDo";
            this._DtDo.NullValue = "<Izaberi datum>";
            this._DtDo.Size = new Size(0x73, 0x16);
            this._DtDo.TabIndex = 0x13;
            this._DtDo.Value = new DateTime(0x7da, 1, 0x13, 14, 0x1d, 6, 0x33c);
            this._DtDo.ValueChanged += new EventHandler(this._DtDo_ValueChanged);
            this._DtOd.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._DtOd.Format = DateTimePickerFormat.Short;
            this._DtOd.Location = new Point(5, 0x13);
            this._DtOd.Name = "_DtOd";
            this._DtOd.NullValue = "<Izaberi datum>";
            this._DtOd.Size = new Size(0x74, 0x16);
            this._DtOd.TabIndex = 0x12;
            this._DtOd.Value = new DateTime(0x7da, 1, 0x13, 14, 0x19, 0x31, 0xea);
            this._DtOd.ValueChanged += new EventHandler(this._DtOd_ValueChanged);
            base.AcceptButton = this._BtnSave;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x296, 0x1ba);
            base.Controls.Add(this._PnlDatumi);
            base.Controls.Add(this._BtnUpdate);
            base.Controls.Add(this._DgItems);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this._BtnSave);
            base.Controls.Add(this._BtnDelete);
            base.Controls.Add(this._BtnNovaPromena);
            base.Controls.Add(this._LblMesto);
            base.Controls.Add(this._LblNaziv);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.KeyPreview = true;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "KarticaPromenaFrm";
            base.ShowIcon = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Finansijska kartica";
            base.FormClosing += new FormClosingEventHandler(this.KarticaPromenaFrm_FormClosing);
            base.KeyDown += new KeyEventHandler(this.KarticaPromenaFrm_KeyDown);
            ((ISupportInitialize)this._DgItems).EndInit();
            ((ISupportInitialize)this._BsDuguje).EndInit();
            this.panel1.ResumeLayout(false);
            this._PnlDatumi.ResumeLayout(false);
            this._PnlDatumi.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();

        }

        #endregion
    }
}