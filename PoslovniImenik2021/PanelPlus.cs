using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PoslovniImenik
{
    public class PanelPlus : Panel
    {
        // Fields
        private Bitmap _Image = null;
        private Color _StartColor = Color.White;
        private Color _EndColor = Color.Gray;
        private Color _BorderColor = Color.Gray;
        private int _Radius = 6;
        private LinearGradientMode _GradinetMode = LinearGradientMode.ForwardDiagonal;

        // Methods
        protected override void OnControlAdded(ControlEventArgs e)
        {
            this._Image = null;
            base.Invalidate();
            base.OnControlAdded(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            EventHandler handler = null;
            EventHandler handler2 = null;
            EventHandler handler3 = null;
            if (this._Image == null)
            {
                Bitmap image = new Bitmap(base.Width, base.Height);
                Graphics graphics = Graphics.FromImage(image);
                Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
                LinearGradientBrush brush = new LinearGradientBrush(rect, this._StartColor, this._EndColor, this._GradinetMode);
                GraphicsPath path = RoundedRectangle.Create(0, 0, base.Width - 1, base.Height - 1, this._Radius, RoundedRectangle.RectangleCorners.All);
                graphics.FillPath(brush, path);
                graphics.DrawPath(new Pen(this._BorderColor, 1f), path);
                foreach (Control control in base.Controls)
                {
                    if (control is TextBox)
                    {
                        path = RoundedRectangle.Create(control.Left - 3, control.Top - 3, control.Width + 5, control.Height + 5, 2, RoundedRectangle.RectangleCorners.All);
                        graphics.FillPath(new SolidBrush((control as TextBox).ReadOnly ? this._EndColor : (control as TextBox).BackColor), path);
                        graphics.DrawPath(new Pen(this._BorderColor, 1f), path);
                        if (handler == null)
                        {
                            handler = delegate {
                                this._Image = null;
                                base.Invalidate();
                            };
                        }
                        (control as TextBox).LocationChanged += handler;
                        if (handler2 == null)
                        {
                            handler2 = delegate {
                                this._Image = null;
                                base.Invalidate();
                            };
                        }
                        (control as TextBox).SizeChanged += handler2;
                        if (handler3 == null)
                        {
                            handler3 = delegate {
                                this._Image = null;
                                base.Invalidate();
                            };
                        }
                        (control as TextBox).BackColorChanged += handler3;
                        if ((control as TextBox).ReadOnly)
                        {
                            (control as TextBox).BackColor = this._EndColor;
                        }
                        (control as TextBox).BorderStyle = BorderStyle.None;
                    }
                }
                this.BackgroundImageLayout = ImageLayout.None;
                this._Image = image;
                this.BackgroundImage = this._Image;
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            this._Image = null;
            base.Invalidate();
            base.OnResize(eventargs);
        }

        // Properties
        [DefaultValue(2)]
        public LinearGradientMode GradinetMode
        {
            get
            {
                return this._GradinetMode;
            }
            set
            {
                if (value != this._GradinetMode)
                {
                    this._GradinetMode = value;
                    this._Image = null;
                    base.Invalidate();
                }
            }
        }

        [DefaultValue(6)]
        public int AngleRadius
        {
            get
            {
                return this._Radius;
            }
            set
            {
                if (value != this._Radius)
                {
                    this._Radius = value;
                    this._Image = null;
                    base.Invalidate();
                }
            }
        }

        public Color StartColor
        {
            get
            {
                return this._StartColor;
            }
            set
            {
                if (this._StartColor != value)
                {
                    this._StartColor = value;
                    this._Image = null;
                    base.Invalidate();
                }
            }
        }

        public Color EndColor
        {
            get
            {
                return this._EndColor;
            }
            set
            {
                if (this._EndColor != value)
                {
                    this._EndColor = value;
                    this._Image = null;
                    base.Invalidate();
                }
            }
        }

        public Color BorderColor
        {
            get
            {
                return this._BorderColor;
            }
            set
            {
                if (this._BorderColor != value)
                {
                    this._BorderColor = value;
                    this._Image = null;
                    base.Invalidate();
                }
            }
        }
    }
}
