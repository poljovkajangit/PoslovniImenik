using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PoslovniImenik
{

    public enum Style
    {
        Default,
        Flat
    }

    [DefaultEvent("Click")]
    public partial class VistaButton : UserControl
    {
        // Fields
        private bool calledbykey = false;
        private State mButtonState = State.None;
        private Timer mFadeIn = new Timer();
        private Timer mFadeOut = new Timer();
        private int mGlowAlpha = 0;
        private string mText;
        private Color mForeColor = Color.White;
        private ContentAlignment mTextAlign = ContentAlignment.MiddleCenter;
        private Image mImage;
        private ContentAlignment mImageAlign = ContentAlignment.MiddleLeft;
        private Size mImageSize = new Size(0x18, 0x18);
        private Style mButtonStyle = Style.Default;
        private int mCornerRadius = 8;
        private Color mHighlightColor = Color.White;
        private Color mButtonColor = Color.Black;
        private Color mGlowColor = Color.FromArgb(0x8d, 0xbd, 0xff);
        private Image mBackImage;
        private Color mBaseColor = Color.LightGreen;

        // Methods
        public VistaButton()
        {
            this.InitializeComponent();
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.SetStyle(ControlStyles.Selectable, true);
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;
            this.mFadeIn.Interval = 30;
            this.mFadeOut.Interval = 30;
        }
        private void DrawBackground(Graphics g)
        {
            if ((this.ButtonStyle != Style.Flat) || (this.mButtonState != State.None))
            {
                int alpha = (this.mButtonState == State.Pressed) ? 0xcc : 0x7f;
                Rectangle clientRectangle = base.ClientRectangle;
                clientRectangle.Width--;
                clientRectangle.Height--;
                using (GraphicsPath path = this.RoundRect(clientRectangle, (float)this.CornerRadius, (float)this.CornerRadius, (float)this.CornerRadius, (float)this.CornerRadius))
                {
                    SolidBrush brush;
                    using (brush = new SolidBrush(this.BaseColor))
                    {
                        g.FillPath(brush, path);
                    }
                    this.SetClip(g);
                    if (this.BackImage != null)
                    {
                        g.DrawImage(this.BackImage, base.ClientRectangle);
                    }
                    g.ResetClip();
                    using (brush = new SolidBrush(Color.FromArgb(alpha, this.ButtonColor)))
                    {
                        g.FillPath(brush, path);
                    }
                }
            }
        }
        private void DrawGlow(Graphics g)
        {
            if (this.mButtonState != State.Pressed)
            {
                this.SetClip(g);
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(-5, (base.Height / 2) - 10, base.Width + 11, base.Height + 11);
                    using (PathGradientBrush brush = new PathGradientBrush(path))
                    {
                        brush.CenterColor = Color.FromArgb(this.mGlowAlpha, this.GlowColor);
                        brush.SurroundColors = new Color[] { Color.FromArgb(0, this.GlowColor) };
                        g.FillPath(brush, path);
                    }
                }
                g.ResetClip();
            }
        }
        private void DrawHighlight(Graphics g)
        {
            if ((this.ButtonStyle != Style.Flat) || (this.mButtonState != State.None))
            {
                int alpha = (this.mButtonState == State.Pressed) ? 60 : 150;
                Rectangle r = new Rectangle(0, 0, base.Width, base.Height / 2);
                using (GraphicsPath path = this.RoundRect(r, (float)this.CornerRadius, (float)this.CornerRadius, 0f, 0f))
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(path.GetBounds(), Color.FromArgb(alpha, this.HighlightColor), Color.FromArgb(alpha / 3, this.HighlightColor), LinearGradientMode.Vertical))
                    {
                        g.FillPath(brush, path);
                    }
                }
            }
        }
        private void DrawImage(Graphics g)
        {
            if (this.Image != null)
            {
                Rectangle rect = new Rectangle(8, 8, this.ImageSize.Width, this.ImageSize.Height);
                switch (this.ImageAlign)
                {
                    case ContentAlignment.TopCenter:
                        rect = new Rectangle((base.Width / 2) - (this.ImageSize.Width / 2), 8, this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.TopRight:
                        rect = new Rectangle((base.Width - 8) - this.ImageSize.Width, 8, this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.MiddleLeft:
                        rect = new Rectangle(8, (base.Height / 2) - (this.ImageSize.Height / 2), this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.MiddleCenter:
                        rect = new Rectangle((base.Width / 2) - (this.ImageSize.Width / 2), (base.Height / 2) - (this.ImageSize.Height / 2), this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.BottomCenter:
                        rect = new Rectangle((base.Width / 2) - (this.ImageSize.Width / 2), (base.Height - 8) - this.ImageSize.Height, this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.BottomRight:
                        rect = new Rectangle((base.Width - 8) - this.ImageSize.Width, (base.Height - 8) - this.ImageSize.Height, this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.MiddleRight:
                        rect = new Rectangle((base.Width - 8) - this.ImageSize.Width, (base.Height / 2) - (this.ImageSize.Height / 2), this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.BottomLeft:
                        rect = new Rectangle(8, (base.Height - 8) - this.ImageSize.Height, this.ImageSize.Width, this.ImageSize.Height);
                        break;
                }
                g.DrawImage(this.Image, rect);
            }
        }
        private void DrawInnerStroke(Graphics g)
        {
            if ((this.ButtonStyle != Style.Flat) || (this.mButtonState != State.None))
            {
                Rectangle clientRectangle = base.ClientRectangle;
                clientRectangle.X++;
                clientRectangle.Y++;
                clientRectangle.Width -= 3;
                clientRectangle.Height -= 3;
                using (GraphicsPath path = this.RoundRect(clientRectangle, (float)this.CornerRadius, (float)this.CornerRadius, (float)this.CornerRadius, (float)this.CornerRadius))
                {
                    using (Pen pen = new Pen(this.HighlightColor))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }
        }
        private void DrawOuterStroke(Graphics g)
        {
            if ((this.ButtonStyle != Style.Flat) || (this.mButtonState != State.None))
            {
                Rectangle clientRectangle = base.ClientRectangle;
                clientRectangle.Width--;
                clientRectangle.Height--;
                using (GraphicsPath path = this.RoundRect(clientRectangle, (float)this.CornerRadius, (float)this.CornerRadius, (float)this.CornerRadius, (float)this.CornerRadius))
                {
                    using (Pen pen = new Pen(this.ButtonColor))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }
        }
        private void DrawText(Graphics g)
        {
            StringFormat format = this.StringFormatAlignment(this.TextAlign);
            Rectangle layoutRectangle = new Rectangle(8, 8, base.Width - 0x11, base.Height - 0x11);
            g.DrawString(this.ButtonText, this.Font, new SolidBrush(this.ForeColor), layoutRectangle, format);
        }

        private void mFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.ButtonStyle == Style.Flat)
            {
                this.mGlowAlpha = 0;
            }
            if ((this.mGlowAlpha + 30) >= 0xff)
            {
                this.mGlowAlpha = 0xff;
                this.mFadeIn.Stop();
            }
            else
            {
                this.mGlowAlpha += 30;
            }
            base.Invalidate();
        }

        private void mFadeOut_Tick(object sender, EventArgs e)
        {
            if (this.ButtonStyle == Style.Flat)
            {
                this.mGlowAlpha = 0;
            }
            if ((this.mGlowAlpha - 30) <= 0)
            {
                this.mGlowAlpha = 0;
                this.mFadeOut.Stop();
            }
            else
            {
                this.mGlowAlpha -= 30;
            }
            base.Invalidate();
        }
        private GraphicsPath RoundRect(RectangleF r, float r1, float r2, float r3, float r4)
        {
            float x = r.X;
            float y = r.Y;
            float width = r.Width;
            float height = r.Height;
            GraphicsPath path = new GraphicsPath();
            path.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
            path.AddLine(x + r1, y, (x + width) - r2, y);
            path.AddBezier((x + width) - r2, y, x + width, y, x + width, y + r2, x + width, y + r2);
            path.AddLine((float)(x + width), (float)(y + r2), (float)(x + width), (float)((y + height) - r3));
            path.AddBezier((float)(x + width), (float)((y + height) - r3), (float)(x + width), (float)(y + height), (float)((x + width) - r3), (float)(y + height), (float)((x + width) - r3), (float)(y + height));
            path.AddLine((float)((x + width) - r3), (float)(y + height), (float)(x + r4), (float)(y + height));
            path.AddBezier(x + r4, y + height, x, y + height, x, (y + height) - r4, x, (y + height) - r4);
            path.AddLine(x, (y + height) - r4, x, y + r1);
            return path;
        }
        private void SetClip(Graphics g)
        {
            Rectangle clientRectangle = base.ClientRectangle;
            clientRectangle.X++;
            clientRectangle.Y++;
            clientRectangle.Width -= 3;
            clientRectangle.Height -= 3;
            using (GraphicsPath path = this.RoundRect(clientRectangle, (float)this.CornerRadius, (float)this.CornerRadius, (float)this.CornerRadius, (float)this.CornerRadius))
            {
                g.SetClip(path);
            }
        }
        private StringFormat StringFormatAlignment(ContentAlignment textalign)
        {
            StringFormat format = new StringFormat();
            switch (textalign)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.TopCenter:
                case ContentAlignment.TopRight:
                    format.LineAlignment = StringAlignment.Near;
                    break;

                case ContentAlignment.MiddleLeft:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.MiddleRight:
                    format.LineAlignment = StringAlignment.Center;
                    break;

                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomRight:
                case ContentAlignment.BottomLeft:
                    format.LineAlignment = StringAlignment.Far;
                    break;
            }
            ContentAlignment alignment = textalign;
            if (alignment <= ContentAlignment.MiddleCenter)
            {
                switch (alignment)
                {
                    case ContentAlignment.TopLeft:
                    case ContentAlignment.MiddleLeft:
                        goto Label_00CD;

                    case ContentAlignment.TopCenter:
                    case ContentAlignment.MiddleCenter:
                        goto Label_00D7;

                    case (ContentAlignment.TopCenter | ContentAlignment.TopLeft):
                        return format;

                    case ContentAlignment.TopRight:
                        goto Label_00E1;
                }
                return format;
            }
            if (alignment <= ContentAlignment.BottomLeft)
            {
                switch (alignment)
                {
                    case ContentAlignment.MiddleRight:
                        goto Label_00E1;

                    case ContentAlignment.BottomLeft:
                        goto Label_00CD;
                }
                return format;
            }
            switch (alignment)
            {
                case ContentAlignment.BottomCenter:
                    goto Label_00D7;

                case ContentAlignment.BottomRight:
                    goto Label_00E1;

                default:
                    return format;
            }
        Label_00CD:
            format.Alignment = StringAlignment.Near;
            return format;
        Label_00D7:
            format.Alignment = StringAlignment.Center;
            return format;
        Label_00E1:
            format.Alignment = StringAlignment.Far;
            return format;
        }
        private void VistaButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                MouseEventArgs args = new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0);
                this.VistaButton_MouseDown(sender, args);
            }
        }
        private void VistaButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                MouseEventArgs args = new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0);
                this.calledbykey = true;
                this.VistaButton_MouseUp(sender, args);
            }
        }
        private void VistaButton_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    this.mButtonState = State.Pressed;
            //    if (this.mButtonStyle != Style.Flat)
            //    {
            //        this.mGlowAlpha = 0xff;
            //    }
            //    this.mFadeIn.Stop();
            //    this.mFadeOut.Stop();
            //    base.Invalidate();
            //}
        }
        private void VistaButton_MouseEnter(object sender, EventArgs e)
        {
            this.mButtonState = State.Hover;
            this.mFadeOut.Stop();
            this.mFadeIn.Start();
        }
        private void VistaButton_MouseLeave(object sender, EventArgs e)
        {
            this.mButtonState = State.None;
            if (this.mButtonStyle == Style.Flat)
            {
                this.mGlowAlpha = 0;
            }
            this.mFadeIn.Stop();
            this.mFadeOut.Start();
        }
        private void VistaButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.mButtonState = State.Hover;
                this.mFadeIn.Stop();
                this.mFadeOut.Stop();
                base.Invalidate();
                if (this.calledbykey)
                {
                    this.OnClick(EventArgs.Empty);
                    this.calledbykey = false;
                }
            }
        }
        private void VistaButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            this.DrawBackground(e.Graphics);
            this.DrawHighlight(e.Graphics);
            this.DrawImage(e.Graphics);
            this.DrawText(e.Graphics);
            this.DrawGlow(e.Graphics);
            this.DrawOuterStroke(e.Graphics);
            this.DrawInnerStroke(e.Graphics);
        }
        private void VistaButton_Resize(object sender, EventArgs e)
        {
            Rectangle clientRectangle = base.ClientRectangle;
            clientRectangle.X--;
            clientRectangle.Y--;
            clientRectangle.Width += 2;
            clientRectangle.Height += 2;
            using (GraphicsPath path = this.RoundRect(clientRectangle, (float)this.CornerRadius, (float)this.CornerRadius, (float)this.CornerRadius, (float)this.CornerRadius))
            {
                base.Region = new Region(path);
            }
        }

        // Properties
        [Category("Text"), Description("The text that is displayed on the button.")]
        public string ButtonText
        {
            get
            {
                return this.mText;
            }
            set
            {
                this.mText = value;
                base.Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "White"), Description("The color with which the text is drawn."), Category("Text"), Browsable(true)]
        public override Color ForeColor
        {
            get
            {
                return this.mForeColor;
            }
            set
            {
                this.mForeColor = value;
                base.Invalidate();
            }
        }

        [Category("Text"), DefaultValue(typeof(ContentAlignment), "MiddleCenter"), Description("The alignment of the button text that is displayed on the control.")]
        public ContentAlignment TextAlign
        {
            get
            {
                return this.mTextAlign;
            }
            set
            {
                this.mTextAlign = value;
                base.Invalidate();
            }
        }

        [DefaultValue((string)null), Category("Image"), Description("The image displayed on the button that is used to help the user identifyit's function if the text is ambiguous.")]
        public Image Image
        {
            get
            {
                return this.mImage;
            }
            set
            {
                this.mImage = value;
                base.Invalidate();
            }
        }

        [DefaultValue(typeof(ContentAlignment), "MiddleLeft"), Category("Image"), Description("The alignment of the image in relation to the button.")]
        public ContentAlignment ImageAlign
        {
            get
            {
                return this.mImageAlign;
            }
            set
            {
                this.mImageAlign = value;
                base.Invalidate();
            }
        }

        [Description("The size of the image to be displayed on thebutton. This property defaults to 24x24."), DefaultValue(typeof(Size), "24, 24"), Category("Image")]
        public Size ImageSize
        {
            get
            {
                return this.mImageSize;
            }
            set
            {
                this.mImageSize = value;
                base.Invalidate();
            }
        }

        [DefaultValue(typeof(Style), "Default"), Category("Appearance"), Description("Sets whether the button background is drawn while the mouse is outside of the client area.")]
        public Style ButtonStyle
        {
            get
            {
                return this.mButtonStyle;
            }
            set
            {
                this.mButtonStyle = value;
                base.Invalidate();
            }
        }

        [Description("The radius for the button corners. The greater this value is, the more 'smooth' the corners are. This property should not be greater than half of the controls height."), DefaultValue(8), Category("Appearance")]
        public int CornerRadius
        {
            get
            {
                return this.mCornerRadius;
            }
            set
            {
                this.mCornerRadius = value;
                base.Invalidate();
            }
        }

        [Category("Appearance"), Description("The colour of the highlight on the top of the button."), DefaultValue(typeof(Color), "White")]
        public Color HighlightColor
        {
            get
            {
                return this.mHighlightColor;
            }
            set
            {
                this.mHighlightColor = value;
                base.Invalidate();
            }
        }

        [Description("The bottom color of the button that will be drawn over the base color."), Category("Appearance"), DefaultValue(typeof(Color), "Black")]
        public Color ButtonColor
        {
            get
            {
                return this.mButtonColor;
            }
            set
            {
                this.mButtonColor = value;
                base.Invalidate();
            }
        }

        [Description("The colour that the button glows when the mouse is inside the client area."), DefaultValue(typeof(Color), "141,189,255"), Category("Appearance")]
        public Color GlowColor
        {
            get
            {
                return this.mGlowColor;
            }
            set
            {
                this.mGlowColor = value;
                base.Invalidate();
            }
        }

        [Description("The background image for the button, this image is drawn over the base color of the button."), Category("Appearance"), DefaultValue((string)null)]
        public Image BackImage
        {
            get
            {
                return this.mBackImage;
            }
            set
            {
                this.mBackImage = value;
                base.Invalidate();
            }
        }

        [Description("The backing color that the rest ofthe button is drawn. For a glassier effect set this property to Transparent."), DefaultValue(typeof(Color), "Black"), Category("Appearance")]
        public Color BaseColor
        {
            get
            {
                return this.mBaseColor;
            }
            set
            {
                this.mBaseColor = value;
                base.Invalidate();
            }
        }

        // Nested Types
        private enum State
        {
            None,
            Hover,
            Pressed
        }

        public enum Style
        {
            Default,
            Flat
        }

    }
}
