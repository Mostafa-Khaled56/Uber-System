
namespace Uber_System
{
    partial class Menus
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.requstTripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requstTripToolStripMenuItem,
            this.bookTripToolStripMenuItem,
            this.requestReportToolStripMenuItem,
            this.bookReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // requstTripToolStripMenuItem
            // 
            this.requstTripToolStripMenuItem.Name = "requstTripToolStripMenuItem";
            this.requstTripToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.requstTripToolStripMenuItem.Text = "Request Trip";
            this.requstTripToolStripMenuItem.Click += new System.EventHandler(this.requstTripToolStripMenuItem_Click);
            // 
            // bookTripToolStripMenuItem
            // 
            this.bookTripToolStripMenuItem.Name = "bookTripToolStripMenuItem";
            this.bookTripToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bookTripToolStripMenuItem.Text = "Book Trip";
            this.bookTripToolStripMenuItem.Click += new System.EventHandler(this.bookTripToolStripMenuItem_Click);
            // 
            // requestReportToolStripMenuItem
            // 
            this.requestReportToolStripMenuItem.Name = "requestReportToolStripMenuItem";
            this.requestReportToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.requestReportToolStripMenuItem.Text = "Request Report";
            this.requestReportToolStripMenuItem.Click += new System.EventHandler(this.requestReportToolStripMenuItem_Click);
            // 
            // bookReportToolStripMenuItem
            // 
            this.bookReportToolStripMenuItem.Name = "bookReportToolStripMenuItem";
            this.bookReportToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.bookReportToolStripMenuItem.Text = "Book Report";
            this.bookReportToolStripMenuItem.Click += new System.EventHandler(this.bookReportToolStripMenuItem_Click);
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 468);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem requstTripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReportToolStripMenuItem;
    }
}