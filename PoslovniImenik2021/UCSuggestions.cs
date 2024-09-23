using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PoslovniImenik
{
    public partial class UCSuggestions : UserControl
    {

        // Fields
        private DataGridView _DgPredlozi;
        private BindingSource _BsPredlozi;
        private DataGridViewTextBoxColumn originalanDataGridViewTextBoxColumn;
        private TextBox _TbInputBox;
        private SortedBindingList<DoubleString> _Suggestions = new SortedBindingList<DoubleString>();
        private List<DoubleString> _Words = new List<DoubleString>();

        // Events
        public event UCSuggestionsEventHandler ItemSelected;

        // Properties
        public string SuggestedValue
        {
            get
            {
                return this._TbInputBox.Text;
            }
            set
            {
                if (value != this._TbInputBox.Text)
                {
                    this._TbInputBox.Text = value;
                }
            }
        }

        public string Selected { get; set; }

        // Methods
        public UCSuggestions()
        {
            this.InitializeComponent();
        }

        private void _DgPredlozi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._TbInputBox.TextChanged -= new EventHandler(this._TbInputBox_TextChanged);
            DoubleString current = this._BsPredlozi.Current as DoubleString;
            if (current != null)
            {
                this._TbInputBox.Text = current.Originalan;
            }
            this._TbInputBox.TextChanged += new EventHandler(this._TbInputBox_TextChanged);
            base.Height = this._TbInputBox.Height + 1;
            this._BsPredlozi.Clear();
            this.OnItemSelected(this._TbInputBox.Text, this.NormalizeWord(this._TbInputBox.Text));
        }

        private void _DgPredlozi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this._BsPredlozi.Current != null)
            {
                this.Selected = (this._BsPredlozi.Current as DoubleString).Originalan;
                this.OnItemSelected(this.Selected, (this._BsPredlozi.Current as DoubleString).Originalan);
            }
        }

        private void _DgPredlozi_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in this._DgPredlozi.SelectedRows)
            {
                row.Selected = false;
            }
            this._DgPredlozi.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }

        private void _TbInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                base.Height = this._TbInputBox.Height + 1;
                this._BsPredlozi.Clear();
                this.OnItemSelected(this._TbInputBox.Text, this.NormalizeWord(this._TbInputBox.Text));
            }
            else if ((this._BsPredlozi.Count > 0) && ((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.Up)))
            {
                if ((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.Up))
                {
                    if (e.KeyCode == Keys.Down)
                    {
                        if (this._DgPredlozi.SelectedRows.Count == 0)
                        {
                            this._BsPredlozi.MoveFirst();
                            this._DgPredlozi.Rows[0].Selected = true;
                        }
                        else
                        {
                            this._BsPredlozi.MoveNext();
                        }
                    }
                    else
                    {
                        this._BsPredlozi.MovePrevious();
                    }
                    this._TbInputBox.TextChanged -= new EventHandler(this._TbInputBox_TextChanged);
                    DoubleString current = this._BsPredlozi.Current as DoubleString;
                    if (current != null)
                    {
                        this._TbInputBox.Text = current.Originalan;
                    }
                    this._TbInputBox.TextChanged += new EventHandler(this._TbInputBox_TextChanged);
                }
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F1)
            {
                Form form = new Form
                {
                    Width = 200,
                    Height = 400,
                    StartPosition = FormStartPosition.CenterScreen
                };
                ListBox box = new ListBox();
                foreach (DoubleString str in this._Words)
                {
                    box.Items.Add(str.Originalan);
                }
                box.Dock = DockStyle.Fill;
                form.Controls.Add(box);
                form.ShowDialog();
            }
        }

        private void _TbInputBox_TextChanged(object sender, EventArgs e)
        {
            string text = this._TbInputBox.Text;
            if (string.IsNullOrEmpty(text))
            {
                this._Suggestions.Clear();
            }
            else
            {
                string str2 = this.NormalizeWord(text);
                List<DoubleString> collection = new List<DoubleString>();
                foreach (DoubleString str3 in this._Words)
                {
                    if (str3.Normalizovan.StartsWith(str2))
                    {
                        collection.Add(str3);
                    }
                }
                this._Suggestions.ReplaceContent<DoubleString>(collection);
                this._BsPredlozi.DataSource = this._Suggestions;
                this._BsPredlozi.ResumeBinding();
            }
            if (this._Suggestions.Count > 0)
            {
                base.Height = (this._TbInputBox.Height + this._DgPredlozi.Height) + 2;
                foreach (DataGridViewRow row in this._DgPredlozi.SelectedRows)
                {
                    if (row.Selected)
                    {
                        row.Selected = false;
                    }
                }
            }
            else
            {
                base.Height = this._TbInputBox.Height;
            }
        }

        public void AddWord(string word, bool normalized)
        {
            if (!string.IsNullOrEmpty(word))
            {
                string str = "";
                if (!normalized)
                {
                    str = this.NormalizeWord(word);
                }
                else
                {
                    str = word;
                }
                bool flag = false;
                foreach (DoubleString str2 in this._Words)
                {
                    if (str2.Normalizovan == str)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    DoubleString item = new DoubleString
                    {
                        Normalizovan = this.NormalizeWord(word),
                        Originalan = word
                    };
                    this._Words.Add(item);
                }
                string[] strArray = word.Split(new char[] { ' ' });
                if (strArray.Length > 1)
                {
                    foreach (string str4 in strArray)
                    {
                        this.AddWord(str4, false);
                    }
                }
            }
        }

        internal void ClearText()
        {
            this._TbInputBox.TextChanged -= new EventHandler(this._TbInputBox_TextChanged);
            this._TbInputBox.Text = "";
            this._TbInputBox.TextChanged += new EventHandler(this._TbInputBox_TextChanged);
            base.Height = this._TbInputBox.Height + 1;
            this._BsPredlozi.Clear();
        }

        private string NormalizeWord(string input)
        {
            input = input.Trim();
            input = input.ToUpper();
            input = input.Replace("Ć", "C");
            input = input.Replace("Č", "C");
            input = input.Replace("Ž", "Z");
            input = input.Replace("Đ", "D");
            input = input.Replace("Š", "S");
            return input;
        }

        public void OnItemSelected(string value, string normalized)
        {
            if (this.ItemSelected != null)
            {
                this.ItemSelected(new UCSuggestionsEventArgs(value, normalized));
            }
        }

        public string SelectDown()
        {
            this._BsPredlozi.MoveNext();
            if (this._BsPredlozi.Current is DoubleString)
            {
                return (this._BsPredlozi.Current as DoubleString).Originalan;
            }
            return "";
        }

        public string SelectUp()
        {
            this._BsPredlozi.MovePrevious();
            if (this._BsPredlozi.Current is DoubleString)
            {
                return (this._BsPredlozi.Current as DoubleString).Originalan;
            }
            return "";
        }

        private void UCSuggestions_Enter(object sender, EventArgs e)
        {
            this._TbInputBox.Focus();
        }

    }
}

