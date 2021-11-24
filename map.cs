using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
namespace ExifViewerCSharp
{
    public partial class map : Form
    {
        public string mapURL;
        public map()
        {
            InitializeComponent();
        }

        private void map_Load(object sender, EventArgs e)
        {

           
            mapView.EnsureCoreWebView2Async();
            
            mapView.Source = new Uri(mapURL);
            
        }
    }
}
