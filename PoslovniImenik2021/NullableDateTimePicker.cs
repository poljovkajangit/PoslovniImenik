using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PoslovniImenik
{
    [ComVisible(false)]
    public class NullableDateTimePicker : DateTimePicker
    {
        private bool _isNull;
        private string _nullValue;
        private DateTimePickerFormat _format;
        private string _customFormat;
        private string _formatAsString;

        public NullableDateTimePicker()
        {
            base.Format = DateTimePickerFormat.Custom;
            this.NullValue = " ";
            this.Format = DateTimePickerFormat.Long;
        }

        protected override void OnCloseUp(EventArgs e)
        {
            if ((Control.MouseButtons == MouseButtons.None) && this._isNull)
            {
                this.SetToDateTimeValue();
                this._isNull = false;
            }
            base.OnCloseUp(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.Value = null;
                this.OnValueChanged(EventArgs.Empty);
            }
            base.OnKeyUp(e);
        }

        private void SetFormat()
        {
            DateTimeFormatInfo dateTimeFormat = Thread.CurrentThread.CurrentCulture.DateTimeFormat;
            switch (this._format)
            {
                case DateTimePickerFormat.Long:
                    this.FormatAsString = dateTimeFormat.LongDatePattern;
                    break;

                case DateTimePickerFormat.Short:
                    this.FormatAsString = dateTimeFormat.ShortDatePattern;
                    break;

                case DateTimePickerFormat.Time:
                    this.FormatAsString = dateTimeFormat.ShortTimePattern;
                    break;

                case DateTimePickerFormat.Custom:
                    this.FormatAsString = this.CustomFormat;
                    break;
            }
        }

        private void SetToDateTimeValue()
        {
            if (this._isNull)
            {
                this.SetFormat();
                this._isNull = false;
                base.OnValueChanged(new EventArgs());
            }
        }

        private void SetToNullValue()
        {
            this._isNull = true;
            base.CustomFormat = ((this._nullValue == null) || (this._nullValue == string.Empty)) ? " " : ("'" + this._nullValue + "'");
        }

        // Properties
        public new object Value
        {
            get
            {
                if (this._isNull)
                {
                    return null;
                }
                return base.Value;
            }
            set
            {
                if ((value == null) || (value == DBNull.Value))
                {
                    this.SetToNullValue();
                }
                else
                {
                    this.SetToDateTimeValue();
                    base.Value = (DateTime)value;
                }
            }
        }

        [DefaultValue(1), TypeConverter(typeof(Enum)), Browsable(true)]
        public new DateTimePickerFormat Format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
                this.SetFormat();
                this.OnFormatChanged(EventArgs.Empty);
            }
        }

        public new string CustomFormat
        {
            get
            {
                return this._customFormat;
            }
            set
            {
                this._customFormat = value;
            }
        }

        [Category("Behavior"), DefaultValue(" "), Description("The string used to display null values in the control"), Browsable(true)]
        public string NullValue
        {
            get
            {
                return this._nullValue;
            }
            set
            {
                this._nullValue = value;
            }
        }

        private string FormatAsString
        {
            get
            {
                return this._formatAsString;
            }
            set
            {
                this._formatAsString = value;
                base.CustomFormat = value;
            }
        }
    }
}
