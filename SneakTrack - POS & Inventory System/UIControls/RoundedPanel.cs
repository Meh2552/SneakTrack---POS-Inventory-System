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

        private Rectangle GetLeftUpper(int e)
        {
            return new Rectangle(0, 0, e, e);
        }
        private Rectangle GetRightUpper(int e)
        {
            return new Rectangle(Width - e, 0, e, e);
        }
        private Rectangle GetRightLower(int e)
        {
            return new Rectangle(Width - e, Height - e, e, e);
        }
        private Rectangle GetLeftLower(int e)
        {
            return new Rectangle(0, Height - e, e, e);
        }

        private void ExtendedDraw(PaintEventArgs e)
        {
            // Prevent drawing with invalid dimensions
            if (Width <= 0 || Height <= 0 || Radius <= 0)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                // Ensure radius doesn't exceed half of the smallest dimension
                int actualRadius = Math.Min(Radius, Math.Min(Width / 2, Height / 2));

                path.StartFigure();
                path.AddArc(GetLeftUpper(actualRadius), 180, 90);
                path.AddLine(actualRadius, 0, Width - actualRadius, 0);
                path.AddArc(GetRightUpper(actualRadius), 270, 90);
                path.AddLine(Width, actualRadius, Width, Height - actualRadius);
                path.AddArc(GetRightLower(actualRadius), 0, 90);
                path.AddLine(Width - actualRadius, Height, actualRadius, Height);
                path.AddArc(GetLeftLower(actualRadius), 90, 90);
                path.AddLine(0, Height - actualRadius, 0, actualRadius);
                path.CloseFigure();

                Region = new Region(path);
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