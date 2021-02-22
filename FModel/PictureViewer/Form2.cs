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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Tx1 = textBox1.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
            textBox1.Text = Properties.Settings.Default.Tx1;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Tx1 = textBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
}
