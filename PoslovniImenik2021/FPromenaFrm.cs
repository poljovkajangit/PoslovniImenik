using System;
using System.Windows.Forms;

namespace PoslovniImenik
{
    public partial class FPromenaFrm : Form
    {
        private Label label1;
        private DateTimePicker _DtDatum;
        private TextBox _TbOpis;
        private Label label4;
        private Button _BtnPrihvati;
        private Button _BtnOdustani;
        private Panel panel1;
        private TextBox _TbPotrazuje;
        private Label label5;
        private TextBox _TbDuguje;
        private Label label3;


        public FPromenaFrm()
        {
            InitializeComponent();
        }

        private void _TbDuguje_Enter(object sender, EventArgs e)
        {
            this._TbDuguje.SelectAll();
        }

        private void _TbPotrazuje_Enter(object sender, EventArgs e)
        {
            this._TbPotrazuje.SelectAll();
        }

        private void FPromenaFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                decimal result = 0M;
                if (!decimal.TryParse(this._TbDuguje.Text, out result))
                {
                    MessageBox.Show("Molim, unesite ispravnu vrednost u polje dugovanja");
                    this._TbDuguje.Focus();
                    e.Cancel = true;
                }
                else if (!decimal.TryParse(this._TbPotrazuje.Text, out result))
                {
                    MessageBox.Show("Molim, unesite ispravnu vrednost u polje potrazivanja");
                    this._TbPotrazuje.Focus();
                    e.Cancel = true;
                }
            }
        }

        public static FPromenaItem Izmeni(FPromenaItem item)
        {
            FPromenaFrm frm = new FPromenaFrm
            {
                Text = "Izmena promene",
                _DtDatum = { Value = item.Datum },
                _TbDuguje = { Text = item.Duguje.ToString() },
                _TbPotrazuje = { Text = item.Potrazuje.ToString() },
                _TbOpis = { Text = item.Opis }
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                FPromenaItem item2 = new FPromenaItem
                {
                    Datum = frm._DtDatum.Value.Date
                };
                decimal result = 0M;
                decimal num2 = 0M;
                decimal.TryParse(frm._TbDuguje.Text, out result);
                decimal.TryParse(frm._TbPotrazuje.Text, out num2);
                item2.Duguje = result;
                item2.Potrazuje = num2;
                item2.Opis = frm._TbOpis.Text;
                item2.Id = item.Id;
                if ((item.Status == ItemStatus.Old) || (item.Status == ItemStatus.Deleted))
                {
                    item2.Status = ItemStatus.Updated;
                }
                return item2;
            }
            return null;
        }

        public static FPromenaItem Nova()
        {
            FPromenaFrm frm = new FPromenaFrm
            {
                Text = "Unos nove promene"
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                FPromenaItem item = new FPromenaItem
                {
                    Datum = frm._DtDatum.Value.Date
                };
                decimal result = 0M;
                decimal num2 = 0M;
                decimal.TryParse(frm._TbDuguje.Text, out result);
                decimal.TryParse(frm._TbPotrazuje.Text, out num2);
                item.Duguje = result;
                item.Potrazuje = num2;
                item.Opis = frm._TbOpis.Text;
                item.Status = ItemStatus.New;
                return item;
            }
            return null;
        }

    }
}
