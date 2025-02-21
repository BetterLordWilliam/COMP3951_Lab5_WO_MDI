using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3951_Lab5_WillOtterbein_dotnet
{

    public partial class MDIChildForm : Form
    {

        readonly Brush PaneBrush1 = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
        readonly Brush PaneBrush2 = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
        Brush DrawingBrush;
        float thickness;

        Rectangle DrawingRect;
        Bitmap ImageBitmap;

        Point? PreviousPoint = null;
        bool Painting = false;

        public MDIChildForm()
        {
            InitializeComponent();

            // Initialize w/ Blank Image, white background bitmap
            ImageBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(ImageBitmap))
            {
                g.Clear(Color.FromArgb(255, 255, 255, 255));
            }
            
            // Default pens and thickness
            pictureBox1.Image = ImageBitmap;
            DrawingBrush = PaneBrush1;
            thickness = 5f;
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
                    DrawingBrush = PaneBrush1;
                    thickness = 5f;
                    break;
                case MouseButtons.Right:
                    DrawingBrush = PaneBrush2;
                    thickness = 20f;
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
                using (Graphics g = Graphics.FromImage(ImageBitmap))
                using (GraphicsPath p = new())
                {
                    p.AddRectangle(new RectangleF(PreviousPoint.Value.X, PreviousPoint.Value.Y, thickness, thickness));
                    g.FillPath(DrawingBrush, p);
                }
            }

            // Invalidate the picture box -- make it redraw
            PreviousPoint = e.Location;
            pictureBox1.Invalidate();
        }

        void MDIChildForm_Paint(object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// Finalizer for the pane, dispose graphics resources used.
        /// </summary>
        ~MDIChildForm()
        {
            ImageBitmap.Dispose();
        }
    }
}
