using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    public partial class AddWindow : Form
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        public int WidthInput { get { return (int)this.widthEntry.Value; } }
        public int HeightInput { get { return (int)this.heightEntry.Value; } }
        public Color ColorInput { get { return (Color)this.colorBox.BackColor; } }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                colorBox.BackColor = cd.Color;
            }
        }
    }
}
