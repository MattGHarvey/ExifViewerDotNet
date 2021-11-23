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

        private void loadPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();

            exifEngine exif = new exifEngine();
            string res = exif.getExifString(this.openFileDialog1.FileName);
            exifData exd = new exifData();
            exd = exif.getExifData(openFileDialog1.FileName);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
