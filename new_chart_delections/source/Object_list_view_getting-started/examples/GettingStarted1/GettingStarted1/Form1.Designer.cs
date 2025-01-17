namespace GettingStarted1
{
    partial class Form1
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
            if (disposing && (components != null)) {
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
            this.olvSongs = new BrightIdeasSoftware.ObjectListView();
            this.titleColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.sizeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lastPlayedColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ratingColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // olvSongs
            // 
            this.olvSongs.AllColumns.Add(this.titleColumn);
            this.olvSongs.AllColumns.Add(this.sizeColumn);
            this.olvSongs.AllColumns.Add(this.lastPlayedColumn);
            this.olvSongs.AllColumns.Add(this.ratingColumn);
            this.olvSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumn,
            this.sizeColumn,
            this.lastPlayedColumn,
            this.ratingColumn});
            this.olvSongs.HideSelection = false;
            this.olvSongs.Location = new System.Drawing.Point(12, 26);
            this.olvSongs.Name = "olvSongs";
            this.olvSongs.ShowGroups = false;
            this.olvSongs.Size = new System.Drawing.Size(565, 185);
            this.olvSongs.TabIndex = 0;
            this.olvSongs.UseCompatibleStateImageBehavior = false;
            this.olvSongs.View = System.Windows.Forms.View.Details;
            // 
            // titleColumn
            // 
            this.titleColumn.AspectName = "Title";
            this.titleColumn.Text = "Title";
            this.titleColumn.Width = 158;
            // 
            // sizeColumn
            // 
            this.sizeColumn.AspectName = "GetSizeInMb";
            this.sizeColumn.AspectToStringFormat = "{0:#,##0.0}";
            this.sizeColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizeColumn.Text = "Size (MB)";
            this.sizeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizeColumn.Width = 94;
            // 
            // lastPlayedColumn
            // 
            this.lastPlayedColumn.AspectName = "LastPlayed";
            this.lastPlayedColumn.AspectToStringFormat = "{0:d}";
            this.lastPlayedColumn.Text = "Last Played";
            this.lastPlayedColumn.Width = 150;
            // 
            // ratingColumn
            // 
            this.ratingColumn.AspectName = "Rating";
            this.ratingColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ratingColumn.Text = "Rating";
            this.ratingColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ratingColumn.Width = 85;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.AllColumns.Add(this.olvColumn3);
            this.objectListView1.AllColumns.Add(this.olvColumn4);
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(12, 247);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(565, 212);
            this.objectListView1.TabIndex = 1;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.Text = "Title";
            // 
            // olvColumn2
            // 
            this.olvColumn2.Text = "Size";
            // 
            // olvColumn3
            // 
            this.olvColumn3.Text = "Last Played";
            // 
            // olvColumn4
            // 
            this.olvColumn4.Text = "Rating";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 471);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.olvSongs);
            this.Name = "Form1";
            this.Text = "ObjectListView Getting Started 1";
            ((System.ComponentModel.ISupportInitialize)(this.olvSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvSongs;
        private BrightIdeasSoftware.OLVColumn titleColumn;
        private BrightIdeasSoftware.OLVColumn sizeColumn;
        private BrightIdeasSoftware.OLVColumn lastPlayedColumn;
        private BrightIdeasSoftware.OLVColumn ratingColumn;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
    }
}

