using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restartApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pythonexeFile.Clear();
            devicePath.Clear();
            eventCode.Clear();
            apiKeyTextbox.Clear();
        }

        ProcessStartInfo psi = new ProcessStartInfo();

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        OpenFileDialog ofd = new OpenFileDialog();
        private void chooseDevice_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach(String file in ofd.FileNames)
                {
                    //psi.FileName = ofd.FileName;
                    //pythonexeFile.Text = ofd.FileName;
                    Console.WriteLine(file);
                }
                    
            }
        }

        private void devicePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void eventCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void scheduleGeneratorButton_Click(object sender, EventArgs e)
        {
          
            var api_key = apiKeyTextbox.Text;
            var event_key = eventCode.Text;
            string arg = string.Format(@"D:\Documents\GitHub\VS-Stuff\NET-Testing\NET-Testing\Scouting.py {0} {1}", event_key,api_key);
            psi.Arguments = arg;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            var errors = "";
            var results = "";
            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }
            devicePath.Text = results;
            Console.WriteLine(errors); 
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
