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
    public partial class KarticaPromenaFrm : Form
    {
        // Fields
        private readonly SortedBindingList<FPromenaItem> _Items = new SortedBindingList<FPromenaItem>();
        private long _Id;
        private BindingSource _BsDuguje;
        private Label _LblNaziv;
        private Label _LblMesto;
        private Button _BtnNovaPromena;
        private DataGridView _DgItems;
        private Button _BtnDelete;
        private Button _BtnSave;
        private Label _LabUkupnoDuguje;
        private Label _LabUkupnoPotrazuje;
        private Panel panel1;
        private Label _LabUkupno;
        private Label label1;
        private Label label2;
        private DataGridViewImageColumn StatusImage;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dugujeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn potrazujeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private Button _BtnUpdate;
        private Panel _PnlDatumi;
        private NullableDateTimePicker _DtOd;
        private NullableDateTimePicker _DtDo;

        public KarticaPromenaFrm()
        {
            this.InitializeComponent();
            this._DtDo.ValueChanged -= new EventHandler(this._DtDo_ValueChanged);
            this._DtOd.ValueChanged -= new EventHandler(this._DtOd_ValueChanged);
            this._DtOd.Value = null;
            this._DtDo.Value = null;
            this._DtDo.ValueChanged += new EventHandler(this._DtDo_ValueChanged);
            this._DtOd.ValueChanged += new EventHandler(this._DtOd_ValueChanged);
        }

        private void _BsDuguje_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (this._Items.Count == 0)
            {
                this._BtnDelete.Enabled = false;
                this._BtnUpdate.Enabled = false;
            }
            else
            {
                this._BtnUpdate.Enabled = true;
                this._BtnDelete.Enabled = true;
            }
        }

        private void _BtnDelete_Click(object sender, EventArgs e)
        {
            FPromenaItem current = this._BsDuguje.Current as FPromenaItem;
            if (current != null)
            {
                if (current.Id > 0L)
                {
                    current.Status = ItemStatus.Deleted;
                    this._DgItems.Invalidate();
                    this._BtnSave.Enabled = true;
                    this.ReCalc();
                }
                else
                {
                    this._Items.Remove(current);
                    bool flag = false;
                    foreach (FPromenaItem item2 in this._Items)
                    {
                        if (((current.Status == ItemStatus.Deleted) || (current.Status == ItemStatus.New)) || (current.Status == ItemStatus.Updated))
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        this._BtnSave.Enabled = true;
                    }
                    else
                    {
                        this._BtnSave.Enabled = false;
                    }
                }
            }
        }

        private void _BtnNovaPromena_Click(object sender, EventArgs e)
        {
            FPromenaItem item = FPromenaFrm.Nova();
            if (item != null)
            {
                this._Items.Add(item);
                this._BsDuguje.ResetBindings(false);
                this.ReCalc();
                this._BtnSave.Enabled = true;
            }
        }

        private void _BtnSave_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(Connection.ConnectionString);
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                foreach (FPromenaItem item in this._Items)
                {
                    if (item.Status == ItemStatus.New)
                    {
                        command.CommandText = string.Concat(new object[] { "Insert Into Finansije (KontaktId,Datum,Duguje,Potrazuje,Opis) Values (", this._Id, ",'", item.Datum.Day, "/", item.Datum.Month, "/", item.Datum.Year, "',", item.Duguje, ",", item.Potrazuje, ",'", item.Opis, "')" });
                        command.ExecuteNonQuery();
                    }
                    else if (item.Status == ItemStatus.Deleted)
                    {
                        command.CommandText = "Delete From Finansije Where Finansije.Id=" + item.Id;
                        command.ExecuteNonQuery();
                    }
                    else if (item.Status == ItemStatus.Updated)
                    {
                        command.CommandText = string.Concat(new object[] { "Update Finansije Set Datum='", item.Datum.Day, "/", item.Datum.Month, "/", item.Datum.Year, "', Duguje=", item.Duguje, ", Potrazuje=", item.Potrazuje, ", Opis='", item.Opis, "' Where Finansije.Id=", item.Id });
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                connection.Close();
            }
            this._BtnSave.Enabled = false;
            this.Reload();
        }

        private void _BtnSave_EnabledChanged(object sender, EventArgs e)
        {
            this._PnlDatumi.Enabled = !this._BtnSave.Enabled;
        }

        private void _BtnUpdate_Click(object sender, EventArgs e)
        {
            this._DgItems_CellDoubleClick(this, null);
        }

        private void _DgItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FPromenaItem current = this._BsDuguje.Current as FPromenaItem;
            if (current != null)
            {
                FPromenaItem item2 = FPromenaFrm.Izmeni(current);
                if (item2 != null)
                {
                    if (item2.Id == 0L)
                    {
                        item2.Status = ItemStatus.New;
                    }
                    this._Items[this._BsDuguje.Position] = item2;
                    this._BtnSave.Enabled = true;
                }
                this.ReCalc();
            }
        }

        private void _DgItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this._DgItems.SelectedRows)
            {
                row.Selected = false;
            }
        }

        private void _DgItems_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((e.RowIndex > -1) && (this._Items[e.RowIndex].Status == ItemStatus.Deleted))
            {
                this._DgItems.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                this._DgItems.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Gray;
            }
        }

        private void _DtDo_ValueChanged(object sender, EventArgs e)
        {
            this.Reload();
        }

        private void _DtOd_ValueChanged(object sender, EventArgs e)
        {
            this.Reload();
        }
        private void KarticaPromenaFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._BtnSave.Enabled)
            {
                switch (MessageBox.Show("Da li želite da sačuvate unete izmene ?", "Pažnja", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;

                    case DialogResult.Yes:
                        this._BtnSave_Click(this, null);
                        break;
                }
            }
        }

        private void KarticaPromenaFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                base.Close();
            }
        }

        public static void Prikazi(long id)
        {
            KarticaPromenaFrm frm = new KarticaPromenaFrm
            {
                _Id = id
            };
            OleDbConnection connection = new OleDbConnection(Connection.ConnectionString);
            OleDbDataReader reader = null;
            OleDbCommand command = null;
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "Select * From Kontakt Where Id=" + id;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    frm._LblNaziv.Text = reader.GetString(2);
                    frm._LblMesto.Text = reader.GetString(4);
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                connection.Close();
            }
            frm._BsDuguje.DataSource = frm._Items;
            frm.Reload();
            frm.ShowDialog();
        }

        private void ReCalc()
        {
            decimal num = 0M;
            decimal num2 = 0M;
            foreach (FPromenaItem item in this._Items)
            {
                if (item.Status != ItemStatus.Deleted)
                {
                    num += item.Duguje;
                    num2 += item.Potrazuje;
                }
            }
            this._LabUkupnoDuguje.Text = num.ToString("N2");
            this._LabUkupnoPotrazuje.Text = num2.ToString("N2");
            this._LabUkupno.Text = (num2 - num).ToString("N2");
        }

        private void Reload()
        {
            OleDbConnection connection = new OleDbConnection(Connection.ConnectionString);
            OleDbDataReader reader = null;
            OleDbCommand command = null;
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "Select * From Finansije Where Finansije.KontaktId=" + this._Id;
                reader = command.ExecuteReader();
                FPromenaItem item = null;
                this._Items.Clear();
                while (reader.Read())
                {
                    DateTime time;
                    item = new FPromenaItem
                    {
                        Id = reader.GetInt32(0),
                        Datum = reader.GetDateTime(2)
                    };
                    if (!reader.IsDBNull(3))
                    {
                        item.Duguje = reader.GetDecimal(3);
                    }
                    if (!reader.IsDBNull(4))
                    {
                        item.Potrazuje = reader.GetDecimal(4);
                    }
                    item.Opis = reader.GetString(5);
                    item.Status = ItemStatus.Old;
                    bool flag = true;
                    if ((this._DtOd.Value != null) && ((time = (DateTime)this._DtOd.Value).Date > item.Datum.Date))
                    {
                        flag = false;
                    }
                    if ((this._DtDo.Value != null) && ((time = (DateTime)this._DtDo.Value).Date < item.Datum.Date))
                    {
                        flag = false;
                    }
                    if (flag)
                    {
                        int index = 0;
                        foreach (FPromenaItem item2 in this._Items)
                        {
                            if (item2.Datum.Date > item.Datum.Date)
                            {
                                break;
                            }
                            index++;
                        }
                        this._Items.Insert(index, item);
                    }
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                connection.Close();
            }
            this.ReCalc();
        }
    }
}
