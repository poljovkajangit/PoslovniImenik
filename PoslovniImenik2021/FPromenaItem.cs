using PoslovniImenik.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PoslovniImenik
{
    public class FPromenaItem
    {
        // Methods
        public FPromenaItem()
        {
            this.Status = ItemStatus.Old;
        }

        // Properties
        [Browsable(false)]
        public long Id { get; set; }

        public DateTime Datum { get; set; }

        public decimal Duguje { get; set; }

        public decimal Potrazuje { get; set; }

        public string Opis { get; set; }

        [Browsable(false)]
        public ItemStatus Status { get; set; }

        public Image StatusImage
        {
            get
            {
                if (this.Status == ItemStatus.Deleted)
                {
                    return Resources.cross;
                }
                if (this.Status == ItemStatus.New)
                {
                    return Resources.add;
                }
                if (this.Status == ItemStatus.Updated)
                {
                    return Resources.page_white_edit;
                }
                return new Bitmap(1, 1);
            }
        }
    }
}
