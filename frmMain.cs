using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using MetadataExtractor.Formats.Xmp;

using System.Drawing.Imaging;

namespace ExifViewerCSharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string exifString;
        private void loadPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.btnViewOnGoogleMaps.Visible = false;
            populateResults(this.openFileDialog1.FileName);
          


        }
        private void populateResults(string filename)
        {
            exifEngine exif = new exifEngine();
            exifData exd = new exifData();
            exd = exif.getExifData(filename);

            if (exd != null)
            {
                utility u = new utility();
                this.txtExif.Text = u.BuildString(exd);
                this.exifString = u.getRawExifData(filename);
                if (u.hasGeo == true)
                {
                    this.btnViewOnGoogleMaps.Visible = true;
                }
            }
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            this.pictureBox1.Image = System.Drawing.Image.FromStream(fs);
            fs.Close();
            this.showAllEXIFDataToolStripMenuItem.Enabled = true;
            
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            string filename = Path.GetFileName(files[0]);
            string extension = Path.GetExtension(files[0]);
            if (extension !=".jpg" && extension != ".jpeg")
            {
                this.Cursor = Cursors.No;
                e.Effect = DragDropEffects.None;

            }
            else
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                this.btnViewOnGoogleMaps.Visible = false;
                populateResults(files[0]);

            }
        }

        private void btnViewOnGoogleMaps_Click(object sender, EventArgs e)
        {
            map m = new map();
            m.mapURL = utility.osmapURL;
            m.Show();
            
        }

        private void showAllEXIFDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allExif ax = new allExif();
            ax.allExifString = this.exifString;
            ax.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.Show();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
