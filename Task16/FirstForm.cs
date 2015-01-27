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
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
            modalSelection.SelectedIndex = 0;
        }

        private void open_Click(object sender, EventArgs e)
        {
            var form = new SecondForm();
            form.Target = target;

            if (modalSelection.SelectedIndex == 0)
                form.ShowDialog();
            else
                form.Show();
        }
    }
}
