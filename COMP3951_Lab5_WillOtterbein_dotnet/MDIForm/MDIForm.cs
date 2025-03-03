using System.Linq.Expressions;
using System.ComponentModel;
using System.Drawing.Imaging;

///
/// Will Otterbein
/// March 2 2025
///
namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    public partial class MDIForm : Form
    {
        /// <summary>
        /// MDI main form constructor.
        /// </summary>
        public MDIForm()
        {
            InitializeComponent();

            // MID Layout operations
            mdiLayoutMap = new()
            {
                { "cascadeToolStripMenuItem", () => LayoutMdi(MdiLayout.Cascade) },
                { "horitonzalTilesToolStripMenuItem", () => LayoutMdi(MdiLayout.TileHorizontal) },
                { "verticalTilesToolStripMenuItem", () =>  LayoutMdi(MdiLayout.TileVertical) },
            };

            // File operations
            fileSystemOpMap = new()
            {
                { "openFileToolStripMenuItem", () => openFileHelperMethod() },
                { "saveFileToolStripMenuItem", () => saveFileHelperMethod() }
            };
        }

        /// <summary>
        /// Handle creating new windows (will be moved into different handler).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the add window dialog
            AddWindow aw = new AddWindow();
            if (aw.ShowDialog() == DialogResult.OK)
            {
                MDIChildForm child = new(aw.WidthInput, aw.HeightInput, aw.ColorInput)
                {
                    MdiParent = this
                };
                child.Show();
            }
        }

        /// <summary>
        /// Handle destroying the active window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Return if there is not active window
            if (ActiveMdiChild == null)
                return;

            // Show the dialog
            ConfirmClose cc = new ();
            if (cc.ShowDialog() == DialogResult.OK)
            {
                ActiveMdiChild?.Close();
            }
        }

        /// <summary>
        /// Enable/disable the savefile depending on if there are any active children.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MDIForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                saveFileToolStripMenuItem.Enabled = true;
            }
            else
            {
                saveFileToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Map save/load file helper methods.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fileSystemOpMap[((ToolStripMenuItem)sender).Name]();
            }
            catch (Exception ex) when (ex is ArgumentException || ex is KeyNotFoundException)
            {
                MessageBox.Show("Unknown file system operation.\n\n");
            }
        }

        /// <summary>
        /// Handle selection of a menu arrangement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mdiLayoutMap[((ToolStripMenuItem)sender).Name]();
            }
            catch (Exception ex) when (ex is ArgumentException || ex is KeyNotFoundException)
            {
                MessageBox.Show("Unknown document layout.\n\n");
            }
        }

        /// <summary>
        /// Testing version of the file system tool strip event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void fileSystemOpTest(object sender, EventArgs e)
        {
            fileSystemOpMap[((ToolStripMenuItem)sender).Name]();
        }

        /// <summary>
        /// Testing version of the layout tool strip event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void layoutTest(object sender, EventArgs e)
        {
            mdiLayoutMap[((ToolStripMenuItem)sender).Name]();
        }
    }
}
