using System;
using System.Windows.Forms;

namespace CsharpSolutions.Exercises.Task20
{
    public partial class MyControl : UserControl
    {
        //Just place two fields for the remaining seconds and the seconds from the beginning
        int seconds;
        int remaining;

        public MyControl()
        {
            InitializeComponent();
            //Set both with their property-setters
            Seconds = 5;
            Remaining = seconds;
        }

        //This is a read-only property
        public int Remaining
        {
            get { return remaining; }
            private set
            {
                remaining = value;

                if (timer.Enabled)
                {
                    label.Text = String.Format("{0}s", remaining.ToString());

                    if (remaining == 0)
                    {
                        button.Text = "Reset";
                        timer.Stop();
                    }
                }
            }
        }

        //This one could be also modified
        public int Seconds
        {
            get { return seconds; }
            set
            {
                seconds = Math.Max(0, value);

                //Only if currently no timer is running
                if (!timer.Enabled)
                {
                    //Set the button text once the value is modified
                    button.Text = String.Format("Start ({0}ms)", Seconds);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            //If no timer is running
            if (!timer.Enabled)
            {
                //and if there is nothing remaining
                if (Remaining == 0)
                {
                    //then reset everything
                    Remaining = seconds;
                    Seconds = seconds;
                }
                else
                {
                    //Otherwise start the countdown
                    button.Text = "Stop";
                    timer.Start();
                    Remaining = seconds;
                }
            }
            else //or just stop everything
                Remaining = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Decrement (i.e. countdown)
            Remaining--;
        }
    }
}
