
namespace ExifViewerCSharp
{
    partial class map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(map));
            this.mapView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.mapView)).BeginInit();
            this.SuspendLayout();
            // 
            // mapView
            // 
            this.mapView.CreationProperties = null;
            this.mapView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.mapView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapView.Location = new System.Drawing.Point(0, 0);
            this.mapView.Name = "mapView";
            this.mapView.Size = new System.Drawing.Size(1033, 680);
            this.mapView.TabIndex = 0;
            this.mapView.ZoomFactor = 1D;
            // 
            // map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 680);
            this.Controls.Add(this.mapView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "map";
            this.Text = "map";
            this.Load += new System.EventHandler(this.map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 mapView;
    }
}