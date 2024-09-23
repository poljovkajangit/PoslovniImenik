using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace PoslovniImenik
{
    public partial class FrmKontaktEdit : Form
    {
        // Fields
        private FrmMain _MainFrm = null;
        private bool _InsertMode = false;
        private long _Id = 0L;
        private long _GrupaId = -1L;
        private PanelPlus _PnlMainPanel;
        private TextBox _TbNapomena;
        private TextBox _TbEmail;
        private TextBox _TbFax;
        private Label label6;
        private TextBox _TbMesto;
        private Label label4;
        private TextBox _TbAdresa;
        private Label label2;
        private TextBox _TbNaziv;
        private Label Naziv;
        private Label label3;
        private TextBox _TbWeb;
        private Label label1;
        private TextBox _TbPIB;
        private Label label9;
        private TextBox _TbDelatnost;
        private Label label14;
        private VistaButton _BtnSledeci;
        private TextBox _TbPrezimeIme;
        private Label label7;
        private UCTelefoni ucTelefoni1;
        private VistaButton _BtnSave;
        private TextBox _TbDrzava;
        private Label label5;



        public FrmKontaktEdit()
        {
            InitializeComponent();
        }

        private void _BtnSave_Click(object sender, EventArgs e)
        {
            if (this._InsertMode)
            {
                if (this.SaveNew())
                {
                    base.DialogResult = DialogResult.OK;
                }
            }
            else if (this.SaveOld())
            {
                base.DialogResult = DialogResult.OK;
            }
        }

        private void _BtnSledeci_Click(object sender, EventArgs e)
        {
            this.SaveNew();
            this._MainFrm.LoadAndResume();
            foreach (Control control in this._PnlMainPanel.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = "";
                }
            }
            this.ucTelefoni1.ClearAll();
            this._TbNaziv.Focus();
        }

        public static void Edit(long id)
        {
            FrmKontaktEdit edit = new FrmKontaktEdit
            {
                Text = "Izmena kontakta"
            };
            OleDbConnection connection = new OleDbConnection(Connection.ConnectionString);
            using (connection)
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                using (command)
                {
                    command.CommandText = "Select * From Kontakt Where Id=" + id;
                    OleDbDataReader reader = command.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            edit._GrupaId = reader.GetInt32(1);
                            if (!reader.IsDBNull(2))
                            {
                                edit._TbNaziv.Text = reader.GetString(2);
                            }
                            if (!reader.IsDBNull(3))
                            {
                                edit._TbAdresa.Text = reader.GetString(3);
                            }
                            if (!reader.IsDBNull(4))
                            {
                                edit._TbMesto.Text = reader.GetString(4);
                            }
                            if (!reader.IsDBNull(6))
                            {
                                edit._TbFax.Text = reader.GetString(6);
                            }
                            if (!reader.IsDBNull(7))
                            {
                                edit._TbPIB.Text = reader.GetString(7);
                            }
                            if (!reader.IsDBNull(8))
                            {
                                edit._TbEmail.Text = reader.GetString(8);
                            }
                            if (!reader.IsDBNull(9))
                            {
                                edit._TbWeb.Text = reader.GetString(9);
                            }
                            if (!reader.IsDBNull(10))
                            {
                                edit._TbDelatnost.Text = reader.GetString(10);
                            }
                            if (!reader.IsDBNull(11))
                            {
                                edit._TbNapomena.Text = reader.GetString(11);
                            }
                            if (!reader.IsDBNull(12))
                            {
                                edit._TbPrezimeIme.Text = reader.GetString(12);
                            }
                            if (!reader.IsDBNull(13))
                            {
                                edit._TbDrzava.Text = reader.GetString(13);
                            }
                            if (!reader.IsDBNull(14))
                            {
                                edit._TbFolder.Text = reader.GetString(14);
                            }
                            if (!reader.IsDBNull(5))
                            {
                                string input = reader.GetString(5);
                                edit.ucTelefoni1.AddFormatedTelefoniString(input, '|');
                            }
                            edit._Id = reader.GetInt32(0);
                        }
                    }
                }
            }
            edit._BtnSledeci.Visible = false;
            edit._InsertMode = false;
            edit.ShowDialog();
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    Control ctl = sender as Control;
            //    if ((ctl != null) && !((ctl is TextBox) && (ctl as TextBox).Multiline))
            //    {
            //        base.SelectNextControl(ctl, true, true, true, true);
            //    }
            //}
            //else 
            if (e.KeyCode == Keys.F2)
            {
                this._BtnSave_Click(this, null);
            }
        }

        private void KonPlEditFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        public static void New(long grupaId, FrmMain mainFrm)
        {
            new FrmKontaktEdit
            {
                _MainFrm = mainFrm,
                _BtnSledeci = { Visible = true },
                Text = "Unos novog kontakta",
                _InsertMode = true,
                _GrupaId = grupaId
            }.ShowDialog();
        }

        private bool SaveNew()
        {
            if (string.IsNullOrEmpty(this._TbNaziv.Text) && string.IsNullOrEmpty(this._TbPrezimeIme.Text))
            {
                MessageBox.Show("Molim, unesite naziv ili prezime i ime", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (string.IsNullOrEmpty(this._TbNaziv.Text))
                {
                    this._TbNaziv.Focus();
                }
                else
                {
                    this._TbPrezimeIme.Focus();
                }
                return false;
            }
            string text = this._TbPrezimeIme.Text;
            string str2 = this._TbNaziv.Text;
            string str3 = this._TbAdresa.Text;
            string str4 = this._TbMesto.Text;
            string str5 = this._TbFax.Text;
            string str6 = this._TbEmail.Text;
            string str7 = this._TbWeb.Text;
            string str8 = this._TbPIB.Text;
            string str9 = this._TbDelatnost.Text;
            string str10 = this._TbNapomena.Text;
            string formatedTelefoniString = this.ucTelefoni1.GetFormatedTelefoniString();
            string str12 = this._TbDrzava.Text;
            OleDbConnection connection = new OleDbConnection(Connection.ConnectionString);
            using (connection)
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                using (command)
                {
                    command.CommandText = "Insert Into KONTAKT (GrupaId, Naziv, Adresa, Mesto, Telefon, Fax, PIB, Email, Web, Delatnost, Napomena, PrezimeIme, Drzava) Values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')";
                    command.CommandText = string.Format(command.CommandText, new object[] { this._GrupaId, str2, str3, str4, formatedTelefoniString, str5, str8, str6, str7, str9, str10, text, str12 });
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }

        private bool SaveOld()
        {
            if (string.IsNullOrEmpty(this._TbNaziv.Text) && string.IsNullOrEmpty(this._TbPrezimeIme.Text))
            {
                MessageBox.Show("Molim, unesite naziv ili prezime i ime", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (string.IsNullOrEmpty(this._TbNaziv.Text))
                {
                    this._TbNaziv.Focus();
                }
                else
                {
                    this._TbPrezimeIme.Focus();
                }
                return false;
            }
            OleDbConnection connection = null;
            connection = new OleDbConnection(Connection.ConnectionString);
            using (connection)
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                using (command)
                {
                    command.CommandText = string.Concat(new object[] {
                    "Update Kontakt Set GrupaId=", this._GrupaId, ", Naziv='", this._TbNaziv.Text, "', Adresa='", this._TbAdresa.Text, "', Mesto='", this._TbMesto.Text, "', Telefon='", this.ucTelefoni1.GetFormatedTelefoniString(), "', Fax='", this._TbFax.Text, "', PIB='", this._TbPIB.Text, "', Email='", this._TbEmail.Text,
                    "', Web='", this._TbWeb.Text, "', Delatnost='", this._TbDelatnost.Text, "', Napomena='", this._TbNapomena.Text, "', PrezimeIme='", this._TbPrezimeIme.Text, "', Drzava='", this._TbDrzava.Text, "', FolderLocation ='", this._TbFolder.Text, "' Where Kontakt.Id=", this._Id
                });
                    command.ExecuteNonQuery();
                }
            }
            return true;

        }

        private void _LnkPodesiFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _TbFolder.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
