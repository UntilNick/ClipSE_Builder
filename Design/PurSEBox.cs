namespace ClipPurSEditionBuilder.Design
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public class PurSEBox : CheckBox, IPurSEBox
    {
        public PurSEBox()
        {
            this.Translator = "#548E19";
            SetCheckColor("#2F333A");
            this.SnColor2 = ColorTranslator.FromHtml(this.Translator);
            this.SnColor3 = ColorTranslator.FromHtml("#c4c6ca");
            this.SnColor4 = ColorTranslator.FromHtml("#999999");
            this.SnColor5 = ColorTranslator.FromHtml("#babbbd");
            this.sTimer = new Timer
            {
                Interval = 0x28
            };
            this.Dia = 0xE;
            this.Vert = 0x3;
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            this.TabStop = false;
            this.sTimer.Tick += Timer_0_Tick;
        }
        private void Timer_0_Tick(object sender, EventArgs e)
        {
            if (!this.Checked)
            {
                if (this.Horiz > 0)
                {
                    this.Horiz -= 25;
                    Invalidate();
                    if (this.Dia < 14)
                    {
                        this.Dia += 2;
                        Invalidate();
                    }
                    if (this.Vert > 3)
                    {
                        this.Vert--;
                        Invalidate();
                    }
                }
            }
            else
            {
                if (this.Horiz < 0xFA)
                {
                    this.Horiz += 0x19;
                    Invalidate();
                    if (this.Dia > 0x0)
                    {
                        this.Dia -= 0x2;
                        Invalidate();
                    }
                    if (this.Vert < 0xA)
                    {
                        this.Vert++;
                        Invalidate();
                        return;
                    }
                }
            }
        }
        static PurSEBox() => point_0 = new Point[]
        {
           new Point(0x3, 0x8),
           new Point(0x7, 0xC),
           new Point(0xE, 0x5)
        };

        public string GetCheckColor() => this.Translator;

        public void SetCheckColor(string value)
        {
            this.Translator = value;
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            this.Height = 0x14;
            this.Width = 0x14 + (int)CreateGraphics().MeasureString(this.Text, this.Font).Width;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.sTimer.Start();
        }

        private Bitmap GetDrawLike()
        {
            var bitmap = new Bitmap(0x10, 0x10);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.Transparent);
                graphics.DrawLines(new Pen(new SolidBrush(Color.FromArgb(this.Horiz, 0xFF, 0xFF, 0xFF)), 0x2), point_0); // Like color 255  // 0x2 check mark
            }
            return bitmap;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(this.Parent.BackColor);
            this.SnColor = ColorTranslator.FromHtml(this.Translator);
            using (var solidBrush = new SolidBrush(this.Enabled ? (this.Checked ? this.SnColor : this.SnColor2) : this.SnColor3))
            {
                using (var pen = new Pen(solidBrush.Color))
                {
                    GraphicsPath path = GraphBox.Graph1(0x1, 0x1, 0x11, 0x11, 0x1);
                    graphics.FillPath(solidBrush, path);
                    graphics.DrawPath(pen, path);
                    graphics.SmoothingMode = SmoothingMode.None;
                    graphics.FillRectangle(new SolidBrush(Color.FromArgb(0x3E, 0x46, 0x52)), this.Vert, this.Vert, this.Dia, this.Dia);
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.DrawImageUnscaledAndClipped(GetDrawLike(), new Rectangle(0x1, 0x1, 0x10, 0x10));
                    graphics.DrawString(this.Text, this.Font, new SolidBrush(this.Enabled ? this.SnColor4 : this.SnColor5), 0x15, 0x3);
                }
            }
        }

        private static readonly Point[] point_0;
        private string Translator;
        private readonly Timer sTimer;
        private int Vert, Horiz, Dia;
        private Color SnColor;
        private readonly Color SnColor2, SnColor3, SnColor4, SnColor5;
    }
}