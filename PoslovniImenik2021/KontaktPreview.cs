using System.Collections.Generic;
using System.ComponentModel;

namespace PoslovniImenik
{
    public class KontaktPreview
    {
        public long Id { get; set; }

        public long Grupa { get; set; }

        public string Naziv { get; set; }

        public string Adresa { get; set; }

        public string Mesto { get; set; }

        public List<string> Telefoni { get; set; }

        public string Fax { get; set; }

        public string PIB { get; set; }

        public string Email { get; set; }

        public string Web { get; set; }

        public string Delatnost { get; set; }

        public string Napomena { get; set; }

        public string PrezimeIme { get; set; }

        public string Drzava { get; set; }

        public string FolderLocation { get; set; }

        [Browsable(false)]
        public string Ostalo { get; set; }
    }
}
