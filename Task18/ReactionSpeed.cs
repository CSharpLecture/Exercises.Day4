using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CsharpSolutions.Exercises.Task18
{
    public partial class ReactionSpeed : Form
    {
        //Let's add some members
        Stopwatch clock;
        Random rng;

        public ReactionSpeed()
        {
            //Don't forgot to instantiate the various objects
            rng = new Random();
            clock = new Stopwatch();
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            //Just enable the stop and disable the start button
            start.Enabled = false;
            stop.Enabled = true;
            //Get a random value for the interval (and start the timer)
            timer.Interval = rng.Next(400, 2000);
            timer.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            //If we are already running some measurements
            if (clock.IsRunning)
            {
                clock.Stop();
                elapsed.Text = clock.Elapsed.ToString();
                elapsed.ForeColor = Color.Green;
            }
            else
            {
                //Otherwise this dude is a cheater!
                timer.Stop();
                elapsed.Text = "CHEATER";
                elapsed.ForeColor = Color.Red;
            }

            //Reset everything back to the initial state
            stop.BackColor = SystemColors.Control;
            start.Enabled = true;
            stop.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Stop the timer and start the timing (indicate everything with red background)
            stop.BackColor = Color.Red;
            timer.Stop();
            clock.Reset();
            clock.Start();
        }
    }
}
