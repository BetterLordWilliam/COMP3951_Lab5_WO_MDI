using System.ComponentModel;

namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    partial class MDIChildForm : Form
    {
        // Defaults
        readonly float DEFAULT_B1 = 5f;
        readonly float DEFAULT_B2 = 20f;
        readonly Color DEFAULT_C1 = Color.FromArgb(255, 0, 0, 0);
        readonly Color DEFAULT_C2 = Color.FromArgb(255, 255, 255, 255);

        // Drawing logic stuff
        Point? PreviousPoint = null;
        bool Painting = false;

        // Settable versions of the above
        float _b1;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float B1
        {
            get => _b1;
            set
            {
                _b1 = value;
            }
        }
        float _b2;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float B2
        {
            get => _b2;
            set
            {
                _b2 = value;
            }
        }

        // Pen 1 color
        Color _c1;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color C1
        {
            get => _c1;
            set
            {
                // Updating the UI screen parts that reflect the current pen1 color
                _c1 = value;
                this.pen1Show.BackColor = value;
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
                _c2 = value;
                this.pen2Show.BackColor = value;
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

        public Image? PictureBoxImage { get => pictureBox1.Image; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FileStream? ImageFileStream { get; set; }
        Pen DrawingPen { get; set; }
        Graphics g;
    }
}