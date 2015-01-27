using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CsharpSolutions.Exercises.Task19
{
    public partial class LinqQueries : Form
    {
        //Here we save the generated data source
        int[] source;

        public LinqQueries()
        {
            InitializeComponent();

            //The code given in the exercise
            var random = new Random();
            source = Enumerable.Range(0, 100).Select(m => random.Next(0, 1000)).ToArray();
        }

        private void LinqQueries_Load(object sender, EventArgs e)
        {
            //We just initially display the data source
            reset_Click(sender, e);
        }

        void Display<T>(IEnumerable<T> src)
        {
            //Displaying is clearing the old items and adding new ones
            listBox.Items.Clear();

            foreach (var element in src)
                listBox.Items.Add(element);
        }

        void DisplaySingle<T>(T single)
        {
            //Also we might be interested in displaying a single element
            listBox.Items.Clear();
            listBox.Items.Add(single);
        }

        private void min_Click(object sender, EventArgs e)
        {
            //LINQ query for Min()
            DisplaySingle(source.Min());
        }

        private void max_Click(object sender, EventArgs e)
        {
            //LINQ query for Max()
            DisplaySingle(source.Max());
        }

        private void order_Click(object sender, EventArgs e)
        {
            //LINQ query for ordering the set (ascending)
            Display(source.OrderBy(m => m));
        }

        private void odd_Click(object sender, EventArgs e)
        {
            //Selecting all odd elements
            Display(source.Where(m => m % 2 == 1));
        }

        private void last_Click(object sender, EventArgs e)
        {
            //Skipping the first 15 and taking the next 10 (16-25)
            Display(source.Skip(15).Take(10));
        }

        private void hulk_Click(object sender, EventArgs e)
        {
            //This is the hulk
            DisplaySingle(source.Where(m => m > 999).LastOrDefault());
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Display(source);
        }
    }
}
