# COMP3951_Lab5_WillOtterbein_dotnet
Will Otterbein, COMP3951 Lab5, March 3 2025

## Features
The following sections outline the fetures of this application, explaining how to use the application.

---
### ✏️ Drawing
This section explains how to draw with this application.

1. Left-click to draw with the main pen, black ⬛ by default.
2. Right-click to draw with the secondary pen, white ⬜ by default.

> [!NOTE]
> Pen configuration is explained in the following table


| Pen                                                           | Pen Colour                            | Pen Thickness                                     | Default Configuration                                     |
| ------------------------------------------------------------- | ------------------------------------- | ------------------------------------------------- | --------------------------------------------------------- |
| Main pen ![Pen 1](./.gitresources/pen_menu_pen_1.png)         | Click **Select** in the pop-up pen menu | Enter a number > 0 or use the up-down selectors   | ![Pen color](./.gitresources/pen_menu_pen_colour.png)     |
| Secondary pen ![Pen 2](./.gitresources/pen_menu_pen_2.png)    | Click **Select** in the pop-up pen menu | Enter a number > 0 or use the up-down selectors   | ![Pen color](./.gitresources/pen_menu_pen_colour_1.png)   |

---
### 🖼️ Creating New Drawings
This section describes how to create a new drawing.

1. Click **Window** in the main window toolbar.
2. From the Window dropdown, click **New**.
3. Optionally, use the up/down selectors for width and height to set the width and height of the new drawing.

![Window config menu, width height](./.gitresources/new_window_dim.png)

4. Optionally, click the **Select** button to choose the background colour of the new drawing.

![Window config menu, colour config](./.gitresources/new_window_colour.png)

5. Click **Confirm** to create the drawing in a new child window.
6. You should see a blank canvas with your configured width/height and background colour.

![New window](./.gitresources/new_window_end.png)

---
### 📁 Loading Images from the File System
This section describes how to load an image for drawing from the file system.

1. Click **File** in the main window toolbar.
2. From the File dropdown, click **Open File**.
3. Select a file from your file system.

![Select file from file system example](./.gitresources/file_from_desktop.png)

4. You will see a new canvas with the image.

![File open in canvas example](./.gitresources/file_from_desktop_success.png)

> 📘 **Note** <br />
> The width/height will be that of the image, the main and secondary colours are the defaults, black and white.

---
### 🛜 Loading Images from the Internet 
This section describes how to load an image for drawing from the file system.

1. Click **File** in the main window toolbar.
2. From the File dropdown, click **Open Internet**.
3. Enter the URL of your image
4. Click **Load**.

> ⚠️ **Warning** <br />
> If a non-image resources is indicated by the URL, the loading will fail and you will need to specify a new URL to an image resource.

4. Upon successful retrieval of the image, the preview pane will be populated w/ your image.

![Internet file preview example](./.gitresources/file_from_internet_load_success.png)

5. Click **Confirm**
6. You will see a new canvas with the image.

![Internet file open in canvas example](./.gitresources/file_from_internet_success.png)

---
### 💾 Saving Drawings to Images
This section describes how you can save files to the file system.

1. Click **File** in the main window toolbar.
2. From the File dropdown, click **Save File**.
3. Navigate to a suitable location on your system.
4. Give the file a suitable name and select the file type

![Save file example](./.gitresources/file_save.png)

5. Click **Save**.
6. If the file already exists, either give the file a new name or overwrite the existing file.
