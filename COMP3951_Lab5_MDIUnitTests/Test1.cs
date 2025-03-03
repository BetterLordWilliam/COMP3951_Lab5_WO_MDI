using COMP3951_Lab5_WillOtterbein_dotnet;
using System.Drawing;
using System.Windows.Forms;

///
/// Will Otterbein
/// March 2 2025
///
namespace COMP3951_Lab5_MDIUnitTests
{
    [TestClass]
    public sealed class MDIFormTests
    {
        private MDIForm mdiForm;

        [TestInitialize]
        public void Setup()
        {
            mdiForm = new MDIForm();
        }

        [TestMethod]
        public void Test_MDIForm_MdiChildActivate_NoActiveChild()
        {
            // Act
            mdiForm.MDIForm_MdiChildActivate(null, EventArgs.Empty);

            // Assert
            Assert.IsFalse(mdiForm.SaveFileToolStripStatus);
        }

        [TestMethod]
        public void Test_FileSystemOperation_UnknownMenuItem()
        {
            // Arrange
            ToolStripMenuItem fakeItem = new ToolStripMenuItem { Name = "nonExistentItem" };

            // Act & Assert
            Assert.ThrowsException<KeyNotFoundException>(() =>
                mdiForm.fileSystemOpTest(fakeItem, EventArgs.Empty));
        }

        [TestMethod]
        public void Test_LayoutOperation_UnknownMenuItem()
        {
            // Arrange
            ToolStripMenuItem fakeItem = new ToolStripMenuItem { Name = "nonExistentItem" };

            // Act & Assert
            Assert.ThrowsException<KeyNotFoundException>(() =>
                mdiForm.layoutTest(fakeItem, EventArgs.Empty));
        }
    }

    /// <summary>
    /// Testing class for 
    /// </summary>
    [TestClass]
    public sealed class MDIChildFormTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeDefaults_WhenNoParametersProvided()
        {
            // Arrange & Act
            var form = new MDIChildForm();

            // Assert
            Assert.AreEqual("New image", form.Text);
            Assert.IsNotNull(form.PictureBoxImage);
            Assert.AreEqual(5f, form.B1); // DEFAULT_B1
            Assert.AreEqual(20f, form.B2); // DEFAULT_B2
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), form.C1); // DEFAULT_C1
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), form.C2); // DEFAULT_C2
        }

        [TestMethod]
        public void Constructor_ShouldSetProperties_WhenParametersProvided()
        {
            // Arrange
            int width = 100;
            int height = 200;
            Color background = Color.Blue;
            string title = "Custom Title";
            var image = new Bitmap(300, 300);

            // Act
            var form = new MDIChildForm(width, height, background, title, image);

            // Assert
            Assert.AreEqual(title, form.Text);
            Assert.AreEqual(image, form.PictureBoxImage);
            Assert.AreEqual(width, form.BmWidth);
            Assert.AreEqual(height, form.BmHeight);
            Assert.AreEqual(background, form.C2);
        }

        [TestMethod]
        public void ImageMouseDown_ShouldSetDrawingState_WhenButtonIsValid()
        {
            // Arrange
            var form = new MDIChildForm();
            var mouseEvent = new MouseEventArgs(MouseButtons.Left, 1, 10, 10, 0);

            // Act
            form.ImageMouseDown(null, mouseEvent);

            // Assert
            Assert.IsTrue(form.Painting);
        }

        [TestMethod]
        public void ImageMouseUp_ShouldResetPaintingState()
        {
            // Arrange
            var form = new MDIChildForm();
            var mouseEvent = new MouseEventArgs(MouseButtons.Left, 1, 10, 10, 0);

            // Act
            form.ImageMouseUp(null, mouseEvent);

            // Assert
            Assert.IsFalse(form.Painting);
        }

        [TestMethod]
        public void PenSelection_ShouldUpdatePenSettings()
        {
            // Arrange
            var form = new MDIChildForm();
            Color newColor = Color.Green;
            float newWidth = 15f;

            // Act
            form.C1 = newColor;
            form.B1 = newWidth;

            // Assert
            Assert.AreEqual(newColor, form.C1);
            Assert.AreEqual(newWidth, form.B1);
        }
    }
}
