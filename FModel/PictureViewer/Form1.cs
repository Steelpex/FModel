using FModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;    // you need to add this Namespace to access FolderBrowser
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRpcDemo;
using System.Drawing.Imaging;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        string currentDir = "";
        private Form2 f2;
        private Form3 f3;
        private Form5 f5;
        private Image img;
        private string imageName;

        public object Form2 { get; private set; }

        public Form1()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var fb = new FolderBrowserDialog();
                if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    currentDir = fb.SelectedPath; // get the selected folder by the user; 

                    // display current directory in the text box
                    textBoxDirectory.Text = currentDir;

                    // get all image files from the directory
                    // first create directory info
                    var dirInfo = new DirectoryInfo(currentDir);

                    // get the files
                    var files = dirInfo.GetFiles().Where(c => (c.Extension.Equals(".jpg") || c.Extension.Equals(".jpeg") || c.Extension.Equals(".bmp") || c.Extension.Equals(".png")));
                    foreach (var image in files)
                    {
                        // add images (file names) to the list box
                        listBoxImages.Items.Add(image.Name); // we could add full path to the list but it won't look good. 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: " + ex.Message + " " + ex.Source);
            }
        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("797901799046119424", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("797901799046119424", ref this.handlers, true, null);
            this.presence.details = "67/67 PAK Files";
            this.presence.state = "Paks_CID_6100_Athena_Commando_M_CreativeDestruction";
            System.DateTime epoch = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
            long cur_time = (long)(System.DateTime.UtcNow - epoch).TotalSeconds;

            this.presence.startTimestamp = cur_time;
            this.presence.largeImageKey = "large";
            this.presence.smallImageKey = "small";
            this.presence.largeImageText = "";
            this.presence.smallImageText = "v3.1.2";
            DiscordRpc.UpdatePresence(ref this.presence);

            listBox1.Visible = true;
            try
            {
                // get the selected image
                var selectedImage = listBoxImages.SelectedItems[0].ToString();
                if (!string.IsNullOrEmpty(selectedImage) && !string.IsNullOrEmpty(currentDir))
                {
                    // make the full path to the image. 
                    var fullPath = Path.Combine(currentDir, selectedImage);

                    // set an image from file to the PictureBox
                    pictureBoxImagePreview.Image = Image.FromFile(fullPath);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBoxDirectory_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxImagePreview_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("797901799046119424", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("797901799046119424", ref this.handlers, true, null);
            this.presence.details = "Creative Destruction - Idling";

            System.DateTime epoch = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
            long cur_time = (long)(System.DateTime.UtcNow - epoch).TotalSeconds;

            this.presence.startTimestamp = cur_time;
            this.presence.state = "";
            this.presence.largeImageKey = "large";
            this.presence.smallImageKey = "small";
            this.presence.largeImageText = "";
            this.presence.smallImageText = "v3.1.2";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private long Timer(int v)
        {
            throw new NotImplementedException();
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            try
            {
                var fb = new FolderBrowserDialog();
                if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    currentDir = fb.SelectedPath; // get the selected folder by the user; 

                    // display current directory in the text box
                    textBoxDirectory.Text = currentDir;

                    // get all image files from the directory
                    // first create directory info
                    var dirInfo = new DirectoryInfo(currentDir);

                    // get the files
                    var files = dirInfo.GetFiles().Where(c => (c.Extension.Equals(".jpg") || c.Extension.Equals(".jpeg") || c.Extension.Equals(".bmp") || c.Extension.Equals(".png")));
                    foreach (var image in files)
                    {
                        // add images (file names) to the list box
                        listBoxImages.Items.Add(image.Name); // we could add full path to the list but it won't look good. 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: " + ex.Message + " " + ex.Source);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void aesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.Show();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBoxImages_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}