using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3951_Lab5_WillOtterbein_dotnet
{

    public partial class MDIChildForm : Form
    {
        // Default thickness and colors
        const float DEFAULT_B1 = 5f;
        const float DEFAULT_B2 = 20f;
        readonly Color DEFAULT_C1 = Color.FromArgb(255, 0, 0, 0);
        readonly Color DEFAULT_C2 = Color.FromArgb(255, 255, 255, 255);

        // Settable versions of the above
        float? b1 { get; set; } = null;
        float? b2 { get; set; } = null;

        // Pen 1 color
        Color _c1;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color C1
        {
            get => _c1;
            set
            {
                // Updating the UI screen parts that reflect the current pen1 color
                _c1 = (Color)value;
                this.pen1Selection.BackColor = (Color)value;
            }
        }
        // Pen 2 Color
        Color _c2;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color C2
        {
            get => _c2;
            set
            {
                // Updating the UI screen parts that reflect the current pen2 color
                _c2 = (Color)value;
                this.pen2Selection.BackColor = (Color)value;
            }
        }

        // Width of the bit map
        int _bmwidth;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BmWidth
        {
            get => _bmwidth;
            set
            {
                // Updating the UI Screen parts which indicate the canvas size
                _bmwidth = value;
                this.widthView.Text = $"Width: {value}";
            }
        }
        // Height of the bit map
        int _bmheight;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BmHeight
        {
            get => _bmheight;
            set
            {
                // Updating the UI screen parts whcih indicate canvas size
                _bmheight = value;
                this.heightView.Text = $"Height: {value}";
            }
        }

        // Graphics objects
        Pen DrawingPen { get; set; }
        Bitmap ImageBitmap;
        Graphics g;

        // Drawing logic stuff
        Point? PreviousPoint = null;
        bool Painting = false;

        public MDIChildForm(int? width = null, int? height = null, Color? background = null)
        {
            InitializeComponent();

            // BmWidth
            BmWidth = width ?? pictureBox1.Width;
            BmHeight = height ?? pictureBox1.Height;
            C1 = DEFAULT_C1;
            C2 = DEFAULT_C2;
            ImageBitmap = new Bitmap(BmWidth, BmHeight);

            // Size the picture box
            pictureBox1.Image = ImageBitmap;
            pictureBox1.Size = ImageBitmap.Size;
            panel1.AutoScrollMinSize = ImageBitmap.Size;

            // Blank Image, white background bitmap, smooth drawing mode
            g = Graphics.FromImage(ImageBitmap);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(background ?? DEFAULT_C2);


            // Define the default brushes
            DrawingPen = new(C1, b1 ?? DEFAULT_B1) { EndCap = LineCap.Round };
        }

        /// <summary>
        /// Event handler for when the mouse down button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ImageMouseDown(object sender, MouseEventArgs e)
        {
            // Determine which pen to use
            // Left click is pen 1
            // Right click is pen 2
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawingPen = new(C1, b1 ?? DEFAULT_B1) { EndCap = LineCap.Round };
                    break;
                case MouseButtons.Right:
                    DrawingPen = new(C2, b2 ?? DEFAULT_B2) { EndCap = LineCap.Round };
                    break;
            }

            Painting = true;
            PreviousPoint = e.Location;
        }

        /// <summary>
        /// Event handler for when the mouse is released (stop painting).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ImageMouseUp(object sender, MouseEventArgs e)
        {
            Painting = false;
            PreviousPoint = null;
        }

        /// <summary>
        /// Event handler for when the mouse moves.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ImageMouseMove(object sender, MouseEventArgs e)
        {
            // Must be in the Painting stage
            if (!Painting)
                return;

            if (PreviousPoint != null)
            {
                // Draw lines to the bitmap
                g.DrawLine(DrawingPen, PreviousPoint.Value.X, PreviousPoint.Value.Y, e.X, e.Y);
            }

            // Invalidate the picture box -- make it redraw
            PreviousPoint = e.Location;
            pictureBox1.Invalidate();
        }

        void MDIChildForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pen1Selection_Click(object sender, EventArgs e)
        {

        }

        private void pen2Selection_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Finalizer for the pane, dispose graphics resources used.
        /// </summary>
        ~MDIChildForm()
        {
            ImageBitmap.Dispose();
            g.Dispose();
        }
    }
}
