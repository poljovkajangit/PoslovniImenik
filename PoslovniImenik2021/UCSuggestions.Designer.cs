using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PoslovniImenik
{
    partial class UCSuggestions
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

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this._DgPredlozi = new DataGridView();
            this.originalanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this._BsPredlozi = new BindingSource(this.components);
            this._TbInputBox = new TextBox();
            ((ISupportInitialize)this._DgPredlozi).BeginInit();
            ((ISupportInitialize)this._BsPredlozi).BeginInit();
            base.SuspendLayout();
            this._DgPredlozi.AllowUserToAddRows = false;
            this._DgPredlozi.AllowUserToDeleteRows = false;
            this._DgPredlozi.AllowUserToResizeColumns = false;
            this._DgPredlozi.AllowUserToResizeRows = false;
            this._DgPredlozi.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this._DgPredlozi.AutoGenerateColumns = false;
            this._DgPredlozi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this._DgPredlozi.BackgroundColor = Color.White;
            this._DgPredlozi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this._DgPredlozi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DgPredlozi.ColumnHeadersVisible = false;
            this._DgPredlozi.Columns.AddRange(new DataGridViewColumn[] { this.originalanDataGridViewTextBoxColumn });
            this._DgPredlozi.DataSource = this._BsPredlozi;
            this._DgPredlozi.Location = new Point(0, 0x1d);
            this._DgPredlozi.MultiSelect = false;
            this._DgPredlozi.Name = "_DgPredlozi";
            this._DgPredlozi.RowHeadersVisible = false;
            style.SelectionBackColor = Color.Lavender;
            style.SelectionForeColor = Color.Black;
            this._DgPredlozi.RowsDefaultCellStyle = style;
            this._DgPredlozi.ScrollBars = ScrollBars.Vertical;
            this._DgPredlozi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this._DgPredlozi.Size = new Size(0x130, 0x90);
            this._DgPredlozi.TabIndex = 0;
            this._DgPredlozi.CellMouseClick += new DataGridViewCellMouseEventHandler(this._DgPredlozi_CellMouseClick);
            this._DgPredlozi.CellMouseEnter += new DataGridViewCellEventHandler(this._DgPredlozi_CellMouseEnter);
            this._DgPredlozi.CellClick += new DataGridViewCellEventHandler(this._DgPredlozi_CellClick);
            this.originalanDataGridViewTextBoxColumn.DataPropertyName = "Originalan";
            this.originalanDataGridViewTextBoxColumn.HeaderText = "Originalan";
            this.originalanDataGridViewTextBoxColumn.Name = "originalanDataGridViewTextBoxColumn";
            this._BsPredlozi.DataSource = typeof(DoubleString);
            this._TbInputBox.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this._TbInputBox.BorderStyle = BorderStyle.FixedSingle;
            this._TbInputBox.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._TbInputBox.Location = new Point(0, 0);
            this._TbInputBox.Name = "_TbInputBox";
            this._TbInputBox.Size = new Size(0x130, 0x1b);
            this._TbInputBox.TabIndex = 0;
            this._TbInputBox.TextChanged += new EventHandler(this._TbInputBox_TextChanged);
            this._TbInputBox.KeyDown += new KeyEventHandler(this._TbInputBox_KeyDown);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.Controls.Add(this._TbInputBox);
            base.Controls.Add(this._DgPredlozi);
            base.Name = "UCSuggestions";
            base.Size = new Size(0x130, 0x1b);
            base.Enter += new EventHandler(this.UCSuggestions_Enter);
            ((ISupportInitialize)this._DgPredlozi).EndInit();
            ((ISupportInitialize)this._BsPredlozi).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
    }
}
