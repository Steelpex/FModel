using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FModel
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Image image = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Desert.jpg"))
            using (Image watermarkImage = Image.FromFile(@"C:\Paks_CID_6100_Athena_Commando_M_CreativeDestruction\Output\Watermark\Leaker instagram.png"))
            using (Graphics imageGraphics = Graphics.FromImage(image))
            using (Brush watermarkBrush = new TextureBrush(watermarkImage))
            {
                int x = (image.Width - watermarkImage.Width) / 2;
                int y = (image.Height - watermarkImage.Height) / 2;
                imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), watermarkImage.Size));
                image.Save(@"C:\Paks_CID_6100_Athena_Commando_M_CreativeDestruction\Output\Watermark\Leaker instagram.png");
            }
        }
    }
}
