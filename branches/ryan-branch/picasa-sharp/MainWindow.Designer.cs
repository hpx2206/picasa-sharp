namespace picasa_sharp {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.albumList = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadSelectedAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.permissionData = new System.Windows.Forms.Label();
            this.permissionLabel = new System.Windows.Forms.Label();
            this.lblNumPictures = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.albumPhotoBrowser = new System.Windows.Forms.WebBrowser();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // albumList
            // 
            this.albumList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.albumList.FormattingEnabled = true;
            this.albumList.ItemHeight = 16;
            this.albumList.Location = new System.Drawing.Point(13, 32);
            this.albumList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.albumList.Name = "albumList";
            this.albumList.Size = new System.Drawing.Size(204, 484);
            this.albumList.TabIndex = 2;
            this.albumList.SelectedIndexChanged += new System.EventHandler(this.albumList_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(873, 24);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.createNewAlbumToolStripMenuItem,
            this.downloadSelectedAlbumToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripDropDownButton1.Text = "Actions";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // createNewAlbumToolStripMenuItem
            // 
            this.createNewAlbumToolStripMenuItem.Name = "createNewAlbumToolStripMenuItem";
            this.createNewAlbumToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.createNewAlbumToolStripMenuItem.Text = "Create New Album";
            this.createNewAlbumToolStripMenuItem.Click += new System.EventHandler(this.createNewAlbumToolStripMenuItem_Click);
            // 
            // downloadSelectedAlbumToolStripMenuItem
            // 
            this.downloadSelectedAlbumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.propertiesToolStripMenuItem1});
            this.downloadSelectedAlbumToolStripMenuItem.Name = "downloadSelectedAlbumToolStripMenuItem";
            this.downloadSelectedAlbumToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.downloadSelectedAlbumToolStripMenuItem.Text = "Selected Album";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.propertiesToolStripMenuItem.Text = "Upload";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem1
            // 
            this.propertiesToolStripMenuItem1.Name = "propertiesToolStripMenuItem1";
            this.propertiesToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.propertiesToolStripMenuItem1.Text = "Properties";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(16, 11);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(105, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Not Connected!";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.albumPhotoBrowser);
            this.groupBox1.Controls.Add(this.permissionData);
            this.groupBox1.Controls.Add(this.permissionLabel);
            this.groupBox1.Controls.Add(this.lblNumPictures);
            this.groupBox1.Controls.Add(this.txtBoxDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(225, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(635, 484);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Album Info";
            // 
            // permissionData
            // 
            this.permissionData.AutoSize = true;
            this.permissionData.Location = new System.Drawing.Point(97, 59);
            this.permissionData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.permissionData.Name = "permissionData";
            this.permissionData.Size = new System.Drawing.Size(0, 17);
            this.permissionData.TabIndex = 13;
            // 
            // permissionLabel
            // 
            this.permissionLabel.AutoSize = true;
            this.permissionLabel.Location = new System.Drawing.Point(8, 59);
            this.permissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.permissionLabel.Name = "permissionLabel";
            this.permissionLabel.Size = new System.Drawing.Size(81, 17);
            this.permissionLabel.TabIndex = 10;
            this.permissionLabel.Text = "Permission:";
            // 
            // lblNumPictures
            // 
            this.lblNumPictures.AutoSize = true;
            this.lblNumPictures.Location = new System.Drawing.Point(108, 88);
            this.lblNumPictures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumPictures.Name = "lblNumPictures";
            this.lblNumPictures.Size = new System.Drawing.Size(0, 17);
            this.lblNumPictures.TabIndex = 7;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(269, 23);
            this.txtBoxDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.ReadOnly = true;
            this.txtBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDescription.Size = new System.Drawing.Size(358, 82);
            this.txtBoxDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Photos:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(65, 29);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 17);
            this.lblName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // albumPhotoBrowser
            // 
            this.albumPhotoBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.albumPhotoBrowser.Location = new System.Drawing.Point(11, 113);
            this.albumPhotoBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.albumPhotoBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.albumPhotoBrowser.Name = "albumPhotoBrowser";
            this.albumPhotoBrowser.Size = new System.Drawing.Size(616, 363);
            this.albumPhotoBrowser.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.albumList);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Picasa-Sharp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox albumList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem createNewAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadSelectedAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumPictures;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.WebBrowser albumPhotoBrowser;
        private System.Windows.Forms.Label permissionLabel;
        private System.Windows.Forms.Label permissionData;
    }
}

