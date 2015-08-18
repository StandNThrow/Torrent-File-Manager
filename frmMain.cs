using Microsoft.VisualBasic.FileIO;
using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Torrent_File_Manager
{
    public partial class frmMain : Form
    {
        string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string uTorrentAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\uTorrent\\";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            
            // listTorrents.SelectionMode = SelectionMode.MultiExtended;

            Console.WriteLine(uTorrentAppDataPath);
            string[] torrentFiles = Directory.GetFiles(uTorrentAppDataPath, "*.torrent");

            foreach (string TorrentFile in torrentFiles)
            {
                
                listTorrents.Items.Add(Path.GetFileName(TorrentFile));
                listTorrents.Sorted = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteTorrent();
        }

        private void deleteTorrent()
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete " + listTorrents.SelectedItem + "? \n You can restore the deleted item from the Recycle Bin later.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    FileSystem.DeleteFile(uTorrentAppDataPath + listTorrents.SelectedItem,
                        UIOption.OnlyErrorDialogs,
                        RecycleOption.SendToRecycleBin);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(),
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                listTorrents.Items.Remove(listTorrents.SelectedItem);
                listTorrents.SelectedIndex = 0;
                listTorrents.Focus();
            }
            else
            {
                // Do nothing
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteTorrent();
                e.Handled = true;
            }
        }

        private void btnNavigateAppdataTorrentFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @uTorrentAppDataPath);
        }
    }
}