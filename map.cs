using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ExifViewerCSharp
{
    public partial class Map : Form
    {
        public string mapURL;
        public Map()
        {
            InitializeComponent();
        }

        private void map_Load(object sender, EventArgs e)
        {

           
          
            
            mapView.Navigate(new Uri(mapURL));

            
        }
    }
}
