namespace Torrent_File_Manager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpenTorrentsFolder = new System.Windows.Forms.Button();
            this.listTorrents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(360, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete Selected Torrents";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(360, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpenTorrentsFolder
            // 
            this.btnOpenTorrentsFolder.Location = new System.Drawing.Point(12, 256);
            this.btnOpenTorrentsFolder.Name = "btnOpenTorrentsFolder";
            this.btnOpenTorrentsFolder.Size = new System.Drawing.Size(360, 23);
            this.btnOpenTorrentsFolder.TabIndex = 0;
            this.btnOpenTorrentsFolder.Text = "Open Torrents Folder";
            this.btnOpenTorrentsFolder.UseVisualStyleBackColor = true;
            this.btnOpenTorrentsFolder.Click += new System.EventHandler(this.btnNavigateAppdataTorrentFolder_Click);
            // 
            // listTorrents
            // 
            this.listTorrents.FormattingEnabled = true;
            this.listTorrents.Location = new System.Drawing.Point(12, 12);
            this.listTorrents.Name = "listTorrents";
            this.listTorrents.Size = new System.Drawing.Size(360, 212);
            this.listTorrents.Sorted = true;
            this.listTorrents.TabIndex = 0;
            this.listTorrents.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 316);
            this.Controls.Add(this.listTorrents);
            this.Controls.Add(this.btnOpenTorrentsFolder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torrent File Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Window_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpenTorrentsFolder;
        private System.Windows.Forms.ListBox listTorrents;
    }
}

