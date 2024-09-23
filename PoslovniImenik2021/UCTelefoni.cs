

using PoslovniImenik.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoslovniImenik
{
    public partial class UCTelefoni : UserControl
    {
        // Fields
        private VistaButton _BtnDodajTelefon;
        private Label label1;
        private BindingList<string> _Telefoni = null;
        private bool _Changed = false;

        // Properties
        public BindingList<string> Telefoni
        {
            get
            {
                if (this._Telefoni == null)
                {
                    this._Telefoni = new BindingList<string>();
                }
                return this._Telefoni;
            }
        }

        public bool Changed
        {
            get
            {
                return this._Changed;
            }
        }


        // Methods
        public UCTelefoni()
        {
            this.InitializeComponent();
        }

        private void _BtnDodajTelefon_Click(object sender, EventArgs e)
        {
            if (this.Telefoni.Count < 10)
            {
                this.Telefoni.Add("");
                this.SetupControls();
            }
        }

        public void AddFormatedTelefoniString(string input, char delimiter)
        {
            List<string> telefoni = new List<string>();
            telefoni.AddRange(input.Split(new char[] { delimiter }));
            this.AddTelefoni(telefoni);
        }

        private void AddTelefoni(List<string> telefoni)
        {
            foreach (string str in telefoni)
            {
                this.Telefoni.Add(str);
            }
            this.SetupControls();
        }

        internal void ClearAll()
        {
            this.Telefoni.Clear();
            this.SetupControls();
        }

        public string GetFormatedTelefoniString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string str in this.Telefoni)
            {
                builder.Append(str);
                builder.Append("|");
            }
            if (builder.Length > 0)
            {
                builder.Remove(builder.Length - 1, 1);
            }
            return builder.ToString();
        }
  
        private void SetupControls()
        {
            List<Control> list = new List<Control>();

            foreach (Control control in base.Controls)
            {
                if (((control is TextBox) || (control is PictureBox)) && (control.Name != this._BtnDodajTelefon.Name))
                {
                    list.Add(control);
                }
            }
            //using (IEnumerator enumerator = base.Controls.GetEnumerator())
            //{
            //    while (enumerator.MoveNext())
            //    {
            //        Control control;
            //        if (((control is TextBox) || (control is PictureBox)) && (control.Name != this._BtnDodajTelefon.Name))
            //        {
            //            list.Add(control);
            //        }
            //    }
            //}
            foreach (Control control in list)
            {
                control.Parent = null;
                base.Controls.Remove(control);
            }
            int num = 0;
            foreach (string str in this.Telefoni)
            {
                TextBox tb = new TextBox
                {
                    Left = 5,
                    Width = base.Width - 0x26
                };
                tb.Top = 0x24 + (num++ * (tb.Height + 8));
                tb.Text = str;
                tb.TextChanged += delegate
                {
                    this._Changed = true;
                    this.Telefoni[(int)tb.Tag] = tb.Text;
                };
                tb.Tag = num - 1;
                base.Controls.Add(tb);
                PictureBox img = new PictureBox
                {
                    Image = Resources.minus_icon,
                    Left = tb.Right + 4,
                    Top = tb.Top - 2,
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Tag = num - 1
                };
                img.MouseEnter += delegate { img.BackColor = Color.Silver; };
                img.MouseLeave += delegate { img.BackColor = SystemColors.Control; };
                img.Click += delegate
                {
                    this.Telefoni.RemoveAt((int)img.Tag);
                    this.SetupControls();
                };
                base.Controls.Add(img);
            }
        }
    }
}