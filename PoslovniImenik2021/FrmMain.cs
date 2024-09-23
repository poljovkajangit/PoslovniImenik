using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PoslovniImenik
{
    public partial class FrmMain : Form
    {
        // Fields
        private SortedBindingList<IdTextItem> _Grupe;
        private ContextMenuStrip _MnuGrupe;
        private ToolStripMenuItem dodajGrupuToolStripMenuItem;
        private ToolStripMenuItem promeniNazivToolStripMenuItem;
        private ToolStripMenuItem obrišiToolStripMenuItem;
        private PanelPlus panel1;
        private Label _LabGrupeMenu;
        private PanelPlus panelPlus1;
        private Label _LabGrupa;
        private VistaButton _BtnDodaj;
        private PanelPlus _PnlSearch;
        private BindingSource _BsKontakti;
        private DataGridView _DgKontakti;
        private PictureBox _ImgSearch;
        private UCSuggestions ucSuggestions1;
        private UCKontakt ucKontakt1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ProgressBar _ProgressBar;
        private DataGridView _DgGrupe;
        private BindingSource _BsGrupe;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;

        // Properties
        private SortedBindingList<KontaktPreview> Kontakti { get; set; }

        public FrmMain()
        {
            UCSuggestionsEventHandler handler = null;
            this._Grupe = new SortedBindingList<IdTextItem>();
            this.components = null;
            this.InitializeComponent();
            this._BsGrupe.DataSource = this._Grupe;
            this.ucSuggestions1.Parent = this;
            this.ucSuggestions1.BringToFront();
            this.ucSuggestions1.Top = this._PnlSearch.Top + ((this._PnlSearch.Height - this.ucSuggestions1.Height) / 2);
            this.ucSuggestions1.Left = this._ImgSearch.Right + 0x12;
            this.PopuniGrupe();
            this.LoadAndResume();
            if (handler == null)
            {
                handler = delegate (UCSuggestionsEventArgs args) {
                    this._ProgressBar.Visible = true;
                    this._LabGrupa.Text = "\"" + args.SelectedValue + "\"";
                    this._BtnDodaj.Enabled = false;
                    foreach (DataGridViewRow row in this._DgGrupe.SelectedRows)
                    {
                        row.Selected = false;
                    }
                    this._BsKontakti.DataSource = this.Filter(args.NormalizedValue);
                    this._BsKontakti.ResumeBinding();
                    this._ProgressBar.Visible = false;
                    this.ucKontakt1.Visible = false;
                    if (this._DgKontakti.SelectedRows.Count > 0)
                    {
                        this._DgKontakti.SelectedRows[0].Selected = false;
                    }
                };
            }
            this.ucSuggestions1.ItemSelected += handler;
            this.ucSuggestions1.Focus();
        }

        private void _BsGrupe_CurrentChanged(object sender, EventArgs e)
        {
            IdTextItem current = this._BsGrupe.Current as IdTextItem;
            if (current != null)
            {
                long id = (this._BsGrupe.Current as IdTextItem).Id;
                if (this.Kontakti == null)
                {
                    this.LoadAndResume();
                }
                SortedBindingList<KontaktPreview> list = new SortedBindingList<KontaktPreview>();
                foreach (KontaktPreview preview in this.Kontakti)
                {
                    if (preview.Grupa == id)
                    {
                        list.Add(preview);
                    }
                }
                this._BsKontakti.DataSource = list;
                this._DgKontakti.ResumeLayout();
                this._LabGrupa.Text = current.Text;
                if (this._DgKontakti.SelectedRows.Count > 0)
                {
                    this._DgKontakti.SelectedRows[0].Selected = false;
                }
                this.ucSuggestions1.ClearText();
                this.ucKontakt1.Visible = false;
                this._BtnDodaj.Enabled = true;
            }
        }

        private void _BtnDodaj_Click(object sender, EventArgs e)
        {
            if (this._BsGrupe.Current is IdTextItem)
            {
                FrmKontaktEdit.New((this._BsGrupe.Current as IdTextItem).Id, this);
                this.LoadAndResume();
            }
        }

        private void _DgKontakti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this._BsKontakti.Current != null)
            {
                this.ucKontakt1.Present(this._BsKontakti.Current as KontaktPreview, this);
                this.ucKontakt1.Visible = true;
            }
        }

        private void _LabGrupeMenu_Click(object sender, EventArgs e)
        {
            this._LabGrupeMenu.ContextMenuStrip.Show(this._LabGrupeMenu, new Point(0, this._LabGrupeMenu.Height + 3));
        }

        public void Delete()
        {
            if (this._BsKontakti.Current != null)
            {
                string text = "";
                if (TextInputFrm.Input(ref text, "Unesite šifru za brisanje", true) == DialogResult.OK)
                {
                    if (text == "livplast")
                    {
                        string str2 = (this._BsKontakti.Current as KontaktPreview).Id.ToString();
                        OleDbConnection connection = new OleDbConnection(Connection.ConnectionString);
                        using (connection)
                        {
                            connection.Open();
                            OleDbCommand command = new OleDbCommand
                            {
                                Connection = connection
                            };
                            using (command)
                            {
                                command.CommandText = "Delete from FINANSIJE where FINANSIJE.KONTAKTID = " + str2;
                                command.ExecuteNonQuery();
                                command.CommandText = "Delete from KONTAKT where KONTAKT.ID = " + str2;
                                command.ExecuteNonQuery();
                            }
                        }
                        this.LoadAndResume();
                    }
                    else
                    {
                        MessageBox.Show("Pogrešna šifra za brisanje", "Livplast", MessageBoxButtons.OK);
                    }
                }
            }
        }
        private void dodajGrupuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "";
            if (TextInputFrm.Input(ref text, "Unesite naziv nove grupe", false) == DialogResult.OK)
            {
                OleDbConnection connection = new OleDbConnection(Connection.ConnectionString);
                using (connection)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand
                    {
                        Connection = connection
                    };
                    using (command)
                    {
                        command.CommandText = "Insert Into GRUPA (naziv) Values ('" + text + "')";
                        command.ExecuteNonQuery();
                    }
                }
                this.PopuniGrupe();
            }
        }

        public void Edit()
        {
            if (this._BsKontakti.Current != null)
            {
                FrmKontaktEdit.Edit((this._BsKontakti.Current as KontaktPreview).Id);
                this.LoadAndResume();
            }
        }

        private List<KontaktPreview> Filter(string criteria)
        {
            this._ProgressBar.Maximum = this.Kontakti.Count;
            this._ProgressBar.Value = 0;
            string[] strArray = criteria.Split(new char[] { ' ' });
            if (this.Kontakti == null)
            {
                this.LoadAndResume();
            }
            List<KontaktPreview> list = new List<KontaktPreview>();
            foreach (KontaktPreview preview in this.Kontakti)
            {
                bool flag = false;
                string str = preview.Ostalo.ToUpper().Replace("Ć", "C").Replace("Č", "C").Replace("Ž", "Z").Replace("Đ", "D").Replace("Š", "S");
                foreach (string str2 in strArray)
                {
                    if (str.Contains(str2))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    list.Add(preview);
                }
                this._ProgressBar.Value++;
            }
            return list;
        }
 

        public void LoadAndResume()
        {
            OleDbConnection connection = new OleDbConnection(Connection.ConnectionString);
            int num = 0;
            using (connection)
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = "Select count(*) From Kontakt";
                using (command)
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            num = reader.GetInt32(0);
                        }
                    }
                }
            }
            this._ProgressBar.Maximum = num * 2;
            this._ProgressBar.Value = 0;
            this._ProgressBar.Visible = true;
            this.LoadKontakti();
            this.ResumeBinding();
            this._ProgressBar.Visible = false;
            if (this._BsKontakti.Current != null)
            {
                this.ucKontakt1.Present(this._BsKontakti.Current as KontaktPreview, this);
            }
        }

        private void LoadKontakti()
        {
            if (this.Kontakti == null)
            {
                this.Kontakti = new SortedBindingList<KontaktPreview>();
                this._BsKontakti.DataSource = this.Kontakti;
            }
            else
            {
                this.Kontakti.Clear();
            }
            IList<KontaktPreview> collection = new List<KontaktPreview>();
            KontaktPreview item = null;
            OleDbConnection connection = null;
            connection = new OleDbConnection(Connection.ConnectionString);
            using (connection)
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = "Select * From Kontakt";
                using (command)
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            StringBuilder builder = new StringBuilder();
                            item = new KontaktPreview
                            {
                                Id = reader.GetInt32(0)
                            };
                            if (!reader.IsDBNull(1))
                            {
                                item.Grupa = reader.GetInt32(1);
                                builder.Append(item.Grupa);
                            }
                            if (!reader.IsDBNull(2))
                            {
                                item.Naziv = reader.GetString(2);
                                builder.Append(item.Naziv);
                                this.ucSuggestions1.AddWord(item.Naziv, false);
                            }
                            if (!reader.IsDBNull(3))
                            {
                                item.Adresa = reader.GetString(3);
                                builder.Append(item.Adresa);
                                this.ucSuggestions1.AddWord(item.Adresa, false);
                            }
                            if (!reader.IsDBNull(4))
                            {
                                item.Mesto = reader.GetString(4);
                                builder.Append(item.Mesto);
                                this.ucSuggestions1.AddWord(item.Mesto, false);
                            }
                            if (!reader.IsDBNull(6))
                            {
                                item.Fax = reader.GetString(6);
                                builder.Append(item.Fax);
                            }
                            if (!reader.IsDBNull(7))
                            {
                                item.PIB = reader.GetString(7);
                                builder.Append(item.PIB);
                            }
                            if (!reader.IsDBNull(8))
                            {
                                item.Email = reader.GetString(8);
                                builder.Append(item.Email);
                                this.ucSuggestions1.AddWord(item.Email, false);
                            }
                            if (!reader.IsDBNull(9))
                            {
                                item.Web = reader.GetString(9);
                                builder.Append(item.Web);
                                this.ucSuggestions1.AddWord(item.Web, false);
                            }
                            if (!reader.IsDBNull(10))
                            {
                                item.Delatnost = reader.GetString(10);
                                builder.Append(item.Delatnost);
                                this.ucSuggestions1.AddWord(item.Delatnost, false);
                            }
                            if (!reader.IsDBNull(11))
                            {
                                item.Napomena = reader.GetString(11);
                                if (!string.IsNullOrEmpty(item.Napomena))
                                {
                                    string str = item.Napomena.Replace(' ', '|').Replace('.', '|').Replace(',', '|').Replace('\r', '|').Replace('\n', '|');
                                    foreach (string str2 in str.Split(new char[] { '|' }))
                                    {
                                        if (str2.Length > 2)
                                        {
                                            this.ucSuggestions1.AddWord(str2, false);
                                        }
                                    }
                                }
                                builder.Append(item.Napomena);
                            }
                            if (!reader.IsDBNull(12))
                            {
                                item.PrezimeIme = reader.GetString(12);
                                builder.Append(item.PrezimeIme);
                                this.ucSuggestions1.AddWord(item.PrezimeIme, false);
                            }
                            if (!reader.IsDBNull(13))
                            {
                                item.Drzava = reader.GetString(13);
                                builder.Append(item.Drzava);
                                this.ucSuggestions1.AddWord(item.Drzava, false);
                            }
                            if (!reader.IsDBNull(14))
                            {
                                item.FolderLocation = reader.GetString(14);
                                builder.Append(item.FolderLocation);
                                this.ucSuggestions1.AddWord(item.FolderLocation, false);
                            }
                            item.Telefoni = new List<string>();
                            if (!reader.IsDBNull(5))
                            {
                                string str3 = reader.GetString(5);
                                item.Telefoni.AddRange(str3.Split(new char[] { '|' }));
                                builder.Append(item.Telefoni);
                            }
                            item.Ostalo = builder.ToString();
                            collection.Add(item);
                            this._ProgressBar.Value++;
                        }
                    }
                }
            }
            this.Kontakti.ReplaceContent<KontaktPreview>(collection);
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdTextItem current = this._BsGrupe.Current as IdTextItem;
            if (current != null)
            {
                string text = current.Text;
                long id = current.Id;
                string str2 = "";
                if (TextInputFrm.Input(ref str2, "Unesite šifru za brisanje", true) == DialogResult.OK)
                {
                    if (str2 == "livplast")
                    {
                        OleDbConnection connection = new OleDbConnection(Connection.ConnectionString);
                        using (connection)
                        {
                            connection.Open();
                            OleDbCommand command = connection.CreateCommand();
                            using (command)
                            {
                                command.CommandText = "Delete From Grupa Where Grupa.Id=" + id;
                                command.ExecuteNonQuery();
                            }
                        }
                        this.PopuniGrupe();
                    }
                    else
                    {
                        MessageBox.Show("Pogrešna šifra za brisanje", "Livplast", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void PopuniGrupe()
        {
            IList<IdTextItem> collection = new List<IdTextItem>();
            OleDbConnection connection = new OleDbConnection(Connection.ConnectionString);
            using (connection)
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand
                {
                    CommandText = "Select * From GRUPA",
                    CommandType = CommandType.TableDirect,
                    Connection = connection
                };
                using (command)
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            collection.Add(new IdTextItem(reader.GetString(1), (long)reader.GetInt32(0)));
                        }
                    }
                }
            }
            this._Grupe.ReplaceContent<IdTextItem>(collection);
        }

        private void promeniNazivToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdTextItem current = null;
            current = this._BsGrupe.Current as IdTextItem;
            if (current != null)
            {
                string text = current.Text;
                long id = current.Id;
                if (TextInputFrm.Input(ref text, "Unesite novi naziv grupe", false) == DialogResult.OK)
                {
                    OleDbConnection connection = new OleDbConnection(Connection.ConnectionString);
                    using (connection)
                    {
                        connection.Open();
                        OleDbCommand command = connection.CreateCommand();
                        using (command)
                        {
                            command.CommandText = string.Concat(new object[] { "Update Grupa Set Grupa.Naziv ='", text, "' where Id=", id });
                            command.ExecuteNonQuery();
                        }
                    }
                    this.PopuniGrupe();
                }
            }
        }

        private void ResumeBinding()
        {
            List<KontaktPreview> list = new List<KontaktPreview>();
            if (this._BsGrupe.Current != null)
            {
                long id = (this._BsGrupe.Current as IdTextItem).Id;
                foreach (KontaktPreview preview in this.Kontakti)
                {
                    if (preview.Grupa == id)
                    {
                        list.Add(preview);
                    }
                    this._ProgressBar.Value++;
                }
                this._LabGrupa.Text = (this._BsGrupe.Current as IdTextItem).Text;
            }
            this._BsKontakti.DataSource = list;
            this._DgKontakti.ResumeLayout();
        }

    }
}
