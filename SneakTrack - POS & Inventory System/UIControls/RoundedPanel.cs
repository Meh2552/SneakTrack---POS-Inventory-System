using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace SneakTrack___POS___Inventory_System.UIControls
{
    [DesignerCategory("Component")]
    public class RoundedPanel : Panel
    {
        private float _thickness = 5;
        public float Thickness
        {
            get
            {
                return _thickness;
            }
            set
            {
                _thickness = value;
                if (_pen != null)
                {
                    _pen.Dispose();
                }
                _pen = new Pen(_borderColor, Thickness);
                Invalidate();
            }
        }

        private Color _borderColor = Color.White;
        public Color BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
                if (_pen != null)
                {
                    _pen.Dispose();
                }
                _pen = new Pen(_borderColor, Thickness);
                Invalidate();
            }
        }

        private int _radius = 20;
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
                Invalidate();
            }
        }

        private Pen _pen;

        public RoundedPanel() : base()
        {
            _pen = new Pen(BorderColor, Thickness);
            DoubleBuffered = true;
            // Set default size to prevent 0 width/height issues
            this.Size = new Size(100, 100);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_pen != null)
                {
                    _pen.Dispose();
                    _pen = null;
                }
            }
            base.Dispose(disposing);
        }

        private void ExtendedDraw(PaintEventArgs e)
        {
            if (Width <= 0 || Height <= 0 || Radius <= 0)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                int r = Math.Min(Radius, Math.Min(Width / 2, Height / 2));
                int w = Width - 1;  // 👈 -1 to stay within bounds
                int h = Height - 1;

                path.StartFigure();

                // Top-left
                path.AddArc(0, 0, r * 2, r * 2, 180, 90);

                // Top-right
                path.AddArc(w - r * 2, 0, r * 2, r * 2, 270, 90);

                // Bottom-right
                path.AddArc(w - r * 2, h - r * 2, r * 2, r * 2, 0, 90);

                // Bottom-left
                path.AddArc(0, h - r * 2, r * 2, r * 2, 90, 90);

                path.CloseFigure();

                Region = new Region(path);

                // Draw border
                using (Pen pen = new Pen(BorderColor, Thickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                // Fill background
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        private void DrawSingleBorder(Graphics graphics)
        {
            // Prevent drawing with invalid dimensions
            if (Width <= 0 || Height <= 0 || Radius <= 0 || _pen == null)
                return;

            // Ensure radius doesn't exceed half of the smallest dimension
            int actualRadius = Math.Min(Radius, Math.Min(Width / 2, Height / 2));

            graphics.DrawArc(_pen, new Rectangle(0, 0, actualRadius, actualRadius), 180, 90);
            graphics.DrawArc(_pen, new Rectangle(Width - actualRadius - 1, -1, actualRadius, actualRadius), 270, 90);
            graphics.DrawArc(_pen, new Rectangle(Width - actualRadius - 1, Height - actualRadius - 1, actualRadius, actualRadius), 0, 90);
            graphics.DrawArc(_pen, new Rectangle(0, Height - actualRadius - 1, actualRadius, actualRadius), 90, 90);
            graphics.DrawRectangle(_pen, 0.0f, 0.0f, (float)Width - 1.0f, (float)Height - 1.0f);
        }

        private void DrawBorder(Graphics graphics)
        {
            DrawSingleBorder(graphics);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Add safety check for design-time and runtime
            if (Width > 0 && Height > 0)
            {
                base.OnPaint(e);
                ExtendedDraw(e);
                DrawBorder(e.Graphics);
            }
            else
            {
                base.OnPaint(e);
            }
        }

        // Override to refresh on resize
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }
    }
}