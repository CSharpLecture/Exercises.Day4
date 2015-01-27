using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//We are defining an alias for the system environment
//because the name was not really suited for the job
using Env = System.Environment;
using System.IO;

namespace CsharpSolutions.Exercises.Task17
{
    public partial class Environment : Form
    {
        public Environment()
        {
            InitializeComponent();
            ReadValues();
        }

        //Read various values
        void ReadValues()
        {
            //Check whether x64
            checkBox1.Checked = Env.Is64BitOperatingSystem;
            //Get all logical drives
            comboBox1.Items.AddRange(Env.GetLogicalDrives());
            //Get the date of the start of the computer
            var uptime = TimeSpan.FromTicks(Env.TickCount);
            monthCalendar1.TodayDate = DateTime.Now.Subtract(uptime);
            //Add some things like username
            listBox1.Items.Add("User " + Env.UserName);
            listBox1.Items.Add("Domain " + Env.UserDomainName);
            comboBox1.SelectedIndex = 0;
        }

        //Trivial stuff here
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //We clear everything from before
            treeView1.Nodes.Clear();
            progressBar1.Value = 0;
            //Get the drive that is currently selected
            var path = comboBox1.SelectedItem.ToString();
            var drive = new DriveInfo(path);

            try
            {
                //Modify the progress bar with the free space in percent
                progressBar1.Value = (int)(drive.AvailableFreeSpace * 100 / drive.TotalSize);
                var dir = new DirectoryInfo(path);
                var node = new TreeNode(dir.Name);

                //This is obvious
                node.Nodes.AddRange
                (
                    dir.GetDirectories().Select(m => new TreeNode(m.Name)).ToArray()
                );

                //OK here we add it
                treeView1.Nodes.Add(node);
            }
            catch { }
        }
    }
}
