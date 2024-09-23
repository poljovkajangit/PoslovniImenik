using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace PoslovniImenik
{
    public partial class UCKontakt : UserControl
    {
        // Fields
        private BindingSource _BsKontakt;
        private TextBox _TbNaziv;
        private TextBox _TbPrezimeIme;
        private TextBox _TbMesto;
        private TextBox _TbAdresa;
        private Label label1;
        private TextBox textBox1;
        private TextBox _TbPib;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel _LnkEmail;
        private LinkLabel _LnkWeb;
        private TextBox _TbDelatnost;
        private Label label5;
        private ListBox _LbTelefoni;
        private TextBox _TbNapomena;
        private BindingSource _BsTelefoni;
        private VistaButton _BtnPodsetnik;
        private VistaButton vistaButton1;
        private TextBox _TbDrzava;
        private VistaButton vistaButton2;
        private FrmMain _Forma = null;

        public UCKontakt()
        {
            InitializeComponent();
        }

        private void _BtnPodsetnik_Click(object sender, EventArgs e)
        {
            KarticaPromenaFrm.Prikazi((this._BsKontakt.Current as KontaktPreview).Id);
        }
        private void _LnkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Process { StartInfo = { FileName = "mailto:" + this._LnkEmail.Text } }.Start();
        }

        private void _LnkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Process
            {
                StartInfo = {
            FileName = GetDefaultBrowserPath(),
            Arguments = this._LnkWeb.Text
        }
            }.Start();
        }

        private static string GetDefaultBrowserPath()
        {
            string name = @"http\shell\open\command";
            return StringToPath((string)Registry.ClassesRoot.OpenSubKey(name, false).GetValue(null, null));
        }

        public void Present(KontaktPreview kontakt, FrmMain forma)
        {
            this._BsKontakt.DataSource = kontakt;
            this._BsTelefoni.DataSource = kontakt.Telefoni;
            this._BsKontakt.ResumeBinding();
            this._LbTelefoni.SelectedIndex = -1;
            this._Forma = forma;
        }

        private static string StringToPath(string str)
        {
            char ch = ' ';
            int startIndex = 0;
            if (str[0] == '"')
            {
                ch = '"';
                startIndex = 1;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    return str.Substring(startIndex, i - startIndex);
                }
            }
            return str;
        }

        private void vistaButton1_Click(object sender, EventArgs e)
        {
            this._Forma.Edit();
        }

        private void vistaButton2_Click(object sender, EventArgs e)
        {
            this._Forma.Delete();
        }

        private void _CloseBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void lblDokumenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var path = (this._BsKontakt.DataSource as KontaktPreview).FolderLocation;
            if (!string.IsNullOrEmpty(path))
            {
                //Process.Start("explorer.exe", @fl);

                path = string.Format("\"{0}\"", path);
                var runExplorer = new ProcessStartInfo
                {
                    FileName = "explorer.exe",
                    Arguments = path
                };
                Process.Start(runExplorer);
            }
            else
            {
                MessageBox.Show("Folder nije definisan.", "Poslovni imenik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
