
namespace ExifViewerCSharp
{
    partial class allExif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allExif));
            this.txtAllExif = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAllExif
            // 
            this.txtAllExif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAllExif.Location = new System.Drawing.Point(0, 0);
            this.txtAllExif.Multiline = true;
            this.txtAllExif.Name = "txtAllExif";
            this.txtAllExif.ReadOnly = true;
            this.txtAllExif.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAllExif.Size = new System.Drawing.Size(800, 450);
            this.txtAllExif.TabIndex = 0;
            this.txtAllExif.TabStop = false;
            // 
            // allExif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAllExif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "allExif";
            this.Text = "All Image Metadata";
            this.Load += new System.EventHandler(this.allExif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAllExif;
    }
}