using System.ComponentModel;
using System.Windows.Forms;

namespace PoslovniImenik
{
    public partial class TextInputFrm : Form
    {
        private TextBox _TbInput;
        private Button _BtnOdustani;
        private Button _BtnPrihvati;

        // Methods
        public TextInputFrm()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        public static DialogResult Input(ref string text, string caption, bool asPassword)
        {
            TextInputFrm frm = new TextInputFrm();
            if (asPassword)
            {
                frm._TbInput.PasswordChar = '*';
            }
            frm.Text = caption;
            frm._TbInput.Text = text;
            DialogResult result = frm.ShowDialog();
            text = frm._TbInput.Text;
            return result;
        }

    }
}
