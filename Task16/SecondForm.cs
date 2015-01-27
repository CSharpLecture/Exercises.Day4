using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CsharpSolutions.Exercises.Task16
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okay_Click(object sender, EventArgs e)
        {
            Target.Text = input.Text;
            Close();
        }

        public Label Target { get; set; }
    }
}
