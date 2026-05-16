using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System.UIControls
{

    public partial class Tile : UserControl
    {
        public Tile()
        {
            InitializeComponent();
        }

        #region -> Fields
        private Color backColor = Color.White;
        private Color foreColor = Color.Black;
        private Color borderColor = Color.White;
        private Image tileImage = Properties.Resources.apps_add__1_;
        private int radius = 20;
        private int thickness = 2;

        private string bottomText = "999999";
        private string topText = "Total Stock";
        private System.Drawing.Size imageSize = new System.Drawing.Size(32, 32);
        private float rowPercent = 50;

        #endregion

        #region -> Properties
        [Category("Appearance")]
        [Description("Gets or sets the text for the top label.")]
        public string TopText
        {
            get { return topText; }
            set
            {
                topText = value;
                lbTop.Text = value;
            }
        }

        [Category("Appearance")]
        [Description("Gets or sets the text for the bottom label.")]
        public string BottomText
        {
            get { return bottomText; }
            set
            {
                bottomText = value;
                lbBottom.Text = value;
            }
        }

        [Category("Appearance")]
        [Description("Changes the percentage for the row.")]
        public float RowPercent
        {
            get { return rowPercent; }
            set
            {
                if (value < 0) value = 0;
                if (value > 100) value = 100;
                rowPercent = value;

                if (tableLayoutPanel1 != null && tableLayoutPanel1.RowStyles.Count >= 3)
                {
                    tableLayoutPanel1.SuspendLayout();

                    tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Percent;
                    tableLayoutPanel1.RowStyles[1].Height = value;

                    tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Percent;
                    tableLayoutPanel1.RowStyles[2].Height = 100 - value;

                    tableLayoutPanel1.ResumeLayout();
                    tableLayoutPanel1.PerformLayout();
                }
            }
        }

        [Category("Appearance")]
        [Description("Gets or sets the image for the picture box.")]
        public Image TileImage
        {
            get { return tileImage; }
            set
            {
                tileImage = value;

                pictureBox1.Image = value;
            }
        }

        [Category("Appearance")]
        [Description("Gets or sets the image size for the picture box.")]
        public System.Drawing.Size ImageSize
        {
            get { return imageSize; }
            set
            {
                imageSize = value;
                pictureBox1.Size = value;
            }
        }

        [Category("Appearance")]
        [Description("Gets or sets the radius for the rounded panel.")]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                roundedPanel3.Radius = value;
            }
        }

        [Category("Appearance")]
        [Description("Gets or sets the thickness for the rounded panel.")]
        public int Thickness
        {
            get { return thickness; }
            set
            {
                thickness = value;
                roundedPanel3.Thickness = value;
            }
        }

        [Category("Appearance")]
        [Description("Gets or sets the background color for the rounded panel.")]
        public Color BackColors
        {
            get { return backColor; }
            set
            {
                backColor = value;
                roundedPanel3.BackColor = value;
            }
        }

        [Category("Appearance")]
        [Description("Gets or sets the foreground color for the labels.")]
        public Color ForeColors
        {
            get { return foreColor; }
            set
            {
                foreColor = value;
                lbTop.ForeColor = value;
                lbBottom.ForeColor = value;
            }
        }

        [Category("Appearance")]
        [Description("Gets or sets the border color for the rounded panel.")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                roundedPanel3.BorderColor = value;
            }
        }

        #endregion
    }
}