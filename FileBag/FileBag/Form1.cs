using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            fm.Location = this.Location;
            this.Visible = false;
            WebClient w = new WebClient();
            if(guna2ToggleSwitch1.Checked == false)
            {
                w.DownloadFile(guna2TextBox1.Text, "temporary.txt");
            }
            else
            {
                w.DownloadFile(guna2TextBox1.Text, guna2TextBox2.Text);
            }
            fm.Close();
            this.Visible = true;
            MessageBox.Show("File Path Copied!");
            string pth = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            System.Windows.Forms.Clipboard.SetText(pth);

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            guna2TextBox2.Enabled = guna2ToggleSwitch1.Checked;
        }
    }
}
